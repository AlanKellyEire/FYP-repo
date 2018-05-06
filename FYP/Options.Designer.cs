namespace FYP_10_2_18
{
    partial class Options
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.monitorTab = new System.Windows.Forms.TabPage();
            this.pingIntNumField = new System.Windows.Forms.NumericUpDown();
            this.pingIntLabel = new System.Windows.Forms.Label();
            this.alertsTab = new System.Windows.Forms.TabPage();
            this.testEmailButton = new System.Windows.Forms.Button();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.tlsSslCombobox = new System.Windows.Forms.ComboBox();
            this.smtpPortNumeric = new System.Windows.Forms.NumericUpDown();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.tlsSslLabel = new System.Windows.Forms.Label();
            this.smtpLabel = new System.Windows.Forms.Label();
            this.mailServerTextbox = new System.Windows.Forms.TextBox();
            this.mailServerLB = new System.Windows.Forms.Label();
            this.subjectTextbox = new System.Windows.Forms.TextBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.emailTab = new System.Windows.Forms.TabPage();
            this.emailEnableCheck = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailRepTextbox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailRepTextbox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emailRepTextbox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailRepTextbox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailRepTextbox1 = new System.Windows.Forms.TextBox();
            this.emailRepLB1 = new System.Windows.Forms.Label();
            this.loggerTab = new System.Windows.Forms.TabPage();
            this.loggerEnableCheck = new System.Windows.Forms.CheckBox();
            this.errorsLogTypeRB = new System.Windows.Forms.RadioButton();
            this.allLogTypeRB = new System.Windows.Forms.RadioButton();
            this.logTypeLabel = new System.Windows.Forms.Label();
            this.logFileNameTextbox = new System.Windows.Forms.TextBox();
            this.logFileNameLabel = new System.Windows.Forms.Label();
            this.logPathTextbox = new System.Windows.Forms.TextBox();
            this.logPathLabel = new System.Windows.Forms.Label();
            this.loggerEnLabel = new System.Windows.Forms.Label();
            this.thresholdTab = new System.Windows.Forms.TabPage();
            this.cancelBut = new System.Windows.Forms.Button();
            this.saveBut = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1.SuspendLayout();
            this.monitorTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pingIntNumField)).BeginInit();
            this.alertsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smtpPortNumeric)).BeginInit();
            this.emailTab.SuspendLayout();
            this.loggerTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.monitorTab);
            this.tabControl1.Controls.Add(this.alertsTab);
            this.tabControl1.Controls.Add(this.emailTab);
            this.tabControl1.Controls.Add(this.loggerTab);
            this.tabControl1.Controls.Add(this.thresholdTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 379);
            this.tabControl1.TabIndex = 0;
            // 
            // monitorTab
            // 
            this.monitorTab.Controls.Add(this.pingIntNumField);
            this.monitorTab.Controls.Add(this.pingIntLabel);
            this.monitorTab.Location = new System.Drawing.Point(4, 22);
            this.monitorTab.Name = "monitorTab";
            this.monitorTab.Size = new System.Drawing.Size(790, 353);
            this.monitorTab.TabIndex = 4;
            this.monitorTab.Text = "Monitoring";
            this.monitorTab.UseVisualStyleBackColor = true;
            // 
            // pingIntNumField
            // 
            this.pingIntNumField.Location = new System.Drawing.Point(343, 77);
            this.pingIntNumField.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.pingIntNumField.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.pingIntNumField.Name = "pingIntNumField";
            this.pingIntNumField.Size = new System.Drawing.Size(120, 20);
            this.pingIntNumField.TabIndex = 1;
            this.pingIntNumField.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.pingIntNumField.ValueChanged += new System.EventHandler(this.pingIntNumField_ValueChanged);
            // 
            // pingIntLabel
            // 
            this.pingIntLabel.AutoSize = true;
            this.pingIntLabel.Location = new System.Drawing.Point(243, 84);
            this.pingIntLabel.Name = "pingIntLabel";
            this.pingIntLabel.Size = new System.Drawing.Size(66, 13);
            this.pingIntLabel.TabIndex = 0;
            this.pingIntLabel.Text = "Ping Interval";
            // 
            // alertsTab
            // 
            this.alertsTab.Controls.Add(this.testEmailButton);
            this.alertsTab.Controls.Add(this.passwordTextbox);
            this.alertsTab.Controls.Add(this.passwordLabel);
            this.alertsTab.Controls.Add(this.tlsSslCombobox);
            this.alertsTab.Controls.Add(this.smtpPortNumeric);
            this.alertsTab.Controls.Add(this.usernameTextbox);
            this.alertsTab.Controls.Add(this.usernameLabel);
            this.alertsTab.Controls.Add(this.tlsSslLabel);
            this.alertsTab.Controls.Add(this.smtpLabel);
            this.alertsTab.Controls.Add(this.mailServerTextbox);
            this.alertsTab.Controls.Add(this.mailServerLB);
            this.alertsTab.Controls.Add(this.subjectTextbox);
            this.alertsTab.Controls.Add(this.subjectLabel);
            this.alertsTab.Location = new System.Drawing.Point(4, 22);
            this.alertsTab.Name = "alertsTab";
            this.alertsTab.Padding = new System.Windows.Forms.Padding(3);
            this.alertsTab.Size = new System.Drawing.Size(790, 353);
            this.alertsTab.TabIndex = 1;
            this.alertsTab.Text = "Alerts";
            this.alertsTab.UseVisualStyleBackColor = true;
            // 
            // testEmailButton
            // 
            this.testEmailButton.Location = new System.Drawing.Point(206, 279);
            this.testEmailButton.Name = "testEmailButton";
            this.testEmailButton.Size = new System.Drawing.Size(212, 23);
            this.testEmailButton.TabIndex = 33;
            this.testEmailButton.Text = "Send Test Email";
            this.testEmailButton.UseVisualStyleBackColor = true;
            this.testEmailButton.Click += new System.EventHandler(this.testEmailButton_Click);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(318, 235);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextbox.TabIndex = 32;
            this.passwordTextbox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(203, 242);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 31;
            this.passwordLabel.Text = "Password";
            // 
            // tlsSslCombobox
            // 
            this.tlsSslCombobox.DisplayMember = "TLS";
            this.tlsSslCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tlsSslCombobox.FormattingEnabled = true;
            this.tlsSslCombobox.Items.AddRange(new object[] {
            "TLS",
            "SSL"});
            this.tlsSslCombobox.Location = new System.Drawing.Point(318, 149);
            this.tlsSslCombobox.Name = "tlsSslCombobox";
            this.tlsSslCombobox.Size = new System.Drawing.Size(100, 21);
            this.tlsSslCombobox.TabIndex = 30;
            // 
            // smtpPortNumeric
            // 
            this.smtpPortNumeric.Location = new System.Drawing.Point(318, 111);
            this.smtpPortNumeric.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.smtpPortNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.smtpPortNumeric.Name = "smtpPortNumeric";
            this.smtpPortNumeric.Size = new System.Drawing.Size(100, 20);
            this.smtpPortNumeric.TabIndex = 28;
            this.smtpPortNumeric.ThousandsSeparator = true;
            this.smtpPortNumeric.Value = new decimal(new int[] {
            465,
            0,
            0,
            0});
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(318, 191);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextbox.TabIndex = 27;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(203, 198);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 26;
            this.usernameLabel.Text = "Username";
            // 
            // tlsSslLabel
            // 
            this.tlsSslLabel.AutoSize = true;
            this.tlsSslLabel.Location = new System.Drawing.Point(203, 157);
            this.tlsSslLabel.Name = "tlsSslLabel";
            this.tlsSslLabel.Size = new System.Drawing.Size(52, 13);
            this.tlsSslLabel.TabIndex = 24;
            this.tlsSslLabel.Text = "TLS/SSL";
            // 
            // smtpLabel
            // 
            this.smtpLabel.AutoSize = true;
            this.smtpLabel.Location = new System.Drawing.Point(203, 118);
            this.smtpLabel.Name = "smtpLabel";
            this.smtpLabel.Size = new System.Drawing.Size(37, 13);
            this.smtpLabel.TabIndex = 22;
            this.smtpLabel.Text = "SMTP";
            // 
            // mailServerTextbox
            // 
            this.mailServerTextbox.Location = new System.Drawing.Point(318, 73);
            this.mailServerTextbox.Name = "mailServerTextbox";
            this.mailServerTextbox.Size = new System.Drawing.Size(100, 20);
            this.mailServerTextbox.TabIndex = 21;
            // 
            // mailServerLB
            // 
            this.mailServerLB.AutoSize = true;
            this.mailServerLB.Location = new System.Drawing.Point(203, 80);
            this.mailServerLB.Name = "mailServerLB";
            this.mailServerLB.Size = new System.Drawing.Size(106, 13);
            this.mailServerLB.TabIndex = 20;
            this.mailServerLB.Text = "Outgoing Mail Server";
            // 
            // subjectTextbox
            // 
            this.subjectTextbox.Location = new System.Drawing.Point(318, 34);
            this.subjectTextbox.Name = "subjectTextbox";
            this.subjectTextbox.Size = new System.Drawing.Size(100, 20);
            this.subjectTextbox.TabIndex = 19;
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(203, 41);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(43, 13);
            this.subjectLabel.TabIndex = 18;
            this.subjectLabel.Text = "Subject";
            // 
            // emailTab
            // 
            this.emailTab.Controls.Add(this.emailEnableCheck);
            this.emailTab.Controls.Add(this.label5);
            this.emailTab.Controls.Add(this.emailRepTextbox5);
            this.emailTab.Controls.Add(this.label4);
            this.emailTab.Controls.Add(this.emailRepTextbox4);
            this.emailTab.Controls.Add(this.label1);
            this.emailTab.Controls.Add(this.emailRepTextbox3);
            this.emailTab.Controls.Add(this.label2);
            this.emailTab.Controls.Add(this.emailRepTextbox2);
            this.emailTab.Controls.Add(this.label3);
            this.emailTab.Controls.Add(this.emailRepTextbox1);
            this.emailTab.Controls.Add(this.emailRepLB1);
            this.emailTab.Location = new System.Drawing.Point(4, 22);
            this.emailTab.Name = "emailTab";
            this.emailTab.Padding = new System.Windows.Forms.Padding(3);
            this.emailTab.Size = new System.Drawing.Size(790, 353);
            this.emailTab.TabIndex = 0;
            this.emailTab.Text = "Email";
            this.emailTab.UseVisualStyleBackColor = true;
            // 
            // emailEnableCheck
            // 
            this.emailEnableCheck.AutoSize = true;
            this.emailEnableCheck.Location = new System.Drawing.Point(362, 32);
            this.emailEnableCheck.Name = "emailEnableCheck";
            this.emailEnableCheck.Size = new System.Drawing.Size(65, 17);
            this.emailEnableCheck.TabIndex = 17;
            this.emailEnableCheck.Text = "Enabled";
            this.emailEnableCheck.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Enable Email Notifications";
            // 
            // emailRepTextbox5
            // 
            this.emailRepTextbox5.Location = new System.Drawing.Point(327, 235);
            this.emailRepTextbox5.Name = "emailRepTextbox5";
            this.emailRepTextbox5.Size = new System.Drawing.Size(100, 20);
            this.emailRepTextbox5.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email Recipient 5:";
            // 
            // emailRepTextbox4
            // 
            this.emailRepTextbox4.Location = new System.Drawing.Point(327, 194);
            this.emailRepTextbox4.Name = "emailRepTextbox4";
            this.emailRepTextbox4.Size = new System.Drawing.Size(100, 20);
            this.emailRepTextbox4.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Email Recipient 4:";
            // 
            // emailRepTextbox3
            // 
            this.emailRepTextbox3.Location = new System.Drawing.Point(327, 155);
            this.emailRepTextbox3.Name = "emailRepTextbox3";
            this.emailRepTextbox3.Size = new System.Drawing.Size(100, 20);
            this.emailRepTextbox3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email Recipient 3:";
            // 
            // emailRepTextbox2
            // 
            this.emailRepTextbox2.Location = new System.Drawing.Point(327, 117);
            this.emailRepTextbox2.Name = "emailRepTextbox2";
            this.emailRepTextbox2.Size = new System.Drawing.Size(100, 20);
            this.emailRepTextbox2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email Recipient 2:";
            // 
            // emailRepTextbox1
            // 
            this.emailRepTextbox1.Location = new System.Drawing.Point(327, 78);
            this.emailRepTextbox1.Name = "emailRepTextbox1";
            this.emailRepTextbox1.Size = new System.Drawing.Size(100, 20);
            this.emailRepTextbox1.TabIndex = 3;
            // 
            // emailRepLB1
            // 
            this.emailRepLB1.AutoSize = true;
            this.emailRepLB1.Location = new System.Drawing.Point(212, 85);
            this.emailRepLB1.Name = "emailRepLB1";
            this.emailRepLB1.Size = new System.Drawing.Size(92, 13);
            this.emailRepLB1.TabIndex = 2;
            this.emailRepLB1.Text = "Email Recipient 1:";
            // 
            // loggerTab
            // 
            this.loggerTab.Controls.Add(this.loggerEnableCheck);
            this.loggerTab.Controls.Add(this.errorsLogTypeRB);
            this.loggerTab.Controls.Add(this.allLogTypeRB);
            this.loggerTab.Controls.Add(this.logTypeLabel);
            this.loggerTab.Controls.Add(this.logFileNameTextbox);
            this.loggerTab.Controls.Add(this.logFileNameLabel);
            this.loggerTab.Controls.Add(this.logPathTextbox);
            this.loggerTab.Controls.Add(this.logPathLabel);
            this.loggerTab.Controls.Add(this.loggerEnLabel);
            this.loggerTab.Location = new System.Drawing.Point(4, 22);
            this.loggerTab.Name = "loggerTab";
            this.loggerTab.Size = new System.Drawing.Size(790, 353);
            this.loggerTab.TabIndex = 2;
            this.loggerTab.Text = "Logger";
            this.loggerTab.UseVisualStyleBackColor = true;
            // 
            // loggerEnableCheck
            // 
            this.loggerEnableCheck.AutoSize = true;
            this.loggerEnableCheck.Location = new System.Drawing.Point(353, 41);
            this.loggerEnableCheck.Name = "loggerEnableCheck";
            this.loggerEnableCheck.Size = new System.Drawing.Size(65, 17);
            this.loggerEnableCheck.TabIndex = 28;
            this.loggerEnableCheck.Text = "Enabled";
            this.loggerEnableCheck.UseVisualStyleBackColor = true;
            // 
            // errorsLogTypeRB
            // 
            this.errorsLogTypeRB.AutoSize = true;
            this.errorsLogTypeRB.Location = new System.Drawing.Point(394, 162);
            this.errorsLogTypeRB.Name = "errorsLogTypeRB";
            this.errorsLogTypeRB.Size = new System.Drawing.Size(76, 17);
            this.errorsLogTypeRB.TabIndex = 27;
            this.errorsLogTypeRB.TabStop = true;
            this.errorsLogTypeRB.Text = "Errors Only";
            this.errorsLogTypeRB.UseVisualStyleBackColor = true;
            // 
            // allLogTypeRB
            // 
            this.allLogTypeRB.AutoSize = true;
            this.allLogTypeRB.Location = new System.Drawing.Point(318, 162);
            this.allLogTypeRB.Name = "allLogTypeRB";
            this.allLogTypeRB.Size = new System.Drawing.Size(36, 17);
            this.allLogTypeRB.TabIndex = 25;
            this.allLogTypeRB.TabStop = true;
            this.allLogTypeRB.Text = "All";
            this.allLogTypeRB.UseVisualStyleBackColor = true;
            // 
            // logTypeLabel
            // 
            this.logTypeLabel.AutoSize = true;
            this.logTypeLabel.Location = new System.Drawing.Point(202, 166);
            this.logTypeLabel.Name = "logTypeLabel";
            this.logTypeLabel.Size = new System.Drawing.Size(52, 13);
            this.logTypeLabel.TabIndex = 24;
            this.logTypeLabel.Text = "Log Type";
            // 
            // logFileNameTextbox
            // 
            this.logFileNameTextbox.Location = new System.Drawing.Point(318, 120);
            this.logFileNameTextbox.Name = "logFileNameTextbox";
            this.logFileNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.logFileNameTextbox.TabIndex = 23;
            // 
            // logFileNameLabel
            // 
            this.logFileNameLabel.AutoSize = true;
            this.logFileNameLabel.Location = new System.Drawing.Point(203, 127);
            this.logFileNameLabel.Name = "logFileNameLabel";
            this.logFileNameLabel.Size = new System.Drawing.Size(75, 13);
            this.logFileNameLabel.TabIndex = 22;
            this.logFileNameLabel.Text = "Log File Name";
            // 
            // logPathTextbox
            // 
            this.logPathTextbox.Location = new System.Drawing.Point(318, 81);
            this.logPathTextbox.Name = "logPathTextbox";
            this.logPathTextbox.Size = new System.Drawing.Size(100, 20);
            this.logPathTextbox.TabIndex = 21;
            // 
            // logPathLabel
            // 
            this.logPathLabel.AutoSize = true;
            this.logPathLabel.Location = new System.Drawing.Point(203, 88);
            this.logPathLabel.Name = "logPathLabel";
            this.logPathLabel.Size = new System.Drawing.Size(81, 13);
            this.logPathLabel.TabIndex = 20;
            this.logPathLabel.Text = "Path to Log File";
            // 
            // loggerEnLabel
            // 
            this.loggerEnLabel.AutoSize = true;
            this.loggerEnLabel.Location = new System.Drawing.Point(203, 45);
            this.loggerEnLabel.Name = "loggerEnLabel";
            this.loggerEnLabel.Size = new System.Drawing.Size(76, 13);
            this.loggerEnLabel.TabIndex = 18;
            this.loggerEnLabel.Text = "Enable Logger";
            // 
            // thresholdTab
            // 
            this.thresholdTab.Location = new System.Drawing.Point(4, 22);
            this.thresholdTab.Name = "thresholdTab";
            this.thresholdTab.Size = new System.Drawing.Size(790, 353);
            this.thresholdTab.TabIndex = 3;
            this.thresholdTab.Text = "Thresholds";
            this.thresholdTab.UseVisualStyleBackColor = true;
            // 
            // cancelBut
            // 
            this.cancelBut.Location = new System.Drawing.Point(439, 396);
            this.cancelBut.Name = "cancelBut";
            this.cancelBut.Size = new System.Drawing.Size(75, 23);
            this.cancelBut.TabIndex = 3;
            this.cancelBut.Text = "Cancel";
            this.cancelBut.UseVisualStyleBackColor = true;
            this.cancelBut.Click += new System.EventHandler(this.cancelBut_Click);
            // 
            // saveBut
            // 
            this.saveBut.Location = new System.Drawing.Point(210, 396);
            this.saveBut.Name = "saveBut";
            this.saveBut.Size = new System.Drawing.Size(75, 23);
            this.saveBut.TabIndex = 2;
            this.saveBut.Text = "Save";
            this.saveBut.UseVisualStyleBackColor = true;
            this.saveBut.Click += new System.EventHandler(this.saveBut_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelBut);
            this.Controls.Add(this.saveBut);
            this.Controls.Add(this.tabControl1);
            this.Name = "Options";
            this.Text = "Options";
            this.tabControl1.ResumeLayout(false);
            this.monitorTab.ResumeLayout(false);
            this.monitorTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pingIntNumField)).EndInit();
            this.alertsTab.ResumeLayout(false);
            this.alertsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smtpPortNumeric)).EndInit();
            this.emailTab.ResumeLayout(false);
            this.emailTab.PerformLayout();
            this.loggerTab.ResumeLayout(false);
            this.loggerTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage emailTab;
        private System.Windows.Forms.TabPage alertsTab;
        private System.Windows.Forms.Button cancelBut;
        private System.Windows.Forms.Button saveBut;
        private System.Windows.Forms.TabPage loggerTab;
        private System.Windows.Forms.TabPage thresholdTab;
        private System.Windows.Forms.TabPage monitorTab;
        private System.Windows.Forms.Label pingIntLabel;
        private System.Windows.Forms.TextBox emailRepTextbox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailRepTextbox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailRepTextbox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailRepTextbox1;
        private System.Windows.Forms.Label emailRepLB1;
        private System.Windows.Forms.TextBox emailRepTextbox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label tlsSslLabel;
        private System.Windows.Forms.Label smtpLabel;
        private System.Windows.Forms.TextBox mailServerTextbox;
        private System.Windows.Forms.Label mailServerLB;
        private System.Windows.Forms.TextBox subjectTextbox;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.NumericUpDown smtpPortNumeric;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.ComboBox tlsSslCombobox;
        private System.Windows.Forms.Button testEmailButton;
        private System.Windows.Forms.Label loggerEnLabel;
        private System.Windows.Forms.TextBox logFileNameTextbox;
        private System.Windows.Forms.Label logFileNameLabel;
        private System.Windows.Forms.TextBox logPathTextbox;
        private System.Windows.Forms.Label logPathLabel;
        private System.Windows.Forms.RadioButton errorsLogTypeRB;
        private System.Windows.Forms.RadioButton allLogTypeRB;
        private System.Windows.Forms.Label logTypeLabel;
        private System.Windows.Forms.NumericUpDown pingIntNumField;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox emailEnableCheck;
        private System.Windows.Forms.CheckBox loggerEnableCheck;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}