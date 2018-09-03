namespace SophiaTX_Wallet_Classic
{
    partial class MainFrm
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
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Witness Detail", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "ID",
            "3"}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "Owner",
            "phinx"}, -1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Created",
            "2018-7-25T12:37:51"}, -1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "url",
            "#"}, -1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "votes",
            "10017382216510"}, -1);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "total_missed",
            "1721"}, -1);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "last_confirmed",
            "1147229"}, -1);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mn_file = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_backup = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mn_create = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_options = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_encrypt = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_ChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.unlockWalletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infomationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lv_witness = new System.Windows.Forms.ListView();
            this.ch1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_balance = new System.Windows.Forms.Label();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.tp3 = new System.Windows.Forms.TabPage();
            this.tp4 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tp1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_file,
            this.mn_options,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 40);
            this.menuStrip1.Size = new System.Drawing.Size(1943, 77);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mn_file
            // 
            this.mn_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_backup,
            this.backupToolStripMenuItem1,
            this.toolStripSeparator1,
            this.mn_create,
            this.mn_exit});
            this.mn_file.Name = "mn_file";
            this.mn_file.Size = new System.Drawing.Size(65, 35);
            this.mn_file.Tag = "MENU_FILE";
            this.mn_file.Text = "&File";
            // 
            // mn_backup
            // 
            this.mn_backup.Name = "mn_backup";
            this.mn_backup.Size = new System.Drawing.Size(195, 38);
            this.mn_backup.Tag = "MENU_OPEN";
            this.mn_backup.Text = "&Open";
            // 
            // backupToolStripMenuItem1
            // 
            this.backupToolStripMenuItem1.Name = "backupToolStripMenuItem1";
            this.backupToolStripMenuItem1.Size = new System.Drawing.Size(195, 38);
            this.backupToolStripMenuItem1.Tag = "MENU_BACKUP";
            this.backupToolStripMenuItem1.Text = "&Backup";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // mn_create
            // 
            this.mn_create.Name = "mn_create";
            this.mn_create.Size = new System.Drawing.Size(195, 38);
            this.mn_create.Tag = "MENU_CREATE";
            this.mn_create.Text = "&Create";
            // 
            // mn_exit
            // 
            this.mn_exit.Name = "mn_exit";
            this.mn_exit.Size = new System.Drawing.Size(195, 38);
            this.mn_exit.Tag = "MENU_EXIT";
            this.mn_exit.Text = "E&xit";
            // 
            // mn_options
            // 
            this.mn_options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_encrypt,
            this.mn_ChangePassword,
            this.unlockWalletToolStripMenuItem,
            this.toolStripSeparator2,
            this.settingsToolStripMenuItem});
            this.mn_options.Name = "mn_options";
            this.mn_options.Size = new System.Drawing.Size(117, 35);
            this.mn_options.Tag = "MENU_OPTIONS";
            this.mn_options.Text = "&Options";
            // 
            // mn_encrypt
            // 
            this.mn_encrypt.Name = "mn_encrypt";
            this.mn_encrypt.Size = new System.Drawing.Size(315, 38);
            this.mn_encrypt.Tag = "MENU_ENCRYPT";
            this.mn_encrypt.Text = "&Encrypt Wallet";
            // 
            // mn_ChangePassword
            // 
            this.mn_ChangePassword.Name = "mn_ChangePassword";
            this.mn_ChangePassword.Size = new System.Drawing.Size(315, 38);
            this.mn_ChangePassword.Tag = "MENU_CHANGEPASS";
            this.mn_ChangePassword.Text = "&Change Password";
            // 
            // unlockWalletToolStripMenuItem
            // 
            this.unlockWalletToolStripMenuItem.Name = "unlockWalletToolStripMenuItem";
            this.unlockWalletToolStripMenuItem.Size = new System.Drawing.Size(315, 38);
            this.unlockWalletToolStripMenuItem.Tag = "MENU_UNLOCK_WALLET";
            this.unlockWalletToolStripMenuItem.Text = "&Unlock Wallet";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(312, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(315, 38);
            this.settingsToolStripMenuItem.Tag = "MENU_SETTINGS";
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infomationToolStripMenuItem,
            this.debugConsoleToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(87, 35);
            this.toolsToolStripMenuItem.Tag = "MENU_TOOLS";
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // infomationToolStripMenuItem
            // 
            this.infomationToolStripMenuItem.Name = "infomationToolStripMenuItem";
            this.infomationToolStripMenuItem.Size = new System.Drawing.Size(288, 38);
            this.infomationToolStripMenuItem.Tag = "MENU_INFOMATION";
            this.infomationToolStripMenuItem.Text = "&Infomation";
            // 
            // debugConsoleToolStripMenuItem
            // 
            this.debugConsoleToolStripMenuItem.Name = "debugConsoleToolStripMenuItem";
            this.debugConsoleToolStripMenuItem.Size = new System.Drawing.Size(288, 38);
            this.debugConsoleToolStripMenuItem.Tag = "MENU_DEBUG";
            this.debugConsoleToolStripMenuItem.Text = "&Debug Console";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionInfoToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(97, 35);
            this.aboutToolStripMenuItem.Tag = "MENU_ABOUT";
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // versionInfoToolStripMenuItem
            // 
            this.versionInfoToolStripMenuItem.Name = "versionInfoToolStripMenuItem";
            this.versionInfoToolStripMenuItem.Size = new System.Drawing.Size(250, 38);
            this.versionInfoToolStripMenuItem.Tag = "MENU_VERSION";
            this.versionInfoToolStripMenuItem.Text = "&Version Info";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp1);
            this.tabControl1.Controls.Add(this.tp2);
            this.tabControl1.Controls.Add(this.tp3);
            this.tabControl1.Controls.Add(this.tp4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 77);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(6, 20);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1943, 769);
            this.tabControl1.TabIndex = 1;
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.panel1);
            this.tp1.Location = new System.Drawing.Point(8, 71);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(1927, 690);
            this.tp1.TabIndex = 0;
            this.tp1.Tag = "TP_DASHBOARD";
            this.tp1.Text = "Dashboard        ";
            this.tp1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lv_witness);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lb_balance);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 684);
            this.panel1.TabIndex = 0;
            // 
            // lv_witness
            // 
            this.lv_witness.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_witness.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch1,
            this.ch2});
            this.lv_witness.FullRowSelect = true;
            this.lv_witness.GridLines = true;
            listViewGroup2.Header = "Witness Detail";
            listViewGroup2.Name = "lvg1";
            listViewGroup2.Tag = "LVG_WITNESS_DETAIL";
            this.lv_witness.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.lv_witness.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listViewItem8.Group = listViewGroup2;
            listViewItem9.Group = listViewGroup2;
            listViewItem10.Group = listViewGroup2;
            listViewItem11.Group = listViewGroup2;
            listViewItem12.Group = listViewGroup2;
            listViewItem13.Group = listViewGroup2;
            listViewItem14.Group = listViewGroup2;
            this.lv_witness.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14});
            this.lv_witness.LabelWrap = false;
            this.lv_witness.Location = new System.Drawing.Point(28, 407);
            this.lv_witness.Name = "lv_witness";
            this.lv_witness.Scrollable = false;
            this.lv_witness.Size = new System.Drawing.Size(601, 255);
            this.lv_witness.TabIndex = 7;
            this.lv_witness.UseCompatibleStateImageBehavior = false;
            this.lv_witness.View = System.Windows.Forms.View.Details;
            // 
            // ch1
            // 
            this.ch1.Text = "";
            this.ch1.Width = 180;
            // 
            // ch2
            // 
            this.ch2.Text = "";
            this.ch2.Width = 400;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(22, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(607, 87);
            this.label5.TabIndex = 6;
            this.label5.Tag = "LB_WITNESS";
            this.label5.Text = "Witness";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label3.Location = new System.Drawing.Point(154, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "0.00  SPHTX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 4;
            this.label4.Tag = "LB_VESTING";
            this.label4.Text = "Vesting:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(154, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "0.00  SPHTX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 2;
            this.label1.Tag = "LB_AMOUNT";
            this.label1.Text = "Amount:";
            // 
            // lb_balance
            // 
            this.lb_balance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lb_balance.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_balance.Location = new System.Drawing.Point(22, 25);
            this.lb_balance.Name = "lb_balance";
            this.lb_balance.Size = new System.Drawing.Size(607, 87);
            this.lb_balance.TabIndex = 1;
            this.lb_balance.Text = "Balance";
            this.lb_balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tp2
            // 
            this.tp2.Location = new System.Drawing.Point(8, 71);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(3);
            this.tp2.Size = new System.Drawing.Size(1927, 687);
            this.tp2.TabIndex = 1;
            this.tp2.Tag = "TP_SEND";
            this.tp2.Text = "Send        ";
            this.tp2.UseVisualStyleBackColor = true;
            // 
            // tp3
            // 
            this.tp3.Location = new System.Drawing.Point(8, 71);
            this.tp3.Name = "tp3";
            this.tp3.Padding = new System.Windows.Forms.Padding(3);
            this.tp3.Size = new System.Drawing.Size(1927, 687);
            this.tp3.TabIndex = 2;
            this.tp3.Tag = "TP_RECIEVE";
            this.tp3.Text = "Recieve        ";
            this.tp3.UseVisualStyleBackColor = true;
            // 
            // tp4
            // 
            this.tp4.Location = new System.Drawing.Point(8, 71);
            this.tp4.Name = "tp4";
            this.tp4.Padding = new System.Windows.Forms.Padding(3);
            this.tp4.Size = new System.Drawing.Size(1927, 687);
            this.tp4.TabIndex = 3;
            this.tp4.Tag = "TP_HISTORY";
            this.tp4.Text = "History        ";
            this.tp4.UseVisualStyleBackColor = true;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1943, 846);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.Tag = "MAIN_FORM_TITLE";
            this.Text = "SophiaTX Wallet Classic Edition";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mn_file;
        private System.Windows.Forms.ToolStripMenuItem mn_backup;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mn_create;
        private System.Windows.Forms.ToolStripMenuItem mn_exit;
        private System.Windows.Forms.ToolStripMenuItem mn_options;
        private System.Windows.Forms.ToolStripMenuItem mn_encrypt;
        private System.Windows.Forms.ToolStripMenuItem mn_ChangePassword;
        private System.Windows.Forms.ToolStripMenuItem unlockWalletToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infomationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugConsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionInfoToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.TabPage tp2;
        private System.Windows.Forms.TabPage tp3;
        private System.Windows.Forms.TabPage tp4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_balance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lv_witness;
        private System.Windows.Forms.ColumnHeader ch1;
        private System.Windows.Forms.ColumnHeader ch2;
    }
}

