namespace Spyhole
{
  partial class frmSpyhole
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSpyhole));
      this._tlp = new System.Windows.Forms.TableLayoutPanel();
      this._tbc = new System.Windows.Forms.TabControl();
      this._tbpParam = new System.Windows.Forms.TabPage();
      this._tlpParam = new System.Windows.Forms.TableLayoutPanel();
      this._lblSession = new System.Windows.Forms.Label();
      this._lblPauseSec = new System.Windows.Forms.Label();
      this._lblLogFile = new System.Windows.Forms.Label();
      this._nudPauseSec = new System.Windows.Forms.NumericUpDown();
      this._txtSession = new System.Windows.Forms.TextBox();
      this._txtLogFile = new System.Windows.Forms.TextBox();
      this._cmdBrowseSession = new System.Windows.Forms.Button();
      this._cmdBrowseLogFile = new System.Windows.Forms.Button();
      this._cmdSave2Reg = new System.Windows.Forms.Button();
      this._tbpTrace = new System.Windows.Forms.TabPage();
      this._pnl = new System.Windows.Forms.Panel();
      this._txtTrace = new System.Windows.Forms.TextBox();
      this._ts = new System.Windows.Forms.ToolStrip();
      this._tsbStart = new System.Windows.Forms.ToolStripButton();
      this._tsbStop = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this._tsbClear = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this._stlCount = new System.Windows.Forms.ToolStripLabel();
      this._txtCount = new System.Windows.Forms.ToolStripTextBox();
      this._cmdOk = new System.Windows.Forms.Button();
      this._tlp.SuspendLayout();
      this._tbc.SuspendLayout();
      this._tbpParam.SuspendLayout();
      this._tlpParam.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this._nudPauseSec)).BeginInit();
      this._tbpTrace.SuspendLayout();
      this._pnl.SuspendLayout();
      this._ts.SuspendLayout();
      this.SuspendLayout();
      // 
      // _tlp
      // 
      this._tlp.ColumnCount = 3;
      this._tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this._tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this._tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this._tlp.Controls.Add(this._tbc, 0, 1);
      this._tlp.Controls.Add(this._cmdOk, 1, 3);
      this._tlp.Dock = System.Windows.Forms.DockStyle.Fill;
      this._tlp.Location = new System.Drawing.Point(0, 0);
      this._tlp.Name = "_tlp";
      this._tlp.RowCount = 5;
      this._tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
      this._tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this._tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
      this._tlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this._tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
      this._tlp.Size = new System.Drawing.Size(558, 295);
      this._tlp.TabIndex = 0;
      // 
      // _tbc
      // 
      this._tlp.SetColumnSpan(this._tbc, 3);
      this._tbc.Controls.Add(this._tbpParam);
      this._tbc.Controls.Add(this._tbpTrace);
      this._tbc.Dock = System.Windows.Forms.DockStyle.Fill;
      this._tbc.Location = new System.Drawing.Point(3, 13);
      this._tbc.Name = "_tbc";
      this._tbc.SelectedIndex = 0;
      this._tbc.Size = new System.Drawing.Size(552, 226);
      this._tbc.TabIndex = 0;
      // 
      // _tbpParam
      // 
      this._tbpParam.Controls.Add(this._tlpParam);
      this._tbpParam.Location = new System.Drawing.Point(4, 25);
      this._tbpParam.Name = "_tbpParam";
      this._tbpParam.Padding = new System.Windows.Forms.Padding(3);
      this._tbpParam.Size = new System.Drawing.Size(544, 197);
      this._tbpParam.TabIndex = 0;
      this._tbpParam.Text = "Parameters";
      this._tbpParam.UseVisualStyleBackColor = true;
      // 
      // _tlpParam
      // 
      this._tlpParam.ColumnCount = 3;
      this._tlpParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
      this._tlpParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
      this._tlpParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this._tlpParam.Controls.Add(this._lblSession, 0, 0);
      this._tlpParam.Controls.Add(this._lblPauseSec, 0, 1);
      this._tlpParam.Controls.Add(this._lblLogFile, 0, 2);
      this._tlpParam.Controls.Add(this._nudPauseSec, 1, 1);
      this._tlpParam.Controls.Add(this._txtSession, 1, 0);
      this._tlpParam.Controls.Add(this._txtLogFile, 1, 2);
      this._tlpParam.Controls.Add(this._cmdBrowseSession, 2, 0);
      this._tlpParam.Controls.Add(this._cmdBrowseLogFile, 2, 2);
      this._tlpParam.Controls.Add(this._cmdSave2Reg, 1, 3);
      this._tlpParam.Dock = System.Windows.Forms.DockStyle.Fill;
      this._tlpParam.Location = new System.Drawing.Point(3, 3);
      this._tlpParam.Name = "_tlpParam";
      this._tlpParam.RowCount = 4;
      this._tlpParam.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this._tlpParam.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this._tlpParam.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this._tlpParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this._tlpParam.Size = new System.Drawing.Size(538, 191);
      this._tlpParam.TabIndex = 0;
      // 
      // _lblSession
      // 
      this._lblSession.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this._lblSession.AutoSize = true;
      this._lblSession.Location = new System.Drawing.Point(75, 8);
      this._lblSession.Name = "_lblSession";
      this._lblSession.Size = new System.Drawing.Size(72, 17);
      this._lblSession.TabIndex = 0;
      this._lblSession.Text = "lblSession";
      // 
      // _lblPauseSec
      // 
      this._lblPauseSec.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this._lblPauseSec.AutoSize = true;
      this._lblPauseSec.Location = new System.Drawing.Point(61, 38);
      this._lblPauseSec.Name = "_lblPauseSec";
      this._lblPauseSec.Size = new System.Drawing.Size(86, 17);
      this._lblPauseSec.TabIndex = 1;
      this._lblPauseSec.Text = "lblPauseSec";
      // 
      // _lblLogFile
      // 
      this._lblLogFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this._lblLogFile.AutoSize = true;
      this._lblLogFile.Location = new System.Drawing.Point(79, 69);
      this._lblLogFile.Name = "_lblLogFile";
      this._lblLogFile.Size = new System.Drawing.Size(68, 17);
      this._lblLogFile.TabIndex = 2;
      this._lblLogFile.Text = "lblLogFile";
      // 
      // _nudPauseSec
      // 
      this._nudPauseSec.Location = new System.Drawing.Point(153, 36);
      this._nudPauseSec.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
      this._nudPauseSec.Name = "_nudPauseSec";
      this._nudPauseSec.Size = new System.Drawing.Size(69, 22);
      this._nudPauseSec.TabIndex = 4;
      // 
      // _txtSession
      // 
      this._txtSession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this._txtSession.Location = new System.Drawing.Point(153, 5);
      this._txtSession.Name = "_txtSession";
      this._txtSession.Size = new System.Drawing.Size(344, 22);
      this._txtSession.TabIndex = 5;
      // 
      // _txtLogFile
      // 
      this._txtLogFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this._txtLogFile.Location = new System.Drawing.Point(153, 66);
      this._txtLogFile.Name = "_txtLogFile";
      this._txtLogFile.Size = new System.Drawing.Size(344, 22);
      this._txtLogFile.TabIndex = 6;
      // 
      // _cmdBrowseSession
      // 
      this._cmdBrowseSession.AutoSize = true;
      this._cmdBrowseSession.Location = new System.Drawing.Point(503, 3);
      this._cmdBrowseSession.Name = "_cmdBrowseSession";
      this._cmdBrowseSession.Size = new System.Drawing.Size(31, 27);
      this._cmdBrowseSession.TabIndex = 7;
      this._cmdBrowseSession.Text = "...";
      this._cmdBrowseSession.UseVisualStyleBackColor = true;
      this._cmdBrowseSession.Click += new System.EventHandler(this._cmdBrowseSession_Click);
      // 
      // _cmdBrowseLogFile
      // 
      this._cmdBrowseLogFile.AutoSize = true;
      this._cmdBrowseLogFile.Location = new System.Drawing.Point(503, 64);
      this._cmdBrowseLogFile.Name = "_cmdBrowseLogFile";
      this._cmdBrowseLogFile.Size = new System.Drawing.Size(31, 27);
      this._cmdBrowseLogFile.TabIndex = 8;
      this._cmdBrowseLogFile.Text = "...";
      this._cmdBrowseLogFile.UseVisualStyleBackColor = true;
      this._cmdBrowseLogFile.Click += new System.EventHandler(this._cmdBrowseLogFile_Click);
      // 
      // _cmdSave2Reg
      // 
      this._cmdSave2Reg.Anchor = System.Windows.Forms.AnchorStyles.None;
      this._cmdSave2Reg.AutoSize = true;
      this._cmdSave2Reg.Location = new System.Drawing.Point(269, 129);
      this._cmdSave2Reg.Name = "_cmdSave2Reg";
      this._cmdSave2Reg.Size = new System.Drawing.Size(111, 27);
      this._cmdSave2Reg.TabIndex = 9;
      this._cmdSave2Reg.Text = "Save2Register";
      this._cmdSave2Reg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this._cmdSave2Reg.UseVisualStyleBackColor = true;
      this._cmdSave2Reg.Click += new System.EventHandler(this._cmdSave2Reg_Click);
      // 
      // _tbpTrace
      // 
      this._tbpTrace.Controls.Add(this._pnl);
      this._tbpTrace.Controls.Add(this._ts);
      this._tbpTrace.Location = new System.Drawing.Point(4, 25);
      this._tbpTrace.Name = "_tbpTrace";
      this._tbpTrace.Padding = new System.Windows.Forms.Padding(3);
      this._tbpTrace.Size = new System.Drawing.Size(544, 197);
      this._tbpTrace.TabIndex = 1;
      this._tbpTrace.Text = "Trace";
      this._tbpTrace.UseVisualStyleBackColor = true;
      // 
      // _pnl
      // 
      this._pnl.Controls.Add(this._txtTrace);
      this._pnl.Dock = System.Windows.Forms.DockStyle.Fill;
      this._pnl.Location = new System.Drawing.Point(3, 30);
      this._pnl.Name = "_pnl";
      this._pnl.Size = new System.Drawing.Size(538, 164);
      this._pnl.TabIndex = 1;
      // 
      // _txtTrace
      // 
      this._txtTrace.Dock = System.Windows.Forms.DockStyle.Fill;
      this._txtTrace.Location = new System.Drawing.Point(0, 0);
      this._txtTrace.Multiline = true;
      this._txtTrace.Name = "_txtTrace";
      this._txtTrace.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this._txtTrace.Size = new System.Drawing.Size(538, 164);
      this._txtTrace.TabIndex = 2;
      // 
      // _ts
      // 
      this._ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsbStart,
            this._tsbStop,
            this.toolStripSeparator1,
            this._tsbClear,
            this.toolStripSeparator2,
            this._stlCount,
            this._txtCount});
      this._ts.Location = new System.Drawing.Point(3, 3);
      this._ts.Name = "_ts";
      this._ts.Size = new System.Drawing.Size(538, 27);
      this._ts.TabIndex = 1;
      this._ts.Text = "toolStrip1";
      // 
      // _tsbStart
      // 
      this._tsbStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this._tsbStart.Image = ((System.Drawing.Image)(resources.GetObject("_tsbStart.Image")));
      this._tsbStart.ImageTransparentColor = System.Drawing.Color.Magenta;
      this._tsbStart.Name = "_tsbStart";
      this._tsbStart.Size = new System.Drawing.Size(23, 24);
      this._tsbStart.Text = "toolStripButton1";
      this._tsbStart.Click += new System.EventHandler(this._tsbStart_Click);
      // 
      // _tsbStop
      // 
      this._tsbStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this._tsbStop.Image = ((System.Drawing.Image)(resources.GetObject("_tsbStop.Image")));
      this._tsbStop.ImageTransparentColor = System.Drawing.Color.Magenta;
      this._tsbStop.Name = "_tsbStop";
      this._tsbStop.Size = new System.Drawing.Size(23, 24);
      this._tsbStop.Text = "toolStripButton1";
      this._tsbStop.Click += new System.EventHandler(this._tsbStop_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
      // 
      // _tsbClear
      // 
      this._tsbClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this._tsbClear.Image = ((System.Drawing.Image)(resources.GetObject("_tsbClear.Image")));
      this._tsbClear.ImageTransparentColor = System.Drawing.Color.Magenta;
      this._tsbClear.Name = "_tsbClear";
      this._tsbClear.Size = new System.Drawing.Size(23, 24);
      this._tsbClear.Text = "toolStripButton2";
      this._tsbClear.Click += new System.EventHandler(this._tsbClear_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
      // 
      // _stlCount
      // 
      this._stlCount.Name = "_stlCount";
      this._stlCount.Size = new System.Drawing.Size(51, 24);
      this._stlCount.Text = "Count:";
      // 
      // _txtCount
      // 
      this._txtCount.Name = "_txtCount";
      this._txtCount.Size = new System.Drawing.Size(100, 27);
      // 
      // _cmdOk
      // 
      this._cmdOk.Anchor = System.Windows.Forms.AnchorStyles.None;
      this._cmdOk.AutoSize = true;
      this._cmdOk.Location = new System.Drawing.Point(241, 255);
      this._cmdOk.Name = "_cmdOk";
      this._cmdOk.Size = new System.Drawing.Size(75, 27);
      this._cmdOk.TabIndex = 1;
      this._cmdOk.Text = "Ok";
      this._cmdOk.UseVisualStyleBackColor = true;
      // 
      // frmSpyhole
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(558, 295);
      this.Controls.Add(this._tlp);
      this.Name = "frmSpyhole";
      this.Text = "frmSpyhole";
      this._tlp.ResumeLayout(false);
      this._tlp.PerformLayout();
      this._tbc.ResumeLayout(false);
      this._tbpParam.ResumeLayout(false);
      this._tlpParam.ResumeLayout(false);
      this._tlpParam.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this._nudPauseSec)).EndInit();
      this._tbpTrace.ResumeLayout(false);
      this._tbpTrace.PerformLayout();
      this._pnl.ResumeLayout(false);
      this._pnl.PerformLayout();
      this._ts.ResumeLayout(false);
      this._ts.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel _tlp;
    private System.Windows.Forms.TabControl _tbc;
    private System.Windows.Forms.TabPage _tbpParam;
    private System.Windows.Forms.TabPage _tbpTrace;
    private System.Windows.Forms.Button _cmdOk;
    private System.Windows.Forms.TableLayoutPanel _tlpParam;
    private System.Windows.Forms.Label _lblSession;
    private System.Windows.Forms.Label _lblPauseSec;
    private System.Windows.Forms.Label _lblLogFile;
    private System.Windows.Forms.NumericUpDown _nudPauseSec;
    private System.Windows.Forms.TextBox _txtSession;
    private System.Windows.Forms.TextBox _txtLogFile;
    private System.Windows.Forms.Button _cmdBrowseSession;
    private System.Windows.Forms.Button _cmdBrowseLogFile;
    private System.Windows.Forms.ToolStrip _ts;
    private System.Windows.Forms.ToolStripButton _tsbStart;
    private System.Windows.Forms.ToolStripButton _tsbStop;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton _tsbClear;
    private System.Windows.Forms.Panel _pnl;
    private System.Windows.Forms.TextBox _txtTrace;
    private System.Windows.Forms.Button _cmdSave2Reg;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripLabel _stlCount;
    private System.Windows.Forms.ToolStripTextBox _txtCount;

  }
}

