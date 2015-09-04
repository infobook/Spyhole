namespace Spyhole
{
  partial class frmResult
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this._tlp = new System.Windows.Forms.TableLayoutPanel();
      this._cmdOk = new System.Windows.Forms.Button();
      this._cboDataSet = new System.Windows.Forms.ComboBox();
      this._lblDateSet = new System.Windows.Forms.Label();
      this._dgv = new System.Windows.Forms.DataGridView();
      this._tlp.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this._dgv)).BeginInit();
      this.SuspendLayout();
      // 
      // _tlp
      // 
      this._tlp.ColumnCount = 3;
      this._tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this._tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this._tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this._tlp.Controls.Add(this._cmdOk, 1, 4);
      this._tlp.Controls.Add(this._cboDataSet, 2, 0);
      this._tlp.Controls.Add(this._lblDateSet, 1, 0);
      this._tlp.Controls.Add(this._dgv, 0, 2);
      this._tlp.Dock = System.Windows.Forms.DockStyle.Fill;
      this._tlp.Location = new System.Drawing.Point(0, 0);
      this._tlp.Name = "_tlp";
      this._tlp.RowCount = 6;
      this._tlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this._tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7F));
      this._tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this._tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
      this._tlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this._tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
      this._tlp.Size = new System.Drawing.Size(563, 348);
      this._tlp.TabIndex = 1;
      // 
      // _cmdOk
      // 
      this._cmdOk.Location = new System.Drawing.Point(244, 307);
      this._cmdOk.Name = "_cmdOk";
      this._cmdOk.Size = new System.Drawing.Size(75, 23);
      this._cmdOk.TabIndex = 0;
      this._cmdOk.Text = "Ok";
      this._cmdOk.UseVisualStyleBackColor = true;
      // 
      // _cboDataSet
      // 
      this._cboDataSet.Dock = System.Windows.Forms.DockStyle.Fill;
      this._cboDataSet.FormattingEnabled = true;
      this._cboDataSet.Location = new System.Drawing.Point(325, 3);
      this._cboDataSet.Name = "_cboDataSet";
      this._cboDataSet.Size = new System.Drawing.Size(235, 24);
      this._cboDataSet.TabIndex = 1;
      // 
      // _lblDateSet
      // 
      this._lblDateSet.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this._lblDateSet.AutoSize = true;
      this._lblDateSet.Location = new System.Drawing.Point(260, 6);
      this._lblDateSet.Name = "_lblDateSet";
      this._lblDateSet.Size = new System.Drawing.Size(59, 17);
      this._lblDateSet.TabIndex = 2;
      this._lblDateSet.Text = "DataSet";
      // 
      // _dgv
      // 
      this._dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this._tlp.SetColumnSpan(this._dgv, 3);
      this._dgv.Dock = System.Windows.Forms.DockStyle.Fill;
      this._dgv.Location = new System.Drawing.Point(3, 40);
      this._dgv.Name = "_dgv";
      this._dgv.RowTemplate.Height = 24;
      this._dgv.Size = new System.Drawing.Size(557, 246);
      this._dgv.TabIndex = 3;
      // 
      // frmResult
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(563, 348);
      this.Controls.Add(this._tlp);
      this.Name = "frmResult";
      this.Text = "frmResult";
      this._tlp.ResumeLayout(false);
      this._tlp.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this._dgv)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel _tlp;
    private System.Windows.Forms.Button _cmdOk;
    private System.Windows.Forms.ComboBox _cboDataSet;
    private System.Windows.Forms.Label _lblDateSet;
    private System.Windows.Forms.DataGridView _dgv;
  }
}