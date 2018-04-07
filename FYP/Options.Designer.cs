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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.monitorTab = new System.Windows.Forms.TabPage();
            this.pingIntTextbox = new System.Windows.Forms.TextBox();
            this.pingIntLabel = new System.Windows.Forms.Label();
            this.alertsTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.smtpPortNumeric = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.senderLabel = new System.Windows.Forms.Label();
            this.emailTab = new System.Windows.Forms.TabPage();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
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
            this.thresholdTab = new System.Windows.Forms.TabPage();
            this.cancelBut = new System.Windows.Forms.Button();
            this.saveBut = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.monitorTab.SuspendLayout();
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
            this.monitorTab.Controls.Add(this.pingIntTextbox);
            this.monitorTab.Controls.Add(this.pingIntLabel);
            this.monitorTab.Location = new System.Drawing.Point(4, 22);
            this.monitorTab.Name = "monitorTab";
            this.monitorTab.Size = new System.Drawing.Size(790, 353);
            this.monitorTab.TabIndex = 4;
            this.monitorTab.Text = "Monitoring";
            this.monitorTab.UseVisualStyleBackColor = true;
            // 
            // pingIntTextbox
            // 
            this.pingIntTextbox.Location = new System.Drawing.Point(358, 77);
            this.pingIntTextbox.Name = "pingIntTextbox";
            this.pingIntTextbox.Size = new System.Drawing.Size(100, 20);
            this.pingIntTextbox.TabIndex = 1;
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
            this.alertsTab.Controls.Add(this.button1);
            this.alertsTab.Controls.Add(this.textBox2);
            this.alertsTab.Controls.Add(this.label6);
            this.alertsTab.Controls.Add(this.comboBox2);
            this.alertsTab.Controls.Add(this.smtpPortNumeric);
            this.alertsTab.Controls.Add(this.textBox1);
            this.alertsTab.Controls.Add(this.label7);
            this.alertsTab.Controls.Add(this.label8);
            this.alertsTab.Controls.Add(this.label9);
            this.alertsTab.Controls.Add(this.textBox4);
            this.alertsTab.Controls.Add(this.label10);
            this.alertsTab.Controls.Add(this.textBox5);
            this.alertsTab.Controls.Add(this.senderLabel);
            this.alertsTab.Location = new System.Drawing.Point(4, 22);
            this.alertsTab.Name = "alertsTab";
            this.alertsTab.Padding = new System.Windows.Forms.Padding(3);
            this.alertsTab.Size = new System.Drawing.Size(790, 353);
            this.alertsTab.TabIndex = 1;
            this.alertsTab.Text = "Alerts";
            this.alertsTab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Send Test Email";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(318, 235);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Password";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "TLS",
            "SSL"});
            this.comboBox2.Location = new System.Drawing.Point(318, 149);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 30;
            // 
            // smtpPortNumeric
            // 
            this.smtpPortNumeric.Location = new System.Drawing.Point(318, 111);
            this.smtpPortNumeric.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.smtpPortNumeric.Name = "smtpPortNumeric";
            this.smtpPortNumeric.Size = new System.Drawing.Size(100, 20);
            this.smtpPortNumeric.TabIndex = 28;
            this.smtpPortNumeric.ThousandsSeparator = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(318, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "TLS/SSL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "SMTP";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(318, 73);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(203, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Outgoing Mail Server";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(318, 34);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 19;
            // 
            // senderLabel
            // 
            this.senderLabel.AutoSize = true;
            this.senderLabel.Location = new System.Drawing.Point(203, 41);
            this.senderLabel.Name = "senderLabel";
            this.senderLabel.Size = new System.Drawing.Size(41, 13);
            this.senderLabel.TabIndex = 18;
            this.senderLabel.Text = "Sender";
            // 
            // emailTab
            // 
            this.emailTab.Controls.Add(this.radioButton1);
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
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(370, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 17);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "enable";
            this.radioButton1.UseVisualStyleBackColor = true;
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
            this.loggerTab.Controls.Add(this.radioButton4);
            this.loggerTab.Controls.Add(this.radioButton3);
            this.loggerTab.Controls.Add(this.label14);
            this.loggerTab.Controls.Add(this.textBox3);
            this.loggerTab.Controls.Add(this.label12);
            this.loggerTab.Controls.Add(this.textBox6);
            this.loggerTab.Controls.Add(this.label13);
            this.loggerTab.Controls.Add(this.radioButton2);
            this.loggerTab.Controls.Add(this.label11);
            this.loggerTab.Location = new System.Drawing.Point(4, 22);
            this.loggerTab.Name = "loggerTab";
            this.loggerTab.Size = new System.Drawing.Size(790, 353);
            this.loggerTab.TabIndex = 2;
            this.loggerTab.Text = "Logger";
            this.loggerTab.UseVisualStyleBackColor = true;
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
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(361, 41);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(57, 17);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "enable";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(203, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Enable Logger";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(318, 120);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(203, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Log File Name";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(318, 81);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(203, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Path to Log File";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(318, 162);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(36, 17);
            this.radioButton3.TabIndex = 25;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "All";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(202, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Log Type";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(394, 162);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(76, 17);
            this.radioButton4.TabIndex = 27;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Errors Only";
            this.radioButton4.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.TextBox pingIntTextbox;
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
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label senderLabel;
        private System.Windows.Forms.NumericUpDown smtpPortNumeric;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label14;
    }
}