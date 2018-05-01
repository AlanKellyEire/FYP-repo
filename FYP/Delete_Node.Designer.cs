namespace FYP_10_2_18
{
    partial class Delete_Node
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
            this.hostnameToDeleteTB = new System.Windows.Forms.TextBox();
            this.deleteBut = new System.Windows.Forms.Button();
            this.nodeLB = new System.Windows.Forms.Label();
            this.cancelBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hostnameToDeleteTB
            // 
            this.hostnameToDeleteTB.Location = new System.Drawing.Point(300, 72);
            this.hostnameToDeleteTB.Name = "hostnameToDeleteTB";
            this.hostnameToDeleteTB.Size = new System.Drawing.Size(100, 20);
            this.hostnameToDeleteTB.TabIndex = 0;
            // 
            // deleteBut
            // 
            this.deleteBut.Location = new System.Drawing.Point(419, 72);
            this.deleteBut.Name = "deleteBut";
            this.deleteBut.Size = new System.Drawing.Size(75, 23);
            this.deleteBut.TabIndex = 1;
            this.deleteBut.Text = "Delete Node";
            this.deleteBut.UseVisualStyleBackColor = true;
            this.deleteBut.Click += new System.EventHandler(this.deleteBut_Click);
            // 
            // nodeLB
            // 
            this.nodeLB.AutoSize = true;
            this.nodeLB.Location = new System.Drawing.Point(182, 75);
            this.nodeLB.Name = "nodeLB";
            this.nodeLB.Size = new System.Drawing.Size(92, 13);
            this.nodeLB.TabIndex = 2;
            this.nodeLB.Text = "Enter Node Name";
            // 
            // cancelBT
            // 
            this.cancelBT.Location = new System.Drawing.Point(524, 72);
            this.cancelBT.Name = "cancelBT";
            this.cancelBT.Size = new System.Drawing.Size(75, 23);
            this.cancelBT.TabIndex = 3;
            this.cancelBT.Text = "Cancel";
            this.cancelBT.UseVisualStyleBackColor = true;
            this.cancelBT.Click += new System.EventHandler(this.cancelBT_Click);
            // 
            // Delete_Node
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 201);
            this.Controls.Add(this.cancelBT);
            this.Controls.Add(this.nodeLB);
            this.Controls.Add(this.deleteBut);
            this.Controls.Add(this.hostnameToDeleteTB);
            this.Name = "Delete_Node";
            this.Text = "Delete_Node";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hostnameToDeleteTB;
        private System.Windows.Forms.Button deleteBut;
        private System.Windows.Forms.Label nodeLB;
        private System.Windows.Forms.Button cancelBT;
    }
}