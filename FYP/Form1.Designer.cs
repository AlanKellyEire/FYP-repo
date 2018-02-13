namespace FYP_10_2_18
{
    partial class Form1
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
            this.scanNet1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.netIp1a = new System.Windows.Forms.NumericUpDown();
            this.netIp1b = new System.Windows.Forms.NumericUpDown();
            this.netIp1c = new System.Windows.Forms.NumericUpDown();
            this.netIp1d = new System.Windows.Forms.NumericUpDown();
            this.subnet1d = new System.Windows.Forms.NumericUpDown();
            this.subnet1c = new System.Windows.Forms.NumericUpDown();
            this.subnet1b = new System.Windows.Forms.NumericUpDown();
            this.subnet1a = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.netIp1a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.netIp1b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.netIp1c)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.netIp1d)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subnet1d)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subnet1c)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subnet1b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subnet1a)).BeginInit();
            this.SuspendLayout();
            // 
            // scanNet1
            // 
            this.scanNet1.Location = new System.Drawing.Point(891, 283);
            this.scanNet1.Name = "scanNet1";
            this.scanNet1.Size = new System.Drawing.Size(161, 23);
            this.scanNet1.TabIndex = 1;
            this.scanNet1.Text = "Scan Networks";
            this.scanNet1.UseVisualStyleBackColor = true;
            this.scanNet1.Click += new System.EventHandler(this.ScanNetwork_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = ".";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Network IP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Subnet";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // netIp1a
            // 
            this.netIp1a.Location = new System.Drawing.Point(124, 70);
            this.netIp1a.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.netIp1a.Name = "netIp1a";
            this.netIp1a.Size = new System.Drawing.Size(43, 24);
            this.netIp1a.TabIndex = 18;
            this.netIp1a.Value = new decimal(new int[] {
            192,
            0,
            0,
            0});
            // 
            // netIp1b
            // 
            this.netIp1b.Location = new System.Drawing.Point(196, 70);
            this.netIp1b.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.netIp1b.Name = "netIp1b";
            this.netIp1b.Size = new System.Drawing.Size(43, 24);
            this.netIp1b.TabIndex = 19;
            this.netIp1b.Value = new decimal(new int[] {
            168,
            0,
            0,
            0});
            this.netIp1b.ValueChanged += new System.EventHandler(this.netIp1b_ValueChanged);
            // 
            // netIp1c
            // 
            this.netIp1c.Location = new System.Drawing.Point(268, 70);
            this.netIp1c.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.netIp1c.Name = "netIp1c";
            this.netIp1c.Size = new System.Drawing.Size(43, 24);
            this.netIp1c.TabIndex = 20;
            // 
            // netIp1d
            // 
            this.netIp1d.Location = new System.Drawing.Point(340, 69);
            this.netIp1d.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.netIp1d.Name = "netIp1d";
            this.netIp1d.Size = new System.Drawing.Size(43, 24);
            this.netIp1d.TabIndex = 21;
            this.netIp1d.ValueChanged += new System.EventHandler(this.netIp1d_ValueChanged);
            // 
            // subnet1d
            // 
            this.subnet1d.Location = new System.Drawing.Point(745, 69);
            this.subnet1d.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.subnet1d.Name = "subnet1d";
            this.subnet1d.Size = new System.Drawing.Size(43, 24);
            this.subnet1d.TabIndex = 28;
            this.subnet1d.ValueChanged += new System.EventHandler(this.subnet1d_ValueChanged);
            // 
            // subnet1c
            // 
            this.subnet1c.Location = new System.Drawing.Point(673, 69);
            this.subnet1c.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.subnet1c.Name = "subnet1c";
            this.subnet1c.Size = new System.Drawing.Size(43, 24);
            this.subnet1c.TabIndex = 27;
            this.subnet1c.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // subnet1b
            // 
            this.subnet1b.Location = new System.Drawing.Point(601, 69);
            this.subnet1b.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.subnet1b.Name = "subnet1b";
            this.subnet1b.Size = new System.Drawing.Size(43, 24);
            this.subnet1b.TabIndex = 26;
            this.subnet1b.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.subnet1b.ValueChanged += new System.EventHandler(this.subnet1b_ValueChanged);
            // 
            // subnet1a
            // 
            this.subnet1a.Location = new System.Drawing.Point(529, 69);
            this.subnet1a.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.subnet1a.Name = "subnet1a";
            this.subnet1a.Size = new System.Drawing.Size(43, 24);
            this.subnet1a.TabIndex = 25;
            this.subnet1a.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(722, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = ".";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(650, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = ".";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(578, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = ".";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Select Path";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(205, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 24);
            this.textBox1.TabIndex = 31;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1078, 344);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.subnet1d);
            this.Controls.Add(this.subnet1c);
            this.Controls.Add(this.subnet1b);
            this.Controls.Add(this.subnet1a);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.netIp1d);
            this.Controls.Add(this.netIp1c);
            this.Controls.Add(this.netIp1b);
            this.Controls.Add(this.netIp1a);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scanNet1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.netIp1a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.netIp1b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.netIp1c)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.netIp1d)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subnet1d)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subnet1c)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subnet1b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subnet1a)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button scanNet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown netIp1a;
        private System.Windows.Forms.NumericUpDown netIp1b;
        private System.Windows.Forms.NumericUpDown netIp1c;
        private System.Windows.Forms.NumericUpDown netIp1d;
        private System.Windows.Forms.NumericUpDown subnet1d;
        private System.Windows.Forms.NumericUpDown subnet1c;
        private System.Windows.Forms.NumericUpDown subnet1b;
        private System.Windows.Forms.NumericUpDown subnet1a;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

