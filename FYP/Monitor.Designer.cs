﻿namespace FYP_10_2_18
{
    partial class Monitor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifcationsSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loggerSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thresholdsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AlertsLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.nodesBox = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.macDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipSecondaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.macSecondaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipThirdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.macThirdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipFourthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.macFourthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alertsBox = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nodeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nodesBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFromDatabaseToolStripMenuItem,
            this.scanNetworkToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadFromDatabaseToolStripMenuItem
            // 
            this.loadFromDatabaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFromDBToolStripMenuItem,
            this.deleteDBToolStripMenuItem});
            this.loadFromDatabaseToolStripMenuItem.Name = "loadFromDatabaseToolStripMenuItem";
            this.loadFromDatabaseToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.loadFromDatabaseToolStripMenuItem.Text = "Database";
            // 
            // loadFromDBToolStripMenuItem
            // 
            this.loadFromDBToolStripMenuItem.Name = "loadFromDBToolStripMenuItem";
            this.loadFromDBToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.loadFromDBToolStripMenuItem.Text = "Load From DB";
            // 
            // deleteDBToolStripMenuItem
            // 
            this.deleteDBToolStripMenuItem.Name = "deleteDBToolStripMenuItem";
            this.deleteDBToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.deleteDBToolStripMenuItem.Text = "Delete DB";
            // 
            // scanNetworkToolStripMenuItem
            // 
            this.scanNetworkToolStripMenuItem.Name = "scanNetworkToolStripMenuItem";
            this.scanNetworkToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.scanNetworkToolStripMenuItem.Text = "Scan Network";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notifcationsSettingsToolStripMenuItem,
            this.emailToolStripMenuItem,
            this.loggerSettingsToolStripMenuItem,
            this.notifactionsToolStripMenuItem,
            this.thresholdsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // notifcationsSettingsToolStripMenuItem
            // 
            this.notifcationsSettingsToolStripMenuItem.Name = "notifcationsSettingsToolStripMenuItem";
            this.notifcationsSettingsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.notifcationsSettingsToolStripMenuItem.Text = "Monitoring Settings";
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.emailToolStripMenuItem.Text = "Email Server Settings";
            // 
            // loggerSettingsToolStripMenuItem
            // 
            this.loggerSettingsToolStripMenuItem.Name = "loggerSettingsToolStripMenuItem";
            this.loggerSettingsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.loggerSettingsToolStripMenuItem.Text = "Logger Settings";
            // 
            // notifactionsToolStripMenuItem
            // 
            this.notifactionsToolStripMenuItem.Name = "notifactionsToolStripMenuItem";
            this.notifactionsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.notifactionsToolStripMenuItem.Text = "Notifications Settings";
            // 
            // thresholdsToolStripMenuItem
            // 
            this.thresholdsToolStripMenuItem.Name = "thresholdsToolStripMenuItem";
            this.thresholdsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.thresholdsToolStripMenuItem.Text = "Thresholds";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // AlertsLabel
            // 
            this.AlertsLabel.AutoSize = true;
            this.AlertsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlertsLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.AlertsLabel.Location = new System.Drawing.Point(12, 24);
            this.AlertsLabel.Name = "AlertsLabel";
            this.AlertsLabel.Size = new System.Drawing.Size(56, 20);
            this.AlertsLabel.TabIndex = 2;
            this.AlertsLabel.Text = "Alerts";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(722, 28);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(26, 13);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "time";
            // 
            // nodesBox
            // 
            this.nodesBox.AutoGenerateColumns = false;
            this.nodesBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nodesBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.hostnameDataGridViewTextBoxColumn1,
            this.ipDataGridViewTextBoxColumn,
            this.macDataGridViewTextBoxColumn,
            this.ipSecondaryDataGridViewTextBoxColumn,
            this.macSecondaryDataGridViewTextBoxColumn,
            this.ipThirdDataGridViewTextBoxColumn,
            this.macThirdDataGridViewTextBoxColumn,
            this.ipFourthDataGridViewTextBoxColumn,
            this.macFourthDataGridViewTextBoxColumn});
            this.nodesBox.DataSource = this.nodeBindingSource;
            this.nodesBox.Location = new System.Drawing.Point(12, 200);
            this.nodesBox.Name = "nodesBox";
            this.nodesBox.Size = new System.Drawing.Size(564, 246);
            this.nodesBox.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Width = 30;
            // 
            // hostnameDataGridViewTextBoxColumn1
            // 
            this.hostnameDataGridViewTextBoxColumn1.DataPropertyName = "Hostname";
            this.hostnameDataGridViewTextBoxColumn1.HeaderText = "Hostname";
            this.hostnameDataGridViewTextBoxColumn1.Name = "hostnameDataGridViewTextBoxColumn1";
            this.hostnameDataGridViewTextBoxColumn1.Width = 130;
            // 
            // ipDataGridViewTextBoxColumn
            // 
            this.ipDataGridViewTextBoxColumn.DataPropertyName = "Ip";
            this.ipDataGridViewTextBoxColumn.HeaderText = "Ip";
            this.ipDataGridViewTextBoxColumn.Name = "ipDataGridViewTextBoxColumn";
            // 
            // macDataGridViewTextBoxColumn
            // 
            this.macDataGridViewTextBoxColumn.DataPropertyName = "Mac";
            this.macDataGridViewTextBoxColumn.HeaderText = "Mac";
            this.macDataGridViewTextBoxColumn.Name = "macDataGridViewTextBoxColumn";
            // 
            // ipSecondaryDataGridViewTextBoxColumn
            // 
            this.ipSecondaryDataGridViewTextBoxColumn.DataPropertyName = "IpSecondary";
            this.ipSecondaryDataGridViewTextBoxColumn.HeaderText = "IpSecondary";
            this.ipSecondaryDataGridViewTextBoxColumn.Name = "ipSecondaryDataGridViewTextBoxColumn";
            // 
            // macSecondaryDataGridViewTextBoxColumn
            // 
            this.macSecondaryDataGridViewTextBoxColumn.DataPropertyName = "MacSecondary";
            this.macSecondaryDataGridViewTextBoxColumn.HeaderText = "MacSecondary";
            this.macSecondaryDataGridViewTextBoxColumn.Name = "macSecondaryDataGridViewTextBoxColumn";
            // 
            // ipThirdDataGridViewTextBoxColumn
            // 
            this.ipThirdDataGridViewTextBoxColumn.DataPropertyName = "IpThird";
            this.ipThirdDataGridViewTextBoxColumn.HeaderText = "IpThird";
            this.ipThirdDataGridViewTextBoxColumn.Name = "ipThirdDataGridViewTextBoxColumn";
            // 
            // macThirdDataGridViewTextBoxColumn
            // 
            this.macThirdDataGridViewTextBoxColumn.DataPropertyName = "MacThird";
            this.macThirdDataGridViewTextBoxColumn.HeaderText = "MacThird";
            this.macThirdDataGridViewTextBoxColumn.Name = "macThirdDataGridViewTextBoxColumn";
            // 
            // ipFourthDataGridViewTextBoxColumn
            // 
            this.ipFourthDataGridViewTextBoxColumn.DataPropertyName = "IpFourth";
            this.ipFourthDataGridViewTextBoxColumn.HeaderText = "IpFourth";
            this.ipFourthDataGridViewTextBoxColumn.Name = "ipFourthDataGridViewTextBoxColumn";
            // 
            // macFourthDataGridViewTextBoxColumn
            // 
            this.macFourthDataGridViewTextBoxColumn.DataPropertyName = "MacFourth";
            this.macFourthDataGridViewTextBoxColumn.HeaderText = "MacFourth";
            this.macFourthDataGridViewTextBoxColumn.Name = "macFourthDataGridViewTextBoxColumn";
            // 
            // nodeBindingSource
            // 
            this.nodeBindingSource.DataSource = typeof(FYP_10_2_18.Node);
            // 
            // alertsBox
            // 
            this.alertsBox.AllowUserToResizeColumns = false;
            this.alertsBox.AllowUserToResizeRows = false;
            this.alertsBox.AutoGenerateColumns = false;
            this.alertsBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alertsBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.hostnameDataGridViewTextBoxColumn,
            this.nodeIdDataGridViewTextBoxColumn,
            this.errorTypeDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.timestampDataGridViewTextBoxColumn});
            this.alertsBox.DataSource = this.errorBindingSource;
            this.alertsBox.Location = new System.Drawing.Point(12, 44);
            this.alertsBox.Name = "alertsBox";
            this.alertsBox.Size = new System.Drawing.Size(776, 150);
            this.alertsBox.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // hostnameDataGridViewTextBoxColumn
            // 
            this.hostnameDataGridViewTextBoxColumn.DataPropertyName = "Hostname";
            this.hostnameDataGridViewTextBoxColumn.HeaderText = "Hostname";
            this.hostnameDataGridViewTextBoxColumn.Name = "hostnameDataGridViewTextBoxColumn";
            this.hostnameDataGridViewTextBoxColumn.Width = 130;
            // 
            // nodeIdDataGridViewTextBoxColumn
            // 
            this.nodeIdDataGridViewTextBoxColumn.DataPropertyName = "NodeId";
            this.nodeIdDataGridViewTextBoxColumn.HeaderText = "NodeId";
            this.nodeIdDataGridViewTextBoxColumn.Name = "nodeIdDataGridViewTextBoxColumn";
            // 
            // errorTypeDataGridViewTextBoxColumn
            // 
            this.errorTypeDataGridViewTextBoxColumn.DataPropertyName = "ErrorType";
            this.errorTypeDataGridViewTextBoxColumn.HeaderText = "ErrorType";
            this.errorTypeDataGridViewTextBoxColumn.Name = "errorTypeDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // timestampDataGridViewTextBoxColumn
            // 
            this.timestampDataGridViewTextBoxColumn.DataPropertyName = "Timestamp";
            this.timestampDataGridViewTextBoxColumn.HeaderText = "Timestamp";
            this.timestampDataGridViewTextBoxColumn.Name = "timestampDataGridViewTextBoxColumn";
            // 
            // errorBindingSource
            // 
            this.errorBindingSource.DataSource = typeof(FYP_10_2_18.Error);
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nodesBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.AlertsLabel);
            this.Controls.Add(this.alertsBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Monitor";
            this.Text = "Monitor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nodesBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanNetworkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notifcationsSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loggerSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notifactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thresholdsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Label AlertsLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.DataGridView nodesBox;
        private System.Windows.Forms.DataGridView alertsBox;
        private System.Windows.Forms.BindingSource nodeBindingSource;
        private System.Windows.Forms.BindingSource errorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn macDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipSecondaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn macSecondaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipThirdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn macThirdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipFourthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn macFourthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nodeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestampDataGridViewTextBoxColumn;
    }
}