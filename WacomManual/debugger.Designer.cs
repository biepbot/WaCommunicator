namespace WaCommunicator
{
    partial class Debugger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Debugger));
            this.btn_restart_service = new System.Windows.Forms.Button();
            this.rTB_output = new System.Windows.Forms.RichTextBox();
            this.nUD_timeout = new System.Windows.Forms.NumericUpDown();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetDriverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimumTimeoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultTimeoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTimeoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultRestartUponTrayClickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartServiceUponUSBPlugInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startApplicationMinimisedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.lbl_timeout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_timeout)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_restart_service
            // 
            this.btn_restart_service.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restart_service.Location = new System.Drawing.Point(12, 12);
            this.btn_restart_service.Name = "btn_restart_service";
            this.btn_restart_service.Size = new System.Drawing.Size(164, 23);
            this.btn_restart_service.TabIndex = 1;
            this.btn_restart_service.Text = "Restart";
            this.btn_restart_service.UseVisualStyleBackColor = true;
            this.btn_restart_service.Click += new System.EventHandler(this.btn_restart_service_Click);
            // 
            // rTB_output
            // 
            this.rTB_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTB_output.BackColor = System.Drawing.SystemColors.MenuText;
            this.rTB_output.ForeColor = System.Drawing.Color.Lime;
            this.rTB_output.Location = new System.Drawing.Point(12, 42);
            this.rTB_output.Name = "rTB_output";
            this.rTB_output.ReadOnly = true;
            this.rTB_output.Size = new System.Drawing.Size(468, 215);
            this.rTB_output.TabIndex = 2;
            this.rTB_output.Text = "";
            // 
            // nUD_timeout
            // 
            this.nUD_timeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nUD_timeout.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nUD_timeout.Location = new System.Drawing.Point(384, 13);
            this.nUD_timeout.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nUD_timeout.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.nUD_timeout.Name = "nUD_timeout";
            this.nUD_timeout.Size = new System.Drawing.Size(96, 20);
            this.nUD_timeout.TabIndex = 3;
            this.nUD_timeout.Value = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.NotifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "WaCommunicator";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.Click += new System.EventHandler(this.NotifyIcon_Click);
            this.NotifyIcon.DoubleClick += new System.EventHandler(this.NotifyIcon_DoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreToolStripMenuItem,
            this.resetDriverToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.closeApplicationToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(136, 92);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.restoreToolStripMenuItem.Text = "See log";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // resetDriverToolStripMenuItem
            // 
            this.resetDriverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimumTimeoutToolStripMenuItem,
            this.defaultTimeoutToolStripMenuItem,
            this.sTimeoutToolStripMenuItem});
            this.resetDriverToolStripMenuItem.Name = "resetDriverToolStripMenuItem";
            this.resetDriverToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.resetDriverToolStripMenuItem.Text = "Reset driver";
            // 
            // minimumTimeoutToolStripMenuItem
            // 
            this.minimumTimeoutToolStripMenuItem.Name = "minimumTimeoutToolStripMenuItem";
            this.minimumTimeoutToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.minimumTimeoutToolStripMenuItem.Text = "1500ms timeout";
            this.minimumTimeoutToolStripMenuItem.Click += new System.EventHandler(this.RestartTray);
            // 
            // defaultTimeoutToolStripMenuItem
            // 
            this.defaultTimeoutToolStripMenuItem.Name = "defaultTimeoutToolStripMenuItem";
            this.defaultTimeoutToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.defaultTimeoutToolStripMenuItem.Text = "2500ms timeout";
            this.defaultTimeoutToolStripMenuItem.Click += new System.EventHandler(this.RestartTray);
            // 
            // sTimeoutToolStripMenuItem
            // 
            this.sTimeoutToolStripMenuItem.Name = "sTimeoutToolStripMenuItem";
            this.sTimeoutToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.sTimeoutToolStripMenuItem.Text = "5000ms timeout";
            this.sTimeoutToolStripMenuItem.Click += new System.EventHandler(this.RestartTray);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultRestartUponTrayClickToolStripMenuItem,
            this.restartServiceUponUSBPlugInToolStripMenuItem,
            this.startApplicationMinimisedToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // defaultRestartUponTrayClickToolStripMenuItem
            // 
            this.defaultRestartUponTrayClickToolStripMenuItem.Name = "defaultRestartUponTrayClickToolStripMenuItem";
            this.defaultRestartUponTrayClickToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.defaultRestartUponTrayClickToolStripMenuItem.Text = "Tray click restart";
            this.defaultRestartUponTrayClickToolStripMenuItem.Click += new System.EventHandler(this.IdentifySaver);
            // 
            // restartServiceUponUSBPlugInToolStripMenuItem
            // 
            this.restartServiceUponUSBPlugInToolStripMenuItem.Name = "restartServiceUponUSBPlugInToolStripMenuItem";
            this.restartServiceUponUSBPlugInToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.restartServiceUponUSBPlugInToolStripMenuItem.Text = "USB detection restart";
            this.restartServiceUponUSBPlugInToolStripMenuItem.Click += new System.EventHandler(this.IdentifySaver);
            // 
            // startApplicationMinimisedToolStripMenuItem
            // 
            this.startApplicationMinimisedToolStripMenuItem.Name = "startApplicationMinimisedToolStripMenuItem";
            this.startApplicationMinimisedToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.startApplicationMinimisedToolStripMenuItem.Text = "Start minimised";
            this.startApplicationMinimisedToolStripMenuItem.Click += new System.EventHandler(this.IdentifySaver);
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.closeApplicationToolStripMenuItem.Text = "Exit";
            this.closeApplicationToolStripMenuItem.Click += new System.EventHandler(this.closeApplicationToolStripMenuItem_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // lbl_timeout
            // 
            this.lbl_timeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_timeout.AutoSize = true;
            this.lbl_timeout.Location = new System.Drawing.Point(182, 17);
            this.lbl_timeout.Name = "lbl_timeout";
            this.lbl_timeout.Size = new System.Drawing.Size(196, 13);
            this.lbl_timeout.TabIndex = 4;
            this.lbl_timeout.Text = "Timeout (in milliseconds, 2500 is default)";
            // 
            // Debugger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 269);
            this.Controls.Add(this.lbl_timeout);
            this.Controls.Add(this.nUD_timeout);
            this.Controls.Add(this.rTB_output);
            this.Controls.Add(this.btn_restart_service);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(270, 200);
            this.Name = "Debugger";
            this.Text = "WaCommunicator";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.nUD_timeout)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_restart_service;
        private System.Windows.Forms.RichTextBox rTB_output;
        private System.Windows.Forms.NumericUpDown nUD_timeout;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetDriverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultTimeoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimumTimeoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTimeoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultRestartUponTrayClickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startApplicationMinimisedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartServiceUponUSBPlugInToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label lbl_timeout;

    }
}

