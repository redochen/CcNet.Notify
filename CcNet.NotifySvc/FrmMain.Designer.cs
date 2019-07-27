namespace CcNet.NotifySvc
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            CcNet.Utils.Controls.CcAppearances ccAppearances7 = new CcNet.Utils.Controls.CcAppearances();
            CcNet.Utils.Controls.CcAppearance ccAppearance31 = new CcNet.Utils.Controls.CcAppearance();
            CcNet.Utils.Controls.CcAppearance ccAppearance32 = new CcNet.Utils.Controls.CcAppearance();
            CcNet.Utils.Controls.CcAppearance ccAppearance33 = new CcNet.Utils.Controls.CcAppearance();
            CcNet.Utils.Controls.CcAppearance ccAppearance34 = new CcNet.Utils.Controls.CcAppearance();
            CcNet.Utils.Controls.CcAppearance ccAppearance35 = new CcNet.Utils.Controls.CcAppearance();
            CcNet.Utils.Controls.CcBorder ccBorder7 = new CcNet.Utils.Controls.CcBorder();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlConsole = new System.Windows.Forms.Panel();
            this.txtConsole = new System.Windows.Forms.RichTextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnVisible = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOperate = new CcNet.Utils.Controls.CcButton();
            this.cbNotifiers = new System.Windows.Forms.ComboBox();
            this.lblNotifiers = new System.Windows.Forms.Label();
            this.cbProtocols = new System.Windows.Forms.ComboBox();
            this.lblProtocol = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnMin = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlConsole.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.pnlConsole);
            this.pnlMain.Controls.Add(this.pnlButtons);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(1);
            this.pnlMain.Size = new System.Drawing.Size(585, 502);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.pnlMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.pnlMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // pnlConsole
            // 
            this.pnlConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlConsole.Controls.Add(this.txtConsole);
            this.pnlConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConsole.Location = new System.Drawing.Point(1, 101);
            this.pnlConsole.Name = "pnlConsole";
            this.pnlConsole.Padding = new System.Windows.Forms.Padding(20, 5, 20, 20);
            this.pnlConsole.Size = new System.Drawing.Size(583, 400);
            this.pnlConsole.TabIndex = 1;
            this.pnlConsole.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.pnlConsole.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.pnlConsole.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsole.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.ForeColor = System.Drawing.Color.White;
            this.txtConsole.Location = new System.Drawing.Point(20, 5);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(543, 375);
            this.txtConsole.TabIndex = 0;
            this.txtConsole.Text = "";
            this.txtConsole.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.txtConsole.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.txtConsole.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlButtons.Controls.Add(this.btnMin);
            this.pnlButtons.Controls.Add(this.btnVisible);
            this.pnlButtons.Controls.Add(this.btnClose);
            this.pnlButtons.Controls.Add(this.btnOperate);
            this.pnlButtons.Controls.Add(this.cbNotifiers);
            this.pnlButtons.Controls.Add(this.lblNotifiers);
            this.pnlButtons.Controls.Add(this.cbProtocols);
            this.pnlButtons.Controls.Add(this.lblProtocol);
            this.pnlButtons.Controls.Add(this.txtPort);
            this.pnlButtons.Controls.Add(this.lblPort);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(1, 1);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(583, 100);
            this.pnlButtons.TabIndex = 0;
            this.pnlButtons.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.pnlButtons.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.pnlButtons.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // btnVisible
            // 
            this.btnVisible.BackColor = System.Drawing.Color.Transparent;
            this.btnVisible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisible.FlatAppearance.BorderSize = 0;
            this.btnVisible.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVisible.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVisible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisible.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisible.ForeColor = System.Drawing.Color.White;
            this.btnVisible.ImageIndex = 1;
            this.btnVisible.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVisible.Location = new System.Drawing.Point(546, 51);
            this.btnVisible.Name = "btnVisible";
            this.btnVisible.Size = new System.Drawing.Size(34, 29);
            this.btnVisible.TabIndex = 6;
            this.btnVisible.Text = "∧";
            this.btnVisible.UseVisualStyleBackColor = false;
            this.btnVisible.Click += new System.EventHandler(this.btnVisible_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(546, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOperate
            // 
            ccAppearance31.BackColorAngle = 0F;
            ccAppearance31.BackColorEnd = System.Drawing.Color.Red;
            ccAppearance31.BackColorStart = System.Drawing.Color.Red;
            ccAppearance31.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            ccAppearance31.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            ccAppearance31.ForeColor = System.Drawing.Color.White;
            ccAppearances7.Appearance = ccAppearance31;
            ccAppearance32.BackColorAngle = 0F;
            ccAppearance32.BackColorEnd = System.Drawing.Color.Empty;
            ccAppearance32.BackColorStart = System.Drawing.Color.Empty;
            ccAppearance32.BorderColor = System.Drawing.Color.Empty;
            ccAppearance32.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            ccAppearance32.ForeColor = System.Drawing.Color.Empty;
            ccAppearances7.DisabledAppearance = ccAppearance32;
            ccAppearance33.BackColorAngle = 0F;
            ccAppearance33.BackColorEnd = System.Drawing.Color.Empty;
            ccAppearance33.BackColorStart = System.Drawing.Color.Empty;
            ccAppearance33.BorderColor = System.Drawing.Color.Empty;
            ccAppearance33.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            ccAppearance33.ForeColor = System.Drawing.Color.Empty;
            ccAppearances7.FocusedAppearance = ccAppearance33;
            ccAppearance34.BackColorAngle = 0F;
            ccAppearance34.BackColorEnd = System.Drawing.Color.Empty;
            ccAppearance34.BackColorStart = System.Drawing.Color.Empty;
            ccAppearance34.BorderColor = System.Drawing.Color.Empty;
            ccAppearance34.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            ccAppearance34.ForeColor = System.Drawing.Color.Empty;
            ccAppearances7.HoveredAppearance = ccAppearance34;
            ccAppearance35.BackColorAngle = 0F;
            ccAppearance35.BackColorEnd = System.Drawing.Color.Empty;
            ccAppearance35.BackColorStart = System.Drawing.Color.Empty;
            ccAppearance35.BorderColor = System.Drawing.Color.Empty;
            ccAppearance35.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            ccAppearance35.ForeColor = System.Drawing.Color.Empty;
            ccAppearances7.PressedAppearance = ccAppearance35;
            this.btnOperate.Appearances = ccAppearances7;
            this.btnOperate.BackColor = System.Drawing.Color.Empty;
            ccBorder7.OpenDirection = CcNet.Utils.CcCtrlPosition.None;
            ccBorder7.Radius = 4;
            ccBorder7.RadiusCorners = CcNet.Utils.CcCtrlCorner.All;
            ccBorder7.Size = 0;
            this.btnOperate.Border = ccBorder7;
            this.btnOperate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOperate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperate.ImageHeight = 18;
            this.btnOperate.ImageTextPadding = 0;
            this.btnOperate.ImageWidth = 18;
            this.btnOperate.Location = new System.Drawing.Point(416, 13);
            this.btnOperate.Name = "btnOperate";
            this.btnOperate.Size = new System.Drawing.Size(102, 67);
            this.btnOperate.TabIndex = 3;
            this.btnOperate.Text = "启动";
            this.btnOperate.UseVisualStyleBackColor = false;
            this.btnOperate.Click += new System.EventHandler(this.btnOperate_Click);
            // 
            // cbNotifiers
            // 
            this.cbNotifiers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNotifiers.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbNotifiers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbNotifiers.FormattingEnabled = true;
            this.cbNotifiers.Location = new System.Drawing.Point(82, 53);
            this.cbNotifiers.Name = "cbNotifiers";
            this.cbNotifiers.Size = new System.Drawing.Size(314, 27);
            this.cbNotifiers.TabIndex = 2;
            // 
            // lblNotifiers
            // 
            this.lblNotifiers.AutoSize = true;
            this.lblNotifiers.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNotifiers.ForeColor = System.Drawing.Color.White;
            this.lblNotifiers.Location = new System.Drawing.Point(16, 57);
            this.lblNotifiers.Name = "lblNotifiers";
            this.lblNotifiers.Size = new System.Drawing.Size(61, 19);
            this.lblNotifiers.TabIndex = 100;
            this.lblNotifiers.Text = "通知类型";
            // 
            // cbProtocols
            // 
            this.cbProtocols.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProtocols.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbProtocols.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbProtocols.FormattingEnabled = true;
            this.cbProtocols.Location = new System.Drawing.Point(82, 13);
            this.cbProtocols.Name = "cbProtocols";
            this.cbProtocols.Size = new System.Drawing.Size(121, 27);
            this.cbProtocols.TabIndex = 0;
            // 
            // lblProtocol
            // 
            this.lblProtocol.AutoSize = true;
            this.lblProtocol.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblProtocol.ForeColor = System.Drawing.Color.White;
            this.lblProtocol.Location = new System.Drawing.Point(16, 17);
            this.lblProtocol.Name = "lblProtocol";
            this.lblProtocol.Size = new System.Drawing.Size(61, 19);
            this.lblProtocol.TabIndex = 100;
            this.lblProtocol.Text = "服务协议";
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPort.Location = new System.Drawing.Point(296, 14);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 25);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "1111";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPort.ForeColor = System.Drawing.Color.White;
            this.lblPort.Location = new System.Drawing.Point(232, 17);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(61, 19);
            this.lblPort.TabIndex = 100;
            this.lblPort.Text = "监控端口";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.ImageIndex = 1;
            this.btnMin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMin.Location = new System.Drawing.Point(520, 5);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(25, 29);
            this.btnMin.TabIndex = 4;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "监控任务通知服务";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(585, 502);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "监控通知服务控制台";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlConsole.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.ComboBox cbNotifiers;
        private System.Windows.Forms.Label lblNotifiers;
        private System.Windows.Forms.ComboBox cbProtocols;
        private System.Windows.Forms.Label lblProtocol;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private CcNet.Utils.Controls.CcButton btnOperate;
        private System.Windows.Forms.Panel pnlConsole;
        private System.Windows.Forms.RichTextBox txtConsole;
        private System.Windows.Forms.Button btnVisible;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

