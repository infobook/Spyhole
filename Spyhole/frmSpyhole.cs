using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Win32;
using CommandAS.Tools;
using CommandAS.QueryLib;

namespace Spyhole
{
  public partial class frmSpyhole : Form
  {
    public const string REG_APP_PATH = @"SOFTWARE\SoftCommandAs\Spyhole";
    public const string PROGRAMM_JOURNAL_DEFAULT_FILE_NAME = ".\\spyhole.pj";

    private ProgramJournal _jn;
    private bool _sysShutdown;
    private StringBuilder _strTrace;
    BackgroundWorker _bw;

    public NotifyIcon pNi;

    private bool _IsTrace
    {
      set
      {
        _tsbStop.Enabled = value;
        _tsbStart.Enabled = !_tsbStop.Enabled;
      }
      get
      {
        return _tsbStop.Enabled;
      }
    }

    public frmSpyhole()
    {
      _sysShutdown = false;
      _strTrace = new StringBuilder();

      _jn = new ProgramJournal();
      _jn.OutputTextBox = _txtTrace;

      InitializeComponent();

      _initLocation();

      this.Icon = Properties.Resources.spyhole004i;
      //this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.ControlBox = false;

      _cmdOk.Click += new EventHandler(_cmdOk_Click);

      //  создание трея для сокрытия формы
      pNi = new NotifyIcon();	//this.components
      pNi.Icon = Properties.Resources.spyhole004i;
      pNi.Text = "Spyhole";
      pNi.DoubleClick += new EventHandler(_niOnDoubleClick);
      pNi.ContextMenu = CreateMenu();
      pNi.Visible = true;

      //_thdRunTask = null;
      _bw = new BackgroundWorker();
      _bw.WorkerReportsProgress = true;
      _bw.WorkerSupportsCancellation = true;
      _bw.DoWork += new DoWorkEventHandler(_bw_DoWork);
      _bw.ProgressChanged += new ProgressChangedEventHandler(_bw_ProgressChanged);
      _bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(_bw_RunWorkerCompleted);

      this.Load += new EventHandler(frmSpyhole_Load);
      this.Closing += new CancelEventHandler(_OnClosing);
      this.Closed += new EventHandler(_OnClosed);

      _cmdSave2Reg.Image = Properties.Resources.Save.ToBitmap();

      _ts.ImageScalingSize = new Size(32, 32);
      _tsbStart.Image = Properties.Resources.Down.ToBitmap();
      _tsbStop.Image = Properties.Resources.Cancel.ToBitmap();
      _tsbClear.Image = Properties.Resources.Blank.ToBitmap();

      _IsTrace = true;

      SetNIMenuEnabledOnOff();
    }

    private void _initLocation()
    {
      this.Text = Properties.Resources.frmS_Title;

      _tbpParam.Text = Properties.Resources.frmS_tcpParam;
      _tbpTrace.Text = Properties.Resources.frmS_tcpTrace;

      _lblSession.Text = Properties.Resources.frmS_lblSession;
      _lblPauseSec.Text = Properties.Resources.frmS_lblPauseSec;
      _lblLogFile.Text = Properties.Resources.frmS_lblLogFile;
      _stlCount.Text = Properties.Resources.frmS_stlCount;

      _cmdSave2Reg.Text = Properties.Resources.frmS_cmdSave2Reg;
      //_cmdOk
      _tsbStart.ToolTipText = Properties.Resources.frmS_stbStartTT;
      _tsbStop.ToolTipText = Properties.Resources.frmS_stbStopTT;
      _tsbClear.ToolTipText = Properties.Resources.frmS_stbClearTT;
    }

    void frmSpyhole_Load(object sender, EventArgs e)
    {
      LoadParametersFromRegister();
    }

    void _bw_DoWork(object sender, DoWorkEventArgs e)
    {
      BackgroundWorker worker = (BackgroundWorker)sender;
      Spyhole sh = (Spyhole)e.Argument;
      sh.Run(worker, e);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e">
    /// e.ProgressPercentage:
    /// 0 - trace message
    /// 1 - journal message
    /// 2 - count
    /// </param>
    void _bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      if (Visible && _tbc.SelectedTab.Name.Equals(_tbpTrace.Name) && _IsTrace)
      {
        if (e.ProgressPercentage == 2)
        {
          _txtCount.Text = ((Spyhole.CurrentState)e.UserState).Text;
        }
        else
        {
          Spyhole.CurrentState state = (Spyhole.CurrentState)e.UserState;
          _strTrace.Append(Environment.NewLine);
          _strTrace.Append(state.Text);
          _txtTrace.Text = _strTrace.ToString();
          if (e.ProgressPercentage == 1)
          {
            _jn.Debug = state.Text;
          }
        }
      }

      this.Refresh();
      this.Validate();
    }

    void _bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (e.Error != null)
      {
        _jn.Error = e.Error.Message;
      }
      else if (e.Cancelled)
      {
        _jn.Debug = "Spyhole canceled!";
      }
      else
      {
        _jn.Debug = "Spyhole finished";
      }

    }

    private void _OnClosing(object sender, CancelEventArgs e)
    {
      if (_sysShutdown)
      {
        if (pNi != null)
        {
          if (pNi.ContextMenu != null)
            pNi.ContextMenu.Dispose();
          pNi.Visible = false;
          pNi.Dispose();
        }
      }
      else
      {
        //SetNIMenuEnabledOnOff(true, false);
        this.WindowState = FormWindowState.Minimized;
        this.ShowInTaskbar = false;
        _jn.OutputTextBox = null;
        e.Cancel = true;
      }
    }

    private void _OnClosed(object sender, EventArgs e)
    {
      //SaveParametersToRegister();
    }

    void _cmdOk_Click(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Minimized;
      this.ShowInTaskbar = false;
    }

    private void _niOnDoubleClick(object sender, EventArgs e)
    {
      RestoreForm();
    }

    //  восстановление формы из трея
    private void RestoreForm()
    {
      this.WindowState = FormWindowState.Normal;
      Visible = true;
      _jn.OutputTextBox = _txtTrace;
    }

    private ContextMenu CreateMenu()
    {
      ContextMenu cm = new ContextMenu(new MenuItem[] {
				new MenuItem(Properties.Resources.mnuTrParam), 
				new MenuItem(Properties.Resources.mnuStart),
				new MenuItem(Properties.Resources.mnuStop),
				new MenuItem("-"),
				new MenuItem(Properties.Resources.mnuExit) });
      cm.MenuItems[0].Click += new EventHandler(OnCntMIParamClick);
      cm.MenuItems[1].Click += new EventHandler(OnCntMIRunClick);
      cm.MenuItems[2].Click += new EventHandler(OnCntMICancelClick);
      //cm.MenuItems[3].Click += new EventHandler(OnCntMITraceClick);
      cm.MenuItems[4].Click += new EventHandler(OnCntMIExitClick);

      return cm;
    }

    private void OnCntMIParamClick(object sender, EventArgs e)
    {
      RestoreForm();
    }

    private void OnCntMIRunClick(object sender, EventArgs e)
    {
      Spyhole sh = new Spyhole();
      // initial Spyhole here
      sh.pSessionFileName = _txtSession.Text;
      sh.pPauseIntevalInSeconds = Convert.ToInt32(_nudPauseSec.Value);
      _bw.RunWorkerAsync(sh);

      SetNIMenuEnabledOnOff();
    }

    private void OnCntMICancelClick(object sender, EventArgs e)
    {
      _bw.CancelAsync();
      SetNIMenuEnabledOnOff();
    }

    //private void OnCntMITraceClick(object sender, EventArgs e)
    //{
    //  RestoreForm();
    //}

    private void OnCntMIExitClick(object sender, EventArgs e)
    {
      _sysShutdown = true;
      Close();
    }

    //  доступность/недоступность пунктов контекстного меню у трея
    private void SetNIMenuEnabledOnOff()
    {
      //if (_thdRunTask != null)
      //  pNi.ContextMenu.MenuItems[1].Text = "Pause";
      //else
      //  pNi.ContextMenu.MenuItems[1].Text = "Run";

      //pNi.ContextMenu.MenuItems[2].Enabled = _thdRunTask != null;
    }

    private void _tsbStart_Click(object sender, EventArgs e)
    {
      _IsTrace = true;
    }

    private void _tsbStop_Click(object sender, EventArgs e)
    {
      _IsTrace = false;
    }

    private void _tsbClear_Click(object sender, EventArgs e)
    {
      _strTrace.Remove(0, _strTrace.Length);
      _txtTrace.Text = _strTrace.ToString();
    }

    private void _cmdBrowseSession_Click(object sender, EventArgs e)
    {
      OpenFileDialog dlg = new OpenFileDialog();
      dlg.Filter = "Сессия (*" + Performer.CURRENT_SESSION_EXT + ")|*" + Performer.CURRENT_SESSION_EXT;
      if (dlg.ShowDialog() == DialogResult.OK)
      {
        _txtSession.Text = dlg.FileName;
      }
    }

    private void _cmdBrowseLogFile_Click(object sender, EventArgs e)
    {

    }

    private void _cmdSave2Reg_Click(object sender, EventArgs e)
    {
      SaveParametersToRegister();
    }

    private void LoadParametersFromRegister()
    {
      RegistryKey regkey = Registry.CurrentUser.OpenSubKey(REG_APP_PATH);

      try
      {
        if (regkey != null)
        {
          CASToolsReg.LoadSizeLocationMaximizeForm(regkey, this);
          Object obj = regkey.GetValue("FileNameSession");
          if (obj != null)
            _txtSession.Text = obj.ToString();
          obj = regkey.GetValue("FileNameJournal");
          if (obj != null)
            _txtLogFile.Text = obj.ToString();

          obj = regkey.GetValue("PauseInSeconds");
          if (obj != null)
            _nudPauseSec.Value = Decimal.Parse(obj.ToString());
        }
      }
      catch { }


      //CASToolsReg.LoadDataGridParameter(regkey, _dgvPers, _dgvPers.Name);
      //CASToolsReg.LoadDataGridParameter(regkey, _dgvTeam, _dgvTeam.Name);
    }

    private void SaveParametersToRegister()
    {
      RegistryKey regkey = Registry.CurrentUser.OpenSubKey(REG_APP_PATH, true);
      if (regkey == null)
        regkey = Registry.CurrentUser.CreateSubKey(REG_APP_PATH);
      CASToolsReg.SaveSizeLocationMaximizeForm(regkey, this);
      //CASToolsReg.SaveDataGridParameter(regkey, _dgvPers, _dgvPers.Name);
      //CASToolsReg.SaveDataGridParameter(regkey, _dgvTeam, _dgvTeam.Name);

      regkey.SetValue("FileNameSession", _txtSession.Text);
      regkey.SetValue("FileNameJournal", _txtLogFile.Text);
      regkey.SetValue("PauseInSeconds", _nudPauseSec.Value);

      regkey.Close();
    }
  }
}