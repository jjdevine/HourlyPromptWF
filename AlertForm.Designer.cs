
namespace HourlyPromptWF
{
    partial class AlertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertForm));
            this.label1 = new System.Windows.Forms.Label();
            this.SystemTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.SystemTrayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pauseNotificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopHourlyLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopAndWriteLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopAndQuitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemTrayContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Remaining: 30 Minutes";
            // 
            // SystemTray
            // 
            this.SystemTray.ContextMenuStrip = this.SystemTrayContextMenu;
            this.SystemTray.Icon = ((System.Drawing.Icon)(resources.GetObject("SystemTray.Icon")));
            this.SystemTray.Text = "HourlyLog";
            this.SystemTray.Visible = true;
            // 
            // SystemTrayContextMenu
            // 
            this.SystemTrayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseNotificationsToolStripMenuItem,
            this.stopHourlyLogToolStripMenuItem});
            this.SystemTrayContextMenu.Name = "SystemTrayContextMenu";
            this.SystemTrayContextMenu.Size = new System.Drawing.Size(177, 48);
            // 
            // pauseNotificationsToolStripMenuItem
            // 
            this.pauseNotificationsToolStripMenuItem.Name = "pauseNotificationsToolStripMenuItem";
            this.pauseNotificationsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.pauseNotificationsToolStripMenuItem.Text = "Pause Notifications";
            this.pauseNotificationsToolStripMenuItem.Click += new System.EventHandler(this.pauseNotificationsToolStripMenuItem_Click);
            // 
            // stopHourlyLogToolStripMenuItem
            // 
            this.stopHourlyLogToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopAndWriteLogToolStripMenuItem,
            this.stopAndQuitToolStripMenuItem});
            this.stopHourlyLogToolStripMenuItem.Name = "stopHourlyLogToolStripMenuItem";
            this.stopHourlyLogToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.stopHourlyLogToolStripMenuItem.Text = "Stop Hourly Log";
            // 
            // stopAndWriteLogToolStripMenuItem
            // 
            this.stopAndWriteLogToolStripMenuItem.Name = "stopAndWriteLogToolStripMenuItem";
            this.stopAndWriteLogToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stopAndWriteLogToolStripMenuItem.Text = "Stop And Write Log";
            this.stopAndWriteLogToolStripMenuItem.Click += new System.EventHandler(this.stopAndWriteLogToolStripMenuItem_Click);
            // 
            // stopAndQuitToolStripMenuItem
            // 
            this.stopAndQuitToolStripMenuItem.Name = "stopAndQuitToolStripMenuItem";
            this.stopAndQuitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stopAndQuitToolStripMenuItem.Text = "Stop And Quit";
            this.stopAndQuitToolStripMenuItem.Click += new System.EventHandler(this.stopAndQuitToolStripMenuItem_Click);
            // 
            // AlertForm
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(504, 72);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Green;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlertForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.SystemTrayContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon SystemTray;
        private System.Windows.Forms.ContextMenuStrip SystemTrayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem pauseNotificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopHourlyLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopAndWriteLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopAndQuitToolStripMenuItem;
    }
}

