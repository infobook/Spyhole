using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CommandAS.QueryLib;

namespace Spyhole
{
  public partial class frmResult : Form
  {
    private Performer _qp;

    public Performer pQueryPerformer
    {
      get { return _qp;  }
      set
      {
        _qp = value;

        _cboDataSet.SelectedIndexChanged -= new EventHandler(_cboDataSet_SelectedIndexChanged);

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
      
      _cmdOk.Click += new EventHandler(_cmdOk_Click);
    }

    void _cmdOk_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    void _cboDataSet_SelectedIndexChanged(object sender, EventArgs e)
    {
      _dgv.DataSource = _qp.pResultSet.Tables[_cboDataSet.Text];
    }

  }
}