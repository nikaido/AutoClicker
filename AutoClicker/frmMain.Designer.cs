namespace AutoClicker
{
    partial class frmMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
      this.components = new System.ComponentModel.Container();
      this.timer = new System.Windows.Forms.Timer(this.components);
      this.status = new System.Windows.Forms.StatusStrip();
      this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.statusTime = new System.Windows.Forms.ToolStripStatusLabel();
      this.pnlBody = new System.Windows.Forms.Panel();
      this.pnlIntervalAndPosition = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.lblPositionRight = new System.Windows.Forms.Label();
      this.numPosY = new System.Windows.Forms.NumericUpDown();
      this.lblPositionCenter = new System.Windows.Forms.Label();
      this.numPosX = new System.Windows.Forms.NumericUpDown();
      this.lblPosition = new System.Windows.Forms.Label();
      this.pnlInterval = new System.Windows.Forms.Panel();
      this.lblIntervalSecond = new System.Windows.Forms.Label();
      this.numInterval = new System.Windows.Forms.NumericUpDown();
      this.lblInterval = new System.Windows.Forms.Label();
      this.chkEnabled = new System.Windows.Forms.CheckBox();
      this.status.SuspendLayout();
      this.pnlBody.SuspendLayout();
      this.pnlIntervalAndPosition.SuspendLayout();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numPosY)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numPosX)).BeginInit();
      this.pnlInterval.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
      this.SuspendLayout();
      // 
      // timer
      // 
      this.timer.Enabled = true;
      this.timer.Tick += new System.EventHandler(this.timer_Tick);
      // 
      // status
      // 
      this.status.GripMargin = new System.Windows.Forms.Padding(0);
      this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.statusTime});
      this.status.Location = new System.Drawing.Point(0, 105);
      this.status.Name = "status";
      this.status.Size = new System.Drawing.Size(234, 27);
      this.status.SizingGrip = false;
      this.status.TabIndex = 0;
      this.status.Text = "status";
      // 
      // statusLabel
      // 
      this.statusLabel.Name = "statusLabel";
      this.statusLabel.Size = new System.Drawing.Size(149, 22);
      this.statusLabel.Spring = true;
      // 
      // statusTime
      // 
      this.statusTime.AutoSize = false;
      this.statusTime.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
      this.statusTime.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
      this.statusTime.Name = "statusTime";
      this.statusTime.Size = new System.Drawing.Size(70, 22);
      this.statusTime.Text = "00:00:00";
      // 
      // pnlBody
      // 
      this.pnlBody.Controls.Add(this.pnlIntervalAndPosition);
      this.pnlBody.Controls.Add(this.chkEnabled);
      this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlBody.Location = new System.Drawing.Point(0, 0);
      this.pnlBody.Name = "pnlBody";
      this.pnlBody.Padding = new System.Windows.Forms.Padding(10);
      this.pnlBody.Size = new System.Drawing.Size(234, 105);
      this.pnlBody.TabIndex = 1;
      // 
      // pnlIntervalAndPosition
      // 
      this.pnlIntervalAndPosition.Controls.Add(this.panel2);
      this.pnlIntervalAndPosition.Controls.Add(this.pnlInterval);
      this.pnlIntervalAndPosition.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlIntervalAndPosition.Location = new System.Drawing.Point(10, 10);
      this.pnlIntervalAndPosition.Name = "pnlIntervalAndPosition";
      this.pnlIntervalAndPosition.Size = new System.Drawing.Size(214, 60);
      this.pnlIntervalAndPosition.TabIndex = 1;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.lblPositionRight);
      this.panel2.Controls.Add(this.numPosY);
      this.panel2.Controls.Add(this.lblPositionCenter);
      this.panel2.Controls.Add(this.numPosX);
      this.panel2.Controls.Add(this.lblPosition);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel2.Location = new System.Drawing.Point(0, 30);
      this.panel2.Name = "panel2";
      this.panel2.Padding = new System.Windows.Forms.Padding(5);
      this.panel2.Size = new System.Drawing.Size(214, 30);
      this.panel2.TabIndex = 1;
      // 
      // lblPositionRight
      // 
      this.lblPositionRight.AutoSize = true;
      this.lblPositionRight.Dock = System.Windows.Forms.DockStyle.Left;
      this.lblPositionRight.Location = new System.Drawing.Point(190, 5);
      this.lblPositionRight.Name = "lblPositionRight";
      this.lblPositionRight.Size = new System.Drawing.Size(9, 12);
      this.lblPositionRight.TabIndex = 5;
      this.lblPositionRight.Text = ")";
      // 
      // numPosY
      // 
      this.numPosY.Dock = System.Windows.Forms.DockStyle.Left;
      this.numPosY.Location = new System.Drawing.Point(133, 5);
      this.numPosY.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
      this.numPosY.Minimum = new decimal(new int[] {
            1920,
            0,
            0,
            -2147483648});
      this.numPosY.Name = "numPosY";
      this.numPosY.Size = new System.Drawing.Size(57, 19);
      this.numPosY.TabIndex = 4;
      this.numPosY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // lblPositionCenter
      // 
      this.lblPositionCenter.AutoSize = true;
      this.lblPositionCenter.Dock = System.Windows.Forms.DockStyle.Left;
      this.lblPositionCenter.Location = new System.Drawing.Point(122, 5);
      this.lblPositionCenter.Name = "lblPositionCenter";
      this.lblPositionCenter.Size = new System.Drawing.Size(11, 12);
      this.lblPositionCenter.TabIndex = 3;
      this.lblPositionCenter.Text = ", ";
      // 
      // numPosX
      // 
      this.numPosX.Dock = System.Windows.Forms.DockStyle.Left;
      this.numPosX.Location = new System.Drawing.Point(65, 5);
      this.numPosX.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
      this.numPosX.Minimum = new decimal(new int[] {
            1920,
            0,
            0,
            -2147483648});
      this.numPosX.Name = "numPosX";
      this.numPosX.Size = new System.Drawing.Size(57, 19);
      this.numPosX.TabIndex = 2;
      this.numPosX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // lblPosition
      // 
      this.lblPosition.AutoSize = true;
      this.lblPosition.Dock = System.Windows.Forms.DockStyle.Left;
      this.lblPosition.Location = new System.Drawing.Point(5, 5);
      this.lblPosition.Name = "lblPosition";
      this.lblPosition.Size = new System.Drawing.Size(60, 12);
      this.lblPosition.TabIndex = 1;
      this.lblPosition.Text = "Position : (";
      // 
      // pnlInterval
      // 
      this.pnlInterval.Controls.Add(this.lblIntervalSecond);
      this.pnlInterval.Controls.Add(this.numInterval);
      this.pnlInterval.Controls.Add(this.lblInterval);
      this.pnlInterval.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlInterval.Location = new System.Drawing.Point(0, 0);
      this.pnlInterval.Name = "pnlInterval";
      this.pnlInterval.Padding = new System.Windows.Forms.Padding(5);
      this.pnlInterval.Size = new System.Drawing.Size(214, 30);
      this.pnlInterval.TabIndex = 0;
      // 
      // lblIntervalSecond
      // 
      this.lblIntervalSecond.AutoSize = true;
      this.lblIntervalSecond.Dock = System.Windows.Forms.DockStyle.Left;
      this.lblIntervalSecond.Location = new System.Drawing.Point(148, 5);
      this.lblIntervalSecond.Name = "lblIntervalSecond";
      this.lblIntervalSecond.Size = new System.Drawing.Size(45, 12);
      this.lblIntervalSecond.TabIndex = 2;
      this.lblIntervalSecond.Text = " second";
      // 
      // numInterval
      // 
      this.numInterval.Dock = System.Windows.Forms.DockStyle.Left;
      this.numInterval.Location = new System.Drawing.Point(91, 5);
      this.numInterval.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
      this.numInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numInterval.Name = "numInterval";
      this.numInterval.Size = new System.Drawing.Size(57, 19);
      this.numInterval.TabIndex = 1;
      this.numInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.numInterval.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
      // 
      // lblInterval
      // 
      this.lblInterval.AutoSize = true;
      this.lblInterval.Dock = System.Windows.Forms.DockStyle.Left;
      this.lblInterval.Location = new System.Drawing.Point(5, 5);
      this.lblInterval.Name = "lblInterval";
      this.lblInterval.Size = new System.Drawing.Size(86, 12);
      this.lblInterval.TabIndex = 0;
      this.lblInterval.Text = "Interval : Every ";
      // 
      // chkEnabled
      // 
      this.chkEnabled.AutoSize = true;
      this.chkEnabled.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.chkEnabled.Location = new System.Drawing.Point(10, 69);
      this.chkEnabled.Name = "chkEnabled";
      this.chkEnabled.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
      this.chkEnabled.Size = new System.Drawing.Size(214, 26);
      this.chkEnabled.TabIndex = 0;
      this.chkEnabled.Text = "Enabled";
      this.chkEnabled.UseVisualStyleBackColor = true;
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(234, 132);
      this.Controls.Add(this.pnlBody);
      this.Controls.Add(this.status);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmMain";
      this.Load += new System.EventHandler(this.frmMain_Load);
      this.status.ResumeLayout(false);
      this.status.PerformLayout();
      this.pnlBody.ResumeLayout(false);
      this.pnlBody.PerformLayout();
      this.pnlIntervalAndPosition.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numPosY)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numPosX)).EndInit();
      this.pnlInterval.ResumeLayout(false);
      this.pnlInterval.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel statusTime;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.CheckBox chkEnabled;
        private System.Windows.Forms.Panel pnlIntervalAndPosition;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlInterval;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Label lblIntervalSecond;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.Label lblPositionRight;
        private System.Windows.Forms.NumericUpDown numPosY;
        private System.Windows.Forms.Label lblPositionCenter;
        private System.Windows.Forms.NumericUpDown numPosX;
        private System.Windows.Forms.Label lblPosition;
    }
}

