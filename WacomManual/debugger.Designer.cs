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
            this.rTB_output = new System.Windows.Forms.RichTextBox();
            this.nUD_timeout = new System.Windows.Forms.NumericUpDown();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CmRestoreScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.CmReset = new System.Windows.Forms.ToolStripMenuItem();
            this.minimumTimeoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultTimeoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTimeoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CmOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.CmTCROption = new System.Windows.Forms.ToolStripMenuItem();
            this.CmUSBROption = new System.Windows.Forms.ToolStripMenuItem();
            this.CmSMOption = new System.Windows.Forms.ToolStripMenuItem();
            this.CmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.lbl_timeout = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsRestartbutton = new System.Windows.Forms.ToolStripSplitButton();
            this.msTimeoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msTimeoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msTimeoutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tSOptions = new System.Windows.Forms.ToolStripDropDownButton();
            this.TsTCRoption = new System.Windows.Forms.ToolStripMenuItem();
            this.TsUSBDrestartOption = new System.Windows.Forms.ToolStripMenuItem();
            this.TsSMOption = new System.Windows.Forms.ToolStripMenuItem();
            this.TsExitButton = new System.Windows.Forms.ToolStripButton();
            this.TsLog = new System.Windows.Forms.ToolStripDropDownButton();
            this.TsSubLog = new System.Windows.Forms.ToolStripMenuItem();
            this.TsSaveLog = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.TsUndoLogClear = new System.Windows.Forms.ToolStripMenuItem();
            this.TsClearLog = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_timeout)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rTB_output
            // 
            this.rTB_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTB_output.BackColor = System.Drawing.SystemColors.MenuText;
            this.rTB_output.ForeColor = System.Drawing.Color.Lime;
            this.rTB_output.Location = new System.Drawing.Point(12, 28);
            this.rTB_output.Name = "rTB_output";
            this.rTB_output.ReadOnly = true;
            this.rTB_output.Size = new System.Drawing.Size(468, 229);
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
            this.nUD_timeout.Location = new System.Drawing.Point(395, 4);
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
            this.nUD_timeout.Size = new System.Drawing.Size(85, 20);
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
            this.CmRestoreScreen,
            this.CmReset,
            this.CmOptions,
            this.CmExit});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(136, 92);
            this.contextMenuStrip.Text = "Options";
            // 
            // CmRestoreScreen
            // 
            this.CmRestoreScreen.Name = "CmRestoreScreen";
            this.CmRestoreScreen.Size = new System.Drawing.Size(135, 22);
            this.CmRestoreScreen.Text = "See log";
            this.CmRestoreScreen.Click += new System.EventHandler(this.RestoreScreen_Click);
            // 
            // CmReset
            // 
            this.CmReset.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimumTimeoutToolStripMenuItem,
            this.defaultTimeoutToolStripMenuItem,
            this.sTimeoutToolStripMenuItem});
            this.CmReset.Name = "CmReset";
            this.CmReset.Size = new System.Drawing.Size(135, 22);
            this.CmReset.Text = "Reset driver";
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
            // CmOptions
            // 
            this.CmOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmTCROption,
            this.CmUSBROption,
            this.CmSMOption});
            this.CmOptions.Name = "CmOptions";
            this.CmOptions.Size = new System.Drawing.Size(135, 22);
            this.CmOptions.Text = "Options";
            // 
            // CmTCROption
            // 
            this.CmTCROption.Name = "CmTCROption";
            this.CmTCROption.Size = new System.Drawing.Size(184, 22);
            this.CmTCROption.Text = "Tray click restart";
            this.CmTCROption.Click += new System.EventHandler(this.IdentifySaver);
            // 
            // CmUSBROption
            // 
            this.CmUSBROption.Name = "CmUSBROption";
            this.CmUSBROption.Size = new System.Drawing.Size(184, 22);
            this.CmUSBROption.Text = "USB detection restart";
            this.CmUSBROption.Click += new System.EventHandler(this.IdentifySaver);
            // 
            // CmSMOption
            // 
            this.CmSMOption.Name = "CmSMOption";
            this.CmSMOption.Size = new System.Drawing.Size(184, 22);
            this.CmSMOption.Text = "Start minimised";
            this.CmSMOption.Click += new System.EventHandler(this.IdentifySaver);
            // 
            // CmExit
            // 
            this.CmExit.Name = "CmExit";
            this.CmExit.Size = new System.Drawing.Size(135, 22);
            this.CmExit.Text = "Exit";
            this.CmExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // lbl_timeout
            // 
            this.lbl_timeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_timeout.AutoSize = true;
            this.lbl_timeout.Location = new System.Drawing.Point(322, 6);
            this.lbl_timeout.Name = "lbl_timeout";
            this.lbl_timeout.Size = new System.Drawing.Size(67, 13);
            this.lbl_timeout.TabIndex = 4;
            this.lbl_timeout.Text = "Timeout (ms)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsRestartbutton,
            this.TsLog,
            this.tSOptions,
            this.TsExitButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(492, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip";
            // 
            // TsRestartbutton
            // 
            this.TsRestartbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsRestartbutton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msTimeoutToolStripMenuItem,
            this.msTimeoutToolStripMenuItem1,
            this.msTimeoutToolStripMenuItem2});
            this.TsRestartbutton.Image = ((System.Drawing.Image)(resources.GetObject("TsRestartbutton.Image")));
            this.TsRestartbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsRestartbutton.Name = "TsRestartbutton";
            this.TsRestartbutton.Size = new System.Drawing.Size(59, 22);
            this.TsRestartbutton.Text = "Restart";
            this.TsRestartbutton.ToolTipText = "Restart with the timeout defined";
            this.TsRestartbutton.ButtonClick += new System.EventHandler(this.btn_restart_service_Click);
            // 
            // msTimeoutToolStripMenuItem
            // 
            this.msTimeoutToolStripMenuItem.Name = "msTimeoutToolStripMenuItem";
            this.msTimeoutToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.msTimeoutToolStripMenuItem.Text = "1500ms timeout";
            this.msTimeoutToolStripMenuItem.Click += new System.EventHandler(this.RestartTray);
            // 
            // msTimeoutToolStripMenuItem1
            // 
            this.msTimeoutToolStripMenuItem1.Name = "msTimeoutToolStripMenuItem1";
            this.msTimeoutToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.msTimeoutToolStripMenuItem1.Text = "2500ms timeout";
            this.msTimeoutToolStripMenuItem1.Click += new System.EventHandler(this.RestartTray);
            // 
            // msTimeoutToolStripMenuItem2
            // 
            this.msTimeoutToolStripMenuItem2.Name = "msTimeoutToolStripMenuItem2";
            this.msTimeoutToolStripMenuItem2.Size = new System.Drawing.Size(159, 22);
            this.msTimeoutToolStripMenuItem2.Text = "5000ms timeout";
            this.msTimeoutToolStripMenuItem2.Click += new System.EventHandler(this.RestartTray);
            // 
            // tSOptions
            // 
            this.tSOptions.AutoToolTip = false;
            this.tSOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsTCRoption,
            this.TsUSBDrestartOption,
            this.TsSMOption});
            this.tSOptions.Image = ((System.Drawing.Image)(resources.GetObject("tSOptions.Image")));
            this.tSOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSOptions.Name = "tSOptions";
            this.tSOptions.Size = new System.Drawing.Size(62, 22);
            this.tSOptions.Text = "Options";
            // 
            // TsTCRoption
            // 
            this.TsTCRoption.Name = "TsTCRoption";
            this.TsTCRoption.Size = new System.Drawing.Size(184, 22);
            this.TsTCRoption.Text = "Tray click restart";
            // 
            // TsUSBDrestartOption
            // 
            this.TsUSBDrestartOption.Name = "TsUSBDrestartOption";
            this.TsUSBDrestartOption.Size = new System.Drawing.Size(184, 22);
            this.TsUSBDrestartOption.Text = "USB detection restart";
            // 
            // TsSMOption
            // 
            this.TsSMOption.Name = "TsSMOption";
            this.TsSMOption.Size = new System.Drawing.Size(184, 22);
            this.TsSMOption.Text = "Start minimised";
            // 
            // TsExitButton
            // 
            this.TsExitButton.AutoToolTip = false;
            this.TsExitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsExitButton.Image = ((System.Drawing.Image)(resources.GetObject("TsExitButton.Image")));
            this.TsExitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsExitButton.Name = "TsExitButton";
            this.TsExitButton.Size = new System.Drawing.Size(29, 22);
            this.TsExitButton.Text = "Exit";
            this.TsExitButton.Click += new System.EventHandler(this.Exit_Click);
            // 
            // TsLog
            // 
            this.TsLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsSubLog,
            this.TsSaveLog});
            this.TsLog.Image = ((System.Drawing.Image)(resources.GetObject("TsLog.Image")));
            this.TsLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsLog.Name = "TsLog";
            this.TsLog.Size = new System.Drawing.Size(40, 22);
            this.TsLog.Text = "Log";
            // 
            // TsSubLog
            // 
            this.TsSubLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsClearLog,
            this.TsUndoLogClear});
            this.TsSubLog.Name = "TsSubLog";
            this.TsSubLog.Size = new System.Drawing.Size(152, 22);
            this.TsSubLog.Text = "Manage";
            // 
            // TsSaveLog
            // 
            this.TsSaveLog.Name = "TsSaveLog";
            this.TsSaveLog.Size = new System.Drawing.Size(152, 22);
            this.TsSaveLog.Text = "Save to file";
            this.TsSaveLog.Click += new System.EventHandler(this.TsSaveLog_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "Text file |*.txt";
            this.saveFileDialog.Title = "Save debug log";
            // 
            // TsUndoLogClear
            // 
            this.TsUndoLogClear.Name = "TsUndoLogClear";
            this.TsUndoLogClear.Size = new System.Drawing.Size(152, 22);
            this.TsUndoLogClear.Text = "Undo clear";
            this.TsUndoLogClear.Click += new System.EventHandler(this.TsUndoLastLogClear_Click);
            // 
            // TsClearLog
            // 
            this.TsClearLog.Name = "TsClearLog";
            this.TsClearLog.Size = new System.Drawing.Size(152, 22);
            this.TsClearLog.Text = "Clear";
            this.TsClearLog.Click += new System.EventHandler(this.TsClearLog_Click);
            // 
            // Debugger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 269);
            this.Controls.Add(this.lbl_timeout);
            this.Controls.Add(this.nUD_timeout);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.rTB_output);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(270, 200);
            this.Name = "Debugger";
            this.Text = "WaCommunicator";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.nUD_timeout)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTB_output;
        private System.Windows.Forms.NumericUpDown nUD_timeout;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CmRestoreScreen;
        private System.Windows.Forms.ToolStripMenuItem CmReset;
        private System.Windows.Forms.ToolStripMenuItem CmExit;
        private System.Windows.Forms.ToolStripMenuItem defaultTimeoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimumTimeoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTimeoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CmOptions;
        private System.Windows.Forms.ToolStripMenuItem CmTCROption;
        private System.Windows.Forms.ToolStripMenuItem CmSMOption;
        private System.Windows.Forms.ToolStripMenuItem CmUSBROption;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label lbl_timeout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tSOptions;
        private System.Windows.Forms.ToolStripMenuItem TsTCRoption;
        private System.Windows.Forms.ToolStripMenuItem TsUSBDrestartOption;
        private System.Windows.Forms.ToolStripMenuItem TsSMOption;
        private System.Windows.Forms.ToolStripSplitButton TsRestartbutton;
        private System.Windows.Forms.ToolStripMenuItem msTimeoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msTimeoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem msTimeoutToolStripMenuItem2;
        private System.Windows.Forms.ToolStripButton TsExitButton;
        private System.Windows.Forms.ToolStripDropDownButton TsLog;
        private System.Windows.Forms.ToolStripMenuItem TsSubLog;
        private System.Windows.Forms.ToolStripMenuItem TsSaveLog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem TsUndoLogClear;
        private System.Windows.Forms.ToolStripMenuItem TsClearLog;

    }
}

