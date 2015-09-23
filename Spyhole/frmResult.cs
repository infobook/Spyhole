using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using CommandAS.QueryLib;
using CommandAS.Tools;

namespace Spyhole
{
  public partial class frmResult : Form
  {
    private Performer _qp;

    private string _regPath
    {
      get { return frmSpyhole.REG_APP_PATH + @"\ResultForm"; }
    }

    public Performer pQueryPerformer
    {
      get { return _qp;  }
      set
      {
        _qp = value;

        _cboDataSet.SelectedIndexChanged -= new EventHandler(_cboDataSet_SelectedIndexChanged);

        _cboDataSet.Items.Clear();
        foreach (DataTable dTab in _qp.pResultSet.Tables)
          _cboDataSet.Items.Add(dTab.TableName);

        _cboDataSet.SelectedIndexChanged += new EventHandler(_cboDataSet_SelectedIndexChanged);

        if (_cboDataSet.Items.Count > 0)
          _cboDataSet.SelectedIndex = 0;

      }
    }

    public frmResult()
    {
      this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
      this.ControlBox = false;

      InitializeComponent();

      _dgv.ReadOnly = true;

      this.Text = Properties.Resources.frmR_Title;
      _lblDateSet.Text = Properties.Resources.frmR_lblDataSet;
      
      _cmdOk.Click += new EventHandler(_cmdOk_Click);

      this.Load += new EventHandler(frmResult_Load);
    }

    void frmResult_Load(object sender, EventArgs e)
    {
      RegistryKey regkey = Registry.CurrentUser.OpenSubKey(_regPath);

      try
      {
        if (regkey != null)
        {
          CASToolsReg.LoadSizeLocationMaximizeForm(regkey, this);
        }
      }
      catch { }

      _resizeTabCol();
      //this.TopMost = true;
    }

    void _cmdOk_Click(object sender, EventArgs e)
    {
      this.Close();

      RegistryKey regkey = Registry.CurrentUser.OpenSubKey(_regPath, true);
      if (regkey == null)
        regkey = Registry.CurrentUser.CreateSubKey(_regPath);
      CASToolsReg.SaveSizeLocationMaximizeForm(regkey, this);

    }

    void _cboDataSet_SelectedIndexChanged(object sender, EventArgs e)
    {
      _dgv.DataSource = _qp.pResultSet.Tables[_cboDataSet.Text];
      _resizeTabCol();
    }

    private void _resizeTabCol()
    {
      _dgv.AutoResizeColumns();

    }
  }
}