namespace FogBugzCaseTracker
{
    partial class HoverWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoverWindow));
            this.UpdateCasesTimer = new System.Windows.Forms.Timer(this.components);
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.MainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnNewCase = new System.Windows.Forms.ToolStripMenuItem();
            this.btnResolve = new System.Windows.Forms.ToolStripMenuItem();
            this.btnResolveClose = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewCase = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConfigure = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExportExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToFreeMindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromFreeMindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnShowHide = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentCaseTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.CaseDropDown = new System.Windows.Forms.ComboBox();
            this.lblWorkingOn = new System.Windows.Forms.Label();
            this.timerRetryLogin = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            this.busyPicture = new System.Windows.Forms.PictureBox();
            this.extensionGrip = new System.Windows.Forms.PictureBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.backgroundPic = new System.Windows.Forms.PictureBox();
            this.btnImages = new System.Windows.Forms.ImageList(this.components);
            this.pnlPaused = new System.Windows.Forms.Panel();
            this.lblImBack = new System.Windows.Forms.Label();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busyPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extensionGrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPic)).BeginInit();
            this.pnlPaused.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpdateCasesTimer
            // 
            this.UpdateCasesTimer.Enabled = true;
            this.UpdateCasesTimer.Interval = 600000;
            this.UpdateCasesTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trayIcon
            // 
            this.trayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.trayIcon.BalloonTipText = "Right-click: menu\r\nLeft-click: show/hide";
            this.trayIcon.BalloonTipTitle = "Case Tracker";
            this.trayIcon.ContextMenuStrip = this.MainMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "FogBugz";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseUp);
            this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewCase,
            this.btnResolve,
            this.btnResolveClose,
            this.btnViewCase,
            this.btnConfigure,
            this.menuExportExcel,
            this.exportToFreeMindToolStripMenuItem,
            this.importFromFreeMindToolStripMenuItem,
            this.toolStripSeparator1,
            this.btnShowHide,
            this.exitToolStripMenuItem});
            this.MainMenu.Name = "contextMenuStrip1";
            this.MainMenu.Size = new System.Drawing.Size(197, 230);
            this.MainMenu.Opened += new System.EventHandler(this.contextMenuStrip1_Opened);
            this.MainMenu.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.contextMenuStrip1_Closed);
            // 
            // btnNewCase
            // 
            this.btnNewCase.Image = global::FogBugzCaseTracker.Properties.Resources.new_case;
            this.btnNewCase.Name = "btnNewCase";
            this.btnNewCase.Size = new System.Drawing.Size(196, 22);
            this.btnNewCase.Text = "New Case";
            this.btnNewCase.Click += new System.EventHandler(this.btnNewCase_Click);
            // 
            // btnResolve
            // 
            this.btnResolve.Image = global::FogBugzCaseTracker.Properties.Resources.check_icon;
            this.btnResolve.Name = "btnResolve";
            this.btnResolve.Size = new System.Drawing.Size(196, 22);
            this.btnResolve.Text = "&Resolve this case";
            this.btnResolve.Click += new System.EventHandler(this.btnResolve_Click);
            // 
            // btnResolveClose
            // 
            this.btnResolveClose.Image = global::FogBugzCaseTracker.Properties.Resources.fat_check;
            this.btnResolveClose.Name = "btnResolveClose";
            this.btnResolveClose.Size = new System.Drawing.Size(196, 22);
            this.btnResolveClose.Text = "Resolve && &Close this case";
            this.btnResolveClose.Click += new System.EventHandler(this.btnResolveClose_Click);
            // 
            // btnViewCase
            // 
            this.btnViewCase.Image = global::FogBugzCaseTracker.Properties.Resources.firefox_16;
            this.btnViewCase.Name = "btnViewCase";
            this.btnViewCase.Size = new System.Drawing.Size(196, 22);
            this.btnViewCase.Text = "&View case in browser";
            this.btnViewCase.Click += new System.EventHandler(this.btnViewCase_Click);
            // 
            // btnConfigure
            // 
            this.btnConfigure.Image = global::FogBugzCaseTracker.Properties.Resources.key;
            this.btnConfigure.Name = "btnConfigure";
            this.btnConfigure.Size = new System.Drawing.Size(196, 22);
            this.btnConfigure.Text = "&Switch user";
            this.btnConfigure.Click += new System.EventHandler(this.btnConfigure_Click);
            // 
            // menuExportExcel
            // 
            this.menuExportExcel.Image = global::FogBugzCaseTracker.Properties.Resources.excel;
            this.menuExportExcel.Name = "menuExportExcel";
            this.menuExportExcel.Size = new System.Drawing.Size(196, 22);
            this.menuExportExcel.Text = "Export to Excel";
            this.menuExportExcel.Click += new System.EventHandler(this.menuExportExcel_Click);
            // 
            // exportToFreeMindToolStripMenuItem
            // 
            this.exportToFreeMindToolStripMenuItem.Image = global::FogBugzCaseTracker.Properties.Resources.freemind;
            this.exportToFreeMindToolStripMenuItem.Name = "exportToFreeMindToolStripMenuItem";
            this.exportToFreeMindToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exportToFreeMindToolStripMenuItem.Text = "Export to &FreeMind";
            this.exportToFreeMindToolStripMenuItem.Click += new System.EventHandler(this.exportToFreeMindToolStripMenuItem_Click);
            // 
            // importFromFreeMindToolStripMenuItem
            // 
            this.importFromFreeMindToolStripMenuItem.Image = global::FogBugzCaseTracker.Properties.Resources.freemind;
            this.importFromFreeMindToolStripMenuItem.Name = "importFromFreeMindToolStripMenuItem";
            this.importFromFreeMindToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.importFromFreeMindToolStripMenuItem.Text = "Import from FreeMind";
            this.importFromFreeMindToolStripMenuItem.Click += new System.EventHandler(this.importFromFreeMindToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // btnShowHide
            // 
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(196, 22);
            this.btnShowHide.Text = "&Hide";
            this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // CaseDropDown
            // 
            this.CaseDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CaseDropDown.DisplayMember = "LongDescription";
            this.CaseDropDown.DropDownHeight = 500;
            this.CaseDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CaseDropDown.DropDownWidth = 400;
            this.CaseDropDown.FormattingEnabled = true;
            this.CaseDropDown.IntegralHeight = false;
            this.CaseDropDown.Location = new System.Drawing.Point(62, 3);
            this.CaseDropDown.MaxDropDownItems = 100;
            this.CaseDropDown.Name = "CaseDropDown";
            this.CaseDropDown.Size = new System.Drawing.Size(343, 21);
            this.CaseDropDown.Sorted = true;
            this.CaseDropDown.TabIndex = 11;
            this.CaseDropDown.ValueMember = "id";
            this.CaseDropDown.SelectedIndexChanged += new System.EventHandler(this.listCases_SelectedIndexChanged);
            this.CaseDropDown.DropDownClosed += new System.EventHandler(this.listCases_DropDownClosed);
            this.CaseDropDown.DropDown += new System.EventHandler(this.listCases_DropDown);
            // 
            // lblWorkingOn
            // 
            this.lblWorkingOn.AutoSize = true;
            this.lblWorkingOn.Location = new System.Drawing.Point(25, 6);
            this.lblWorkingOn.Name = "lblWorkingOn";
            this.lblWorkingOn.Size = new System.Drawing.Size(38, 13);
            this.lblWorkingOn.TabIndex = 12;
            this.lblWorkingOn.Text = "I\'m on:";
            this.lblWorkingOn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.lblWorkingOn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.lblWorkingOn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // timerRetryLogin
            // 
            this.timerRetryLogin.Tick += new System.EventHandler(this.timerRetryLogin_Tick);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPause.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPause.BackgroundImage = global::FogBugzCaseTracker.Properties.Resources.pause;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Location = new System.Drawing.Point(411, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(22, 20);
            this.btnPause.TabIndex = 18;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // busyPicture
            // 
            this.busyPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.busyPicture.Image = global::FogBugzCaseTracker.Properties.Resources.busy;
            this.busyPicture.ImageLocation = "";
            this.busyPicture.Location = new System.Drawing.Point(3, 3);
            this.busyPicture.Name = "busyPicture";
            this.busyPicture.Size = new System.Drawing.Size(22, 20);
            this.busyPicture.TabIndex = 17;
            this.busyPicture.TabStop = false;
            this.busyPicture.Visible = false;
            // 
            // extensionGrip
            // 
            this.extensionGrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.extensionGrip.BackgroundImage = global::FogBugzCaseTracker.Properties.Resources.ellipsis_vertical;
            this.extensionGrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.extensionGrip.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.extensionGrip.Location = new System.Drawing.Point(491, 1);
            this.extensionGrip.Name = "extensionGrip";
            this.extensionGrip.Size = new System.Drawing.Size(8, 24);
            this.extensionGrip.TabIndex = 15;
            this.extensionGrip.TabStop = false;
            this.extensionGrip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.grip_MouseMove);
            this.extensionGrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grip_MouseDown);
            this.extensionGrip.MouseUp += new System.Windows.Forms.MouseEventHandler(this.grip_MouseUp);
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFilter.BackgroundImage = global::FogBugzCaseTracker.Properties.Resources.filter;
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Location = new System.Drawing.Point(437, 3);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(22, 20);
            this.btnFilter.TabIndex = 13;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click_1);
            // 
            // btnMain
            // 
            this.btnMain.BackgroundImage = global::FogBugzCaseTracker.Properties.Resources.icon;
            this.btnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMain.ContextMenuStrip = this.MainMenu;
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Location = new System.Drawing.Point(2, 3);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(22, 20);
            this.btnMain.TabIndex = 9;
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRefresh.BackgroundImage = global::FogBugzCaseTracker.Properties.Resources.refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(463, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(22, 20);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // backgroundPic
            // 
            this.backgroundPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backgroundPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPic.Location = new System.Drawing.Point(0, 0);
            this.backgroundPic.Name = "backgroundPic";
            this.backgroundPic.Size = new System.Drawing.Size(500, 26);
            this.backgroundPic.TabIndex = 16;
            this.backgroundPic.TabStop = false;
            this.backgroundPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.backgroundPic_MouseMove);
            this.backgroundPic.Click += new System.EventHandler(this.backgroundPic_Click);
            this.backgroundPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.backgroundPic_MouseDown);
            this.backgroundPic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.backgroundPic_MouseUp);
            // 
            // btnImages
            // 
            this.btnImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("btnImages.ImageStream")));
            this.btnImages.TransparentColor = System.Drawing.Color.Transparent;
            this.btnImages.Images.SetKeyName(0, "pause_enabled");
            this.btnImages.Images.SetKeyName(1, "pause_disabled");
            // 
            // pnlPaused
            // 
            this.pnlPaused.Controls.Add(this.lblImBack);
            this.pnlPaused.Location = new System.Drawing.Point(106, 6);
            this.pnlPaused.Name = "pnlPaused";
            this.pnlPaused.Size = new System.Drawing.Size(203, 17);
            this.pnlPaused.TabIndex = 19;
            this.pnlPaused.Visible = false;
            // 
            // lblImBack
            // 
            this.lblImBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblImBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImBack.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblImBack.Location = new System.Drawing.Point(3, 1);
            this.lblImBack.Name = "lblImBack";
            this.lblImBack.Size = new System.Drawing.Size(197, 16);
            this.lblImBack.TabIndex = 0;
            this.lblImBack.Text = "I\'m Back";
            this.lblImBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblImBack.Click += new System.EventHandler(this.lblImBack_Click);
            // 
            // HoverWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(500, 26);
            this.ControlBox = false;
            this.Controls.Add(this.pnlPaused);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.busyPicture);
            this.Controls.Add(this.extensionGrip);
            this.Controls.Add(this.CaseDropDown);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lblWorkingOn);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.backgroundPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2000, 26);
            this.MinimumSize = new System.Drawing.Size(224, 26);
            this.Name = "HoverWindow";
            this.Opacity = 0.8;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Case Tracker";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.HoverWindow_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HoverWindow_MouseUp);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HoverWindow_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HoverWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HoverWindow_MouseMove);
            this.MainMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.busyPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extensionGrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPic)).EndInit();
            this.pnlPaused.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer UpdateCasesTimer;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnConfigure;
        private System.Windows.Forms.ToolStripMenuItem btnResolve;
        private System.Windows.Forms.ToolTip CurrentCaseTooltip;
        private System.Windows.Forms.ToolStripMenuItem btnViewCase;
        private System.Windows.Forms.ToolStripMenuItem btnShowHide;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox CaseDropDown;
        private System.Windows.Forms.Label lblWorkingOn;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.PictureBox extensionGrip;
        private System.Windows.Forms.PictureBox backgroundPic;
        private System.Windows.Forms.ToolStripMenuItem btnResolveClose;
        private System.Windows.Forms.ToolStripMenuItem btnNewCase;
        private System.Windows.Forms.ToolStripMenuItem menuExportExcel;
        private System.Windows.Forms.Timer timerRetryLogin;
        private System.Windows.Forms.ToolStripMenuItem exportToFreeMindToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFromFreeMindToolStripMenuItem;
        private System.Windows.Forms.PictureBox busyPicture;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.ImageList btnImages;
        private System.Windows.Forms.Panel pnlPaused;
        private System.Windows.Forms.Label lblImBack;
    }
}