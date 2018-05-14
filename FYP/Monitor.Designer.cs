namespace FYP_10_2_18
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteErrorsDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteNodesDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeRemoveNodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AlertsLabel = new System.Windows.Forms.Label();
            this.nodesBox = new System.Windows.Forms.DataGridView();
            this.alertsBox = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nodeAlertBox = new System.Windows.Forms.DataGridView();
            this.nodeErrorsLB = new System.Windows.Forms.Label();
            this.monitoringCB = new System.Windows.Forms.CheckBox();
            this.colourTB = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.searchTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ipDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timestampDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.errorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exportListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveNodeListToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveErrorListToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nodesBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeAlertBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBindingSource1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1013, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFromDatabaseToolStripMenuItem,
            this.scanNetworkToolStripMenuItem,
            this.exportListToolStripMenuItem,
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
            this.deleteDBToolStripMenuItem,
            this.addNodeToolStripMenuItem,
            this.deleteNodeToolStripMenuItem});
            this.loadFromDatabaseToolStripMenuItem.Name = "loadFromDatabaseToolStripMenuItem";
            this.loadFromDatabaseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadFromDatabaseToolStripMenuItem.Text = "Database";
            // 
            // loadFromDBToolStripMenuItem
            // 
            this.loadFromDBToolStripMenuItem.Name = "loadFromDBToolStripMenuItem";
            this.loadFromDBToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.loadFromDBToolStripMenuItem.Text = "Load From DB";
            this.loadFromDBToolStripMenuItem.Click += new System.EventHandler(this.loadFromDBToolStripMenuItem_Click);
            // 
            // deleteDBToolStripMenuItem
            // 
            this.deleteDBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteErrorsDBToolStripMenuItem,
            this.deleteNodesDBToolStripMenuItem});
            this.deleteDBToolStripMenuItem.Name = "deleteDBToolStripMenuItem";
            this.deleteDBToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.deleteDBToolStripMenuItem.Text = "Delete DB";
            this.deleteDBToolStripMenuItem.Click += new System.EventHandler(this.deleteDBToolStripMenuItem_Click);
            // 
            // deleteErrorsDBToolStripMenuItem
            // 
            this.deleteErrorsDBToolStripMenuItem.Name = "deleteErrorsDBToolStripMenuItem";
            this.deleteErrorsDBToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.deleteErrorsDBToolStripMenuItem.Text = "Delete Errors DB";
            this.deleteErrorsDBToolStripMenuItem.Click += new System.EventHandler(this.deleteErrorsDBToolStripMenuItem_Click);
            // 
            // deleteNodesDBToolStripMenuItem
            // 
            this.deleteNodesDBToolStripMenuItem.Name = "deleteNodesDBToolStripMenuItem";
            this.deleteNodesDBToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.deleteNodesDBToolStripMenuItem.Text = "Delete Nodes DB";
            this.deleteNodesDBToolStripMenuItem.Click += new System.EventHandler(this.deleteNodesDBToolStripMenuItem_Click);
            // 
            // addNodeToolStripMenuItem
            // 
            this.addNodeToolStripMenuItem.Name = "addNodeToolStripMenuItem";
            this.addNodeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.addNodeToolStripMenuItem.Text = "Add Node";
            this.addNodeToolStripMenuItem.Click += new System.EventHandler(this.addNodeToolStripMenuItem_Click);
            // 
            // deleteNodeToolStripMenuItem
            // 
            this.deleteNodeToolStripMenuItem.Name = "deleteNodeToolStripMenuItem";
            this.deleteNodeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.deleteNodeToolStripMenuItem.Text = "Delete Node";
            this.deleteNodeToolStripMenuItem.Click += new System.EventHandler(this.deleteNodeToolStripMenuItem_Click);
            // 
            // scanNetworkToolStripMenuItem
            // 
            this.scanNetworkToolStripMenuItem.Name = "scanNetworkToolStripMenuItem";
            this.scanNetworkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.scanNetworkToolStripMenuItem.Text = "Scan Network";
            this.scanNetworkToolStripMenuItem.Click += new System.EventHandler(this.scanNetworkToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mergeRemoveNodesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // mergeRemoveNodesToolStripMenuItem
            // 
            this.mergeRemoveNodesToolStripMenuItem.Name = "mergeRemoveNodesToolStripMenuItem";
            this.mergeRemoveNodesToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.mergeRemoveNodesToolStripMenuItem.Text = "Merge/Remove Nodes";
            this.mergeRemoveNodesToolStripMenuItem.Click += new System.EventHandler(this.mergeRemoveNodesToolStripMenuItem_Click);
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
            // nodesBox
            // 
            this.nodesBox.AllowUserToResizeRows = false;
            this.nodesBox.AutoGenerateColumns = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nodesBox.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.nodesBox.DefaultCellStyle = dataGridViewCellStyle8;
            this.nodesBox.Location = new System.Drawing.Point(12, 229);
            this.nodesBox.MultiSelect = false;
            this.nodesBox.Name = "nodesBox";
            this.nodesBox.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nodesBox.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.nodesBox.RowHeadersVisible = false;
            this.nodesBox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nodesBox.Size = new System.Drawing.Size(989, 246);
            this.nodesBox.TabIndex = 4;
            this.nodesBox.Click += new System.EventHandler(this.selectedCellsButton_Click);
            // 
            // alertsBox
            // 
            this.alertsBox.AllowUserToAddRows = false;
            this.alertsBox.AllowUserToDeleteRows = false;
            this.alertsBox.AllowUserToResizeColumns = false;
            this.alertsBox.AllowUserToResizeRows = false;
            this.alertsBox.AutoGenerateColumns = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.alertsBox.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.alertsBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alertsBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.hostnameDataGridViewTextBoxColumn,
            this.ipDataGridViewTextBoxColumn2,
            this.errorTypeDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.timestampDataGridViewTextBoxColumn});
            this.alertsBox.DataSource = this.errorBindingSource2;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.alertsBox.DefaultCellStyle = dataGridViewCellStyle11;
            this.alertsBox.Location = new System.Drawing.Point(12, 44);
            this.alertsBox.Name = "alertsBox";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.alertsBox.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.alertsBox.RowHeadersVisible = false;
            this.alertsBox.Size = new System.Drawing.Size(565, 150);
            this.alertsBox.TabIndex = 1;
            this.alertsBox.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.alertsBox_CellEndEdit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nodes";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nodeAlertBox
            // 
            this.nodeAlertBox.AutoGenerateColumns = false;
            this.nodeAlertBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nodeAlertBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ipDataGridViewTextBoxColumn1,
            this.timestampDataGridViewTextBoxColumn1,
            this.commentDataGridViewTextBoxColumn1,
            this.errorTypeDataGridViewTextBoxColumn1});
            this.nodeAlertBox.DataSource = this.errorBindingSource2;
            this.nodeAlertBox.Location = new System.Drawing.Point(583, 44);
            this.nodeAlertBox.Name = "nodeAlertBox";
            this.nodeAlertBox.RowHeadersVisible = false;
            this.nodeAlertBox.Size = new System.Drawing.Size(418, 150);
            this.nodeAlertBox.TabIndex = 6;
            // 
            // nodeErrorsLB
            // 
            this.nodeErrorsLB.AutoSize = true;
            this.nodeErrorsLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodeErrorsLB.ForeColor = System.Drawing.Color.DodgerBlue;
            this.nodeErrorsLB.Location = new System.Drawing.Point(579, 24);
            this.nodeErrorsLB.Name = "nodeErrorsLB";
            this.nodeErrorsLB.Size = new System.Drawing.Size(0, 20);
            this.nodeErrorsLB.TabIndex = 7;
            // 
            // monitoringCB
            // 
            this.monitoringCB.AutoSize = true;
            this.monitoringCB.Location = new System.Drawing.Point(908, 28);
            this.monitoringCB.Name = "monitoringCB";
            this.monitoringCB.Size = new System.Drawing.Size(75, 17);
            this.monitoringCB.TabIndex = 8;
            this.monitoringCB.Text = "Monitoring";
            this.monitoringCB.UseVisualStyleBackColor = true;
            this.monitoringCB.Visible = false;
            this.monitoringCB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // colourTB
            // 
            this.colourTB.Location = new System.Drawing.Point(882, 24);
            this.colourTB.Name = "colourTB";
            this.colourTB.Size = new System.Drawing.Size(20, 20);
            this.colourTB.TabIndex = 9;
            this.colourTB.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 60000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(901, 206);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(100, 20);
            this.searchTB.TabIndex = 10;
            this.searchTB.TextChanged += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(820, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Search Nodes";
            // 
            // ipDataGridViewTextBoxColumn1
            // 
            this.ipDataGridViewTextBoxColumn1.DataPropertyName = "Ip";
            this.ipDataGridViewTextBoxColumn1.HeaderText = "Ip";
            this.ipDataGridViewTextBoxColumn1.Name = "ipDataGridViewTextBoxColumn1";
            this.ipDataGridViewTextBoxColumn1.Width = 130;
            // 
            // timestampDataGridViewTextBoxColumn1
            // 
            this.timestampDataGridViewTextBoxColumn1.DataPropertyName = "Timestamp";
            this.timestampDataGridViewTextBoxColumn1.HeaderText = "Timestamp";
            this.timestampDataGridViewTextBoxColumn1.Name = "timestampDataGridViewTextBoxColumn1";
            this.timestampDataGridViewTextBoxColumn1.Width = 130;
            // 
            // commentDataGridViewTextBoxColumn1
            // 
            this.commentDataGridViewTextBoxColumn1.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn1.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn1.Name = "commentDataGridViewTextBoxColumn1";
            this.commentDataGridViewTextBoxColumn1.Width = 150;
            // 
            // errorTypeDataGridViewTextBoxColumn1
            // 
            this.errorTypeDataGridViewTextBoxColumn1.DataPropertyName = "ErrorType";
            this.errorTypeDataGridViewTextBoxColumn1.HeaderText = "ErrorType";
            this.errorTypeDataGridViewTextBoxColumn1.Name = "errorTypeDataGridViewTextBoxColumn1";
            // 
            // errorBindingSource2
            // 
            this.errorBindingSource2.DataSource = typeof(FYP_10_2_18.Error);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 30;
            // 
            // hostnameDataGridViewTextBoxColumn1
            // 
            this.hostnameDataGridViewTextBoxColumn1.DataPropertyName = "Hostname";
            this.hostnameDataGridViewTextBoxColumn1.HeaderText = "Hostname";
            this.hostnameDataGridViewTextBoxColumn1.Name = "hostnameDataGridViewTextBoxColumn1";
            this.hostnameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.hostnameDataGridViewTextBoxColumn1.Width = 130;
            // 
            // ipDataGridViewTextBoxColumn
            // 
            this.ipDataGridViewTextBoxColumn.DataPropertyName = "Ip";
            this.ipDataGridViewTextBoxColumn.HeaderText = "Ip";
            this.ipDataGridViewTextBoxColumn.Name = "ipDataGridViewTextBoxColumn";
            this.ipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // macDataGridViewTextBoxColumn
            // 
            this.macDataGridViewTextBoxColumn.DataPropertyName = "Mac";
            this.macDataGridViewTextBoxColumn.HeaderText = "Mac";
            this.macDataGridViewTextBoxColumn.Name = "macDataGridViewTextBoxColumn";
            this.macDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ipSecondaryDataGridViewTextBoxColumn
            // 
            this.ipSecondaryDataGridViewTextBoxColumn.DataPropertyName = "IpSecondary";
            this.ipSecondaryDataGridViewTextBoxColumn.HeaderText = "IpSecondary";
            this.ipSecondaryDataGridViewTextBoxColumn.Name = "ipSecondaryDataGridViewTextBoxColumn";
            this.ipSecondaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // macSecondaryDataGridViewTextBoxColumn
            // 
            this.macSecondaryDataGridViewTextBoxColumn.DataPropertyName = "MacSecondary";
            this.macSecondaryDataGridViewTextBoxColumn.HeaderText = "MacSecondary";
            this.macSecondaryDataGridViewTextBoxColumn.Name = "macSecondaryDataGridViewTextBoxColumn";
            this.macSecondaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ipThirdDataGridViewTextBoxColumn
            // 
            this.ipThirdDataGridViewTextBoxColumn.DataPropertyName = "IpThird";
            this.ipThirdDataGridViewTextBoxColumn.HeaderText = "IpThird";
            this.ipThirdDataGridViewTextBoxColumn.Name = "ipThirdDataGridViewTextBoxColumn";
            this.ipThirdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // macThirdDataGridViewTextBoxColumn
            // 
            this.macThirdDataGridViewTextBoxColumn.DataPropertyName = "MacThird";
            this.macThirdDataGridViewTextBoxColumn.HeaderText = "MacThird";
            this.macThirdDataGridViewTextBoxColumn.Name = "macThirdDataGridViewTextBoxColumn";
            this.macThirdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ipFourthDataGridViewTextBoxColumn
            // 
            this.ipFourthDataGridViewTextBoxColumn.DataPropertyName = "IpFourth";
            this.ipFourthDataGridViewTextBoxColumn.HeaderText = "IpFourth";
            this.ipFourthDataGridViewTextBoxColumn.Name = "ipFourthDataGridViewTextBoxColumn";
            this.ipFourthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // macFourthDataGridViewTextBoxColumn
            // 
            this.macFourthDataGridViewTextBoxColumn.DataPropertyName = "MacFourth";
            this.macFourthDataGridViewTextBoxColumn.HeaderText = "MacFourth";
            this.macFourthDataGridViewTextBoxColumn.Name = "macFourthDataGridViewTextBoxColumn";
            this.macFourthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nodeBindingSource
            // 
            this.nodeBindingSource.DataSource = typeof(FYP_10_2_18.Node);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // hostnameDataGridViewTextBoxColumn
            // 
            this.hostnameDataGridViewTextBoxColumn.DataPropertyName = "Hostname";
            this.hostnameDataGridViewTextBoxColumn.HeaderText = "Hostname";
            this.hostnameDataGridViewTextBoxColumn.Name = "hostnameDataGridViewTextBoxColumn";
            this.hostnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ipDataGridViewTextBoxColumn2
            // 
            this.ipDataGridViewTextBoxColumn2.DataPropertyName = "Ip";
            this.ipDataGridViewTextBoxColumn2.HeaderText = "Ip";
            this.ipDataGridViewTextBoxColumn2.Name = "ipDataGridViewTextBoxColumn2";
            this.ipDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // errorTypeDataGridViewTextBoxColumn
            // 
            this.errorTypeDataGridViewTextBoxColumn.DataPropertyName = "ErrorType";
            this.errorTypeDataGridViewTextBoxColumn.HeaderText = "ErrorType";
            this.errorTypeDataGridViewTextBoxColumn.Name = "errorTypeDataGridViewTextBoxColumn";
            this.errorTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.errorTypeDataGridViewTextBoxColumn.Width = 80;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timestampDataGridViewTextBoxColumn
            // 
            this.timestampDataGridViewTextBoxColumn.DataPropertyName = "Timestamp";
            this.timestampDataGridViewTextBoxColumn.HeaderText = "Timestamp";
            this.timestampDataGridViewTextBoxColumn.Name = "timestampDataGridViewTextBoxColumn";
            this.timestampDataGridViewTextBoxColumn.ReadOnly = true;
            this.timestampDataGridViewTextBoxColumn.Width = 125;
            // 
            // errorBindingSource1
            // 
            this.errorBindingSource1.DataSource = typeof(FYP_10_2_18.Error);
            // 
            // errorBindingSource
            // 
            this.errorBindingSource.DataSource = typeof(FYP_10_2_18.Error);
            // 
            // exportListToolStripMenuItem
            // 
            this.exportListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveNodeListToCSVToolStripMenuItem,
            this.saveErrorListToCSVToolStripMenuItem});
            this.exportListToolStripMenuItem.Name = "exportListToolStripMenuItem";
            this.exportListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportListToolStripMenuItem.Text = "Export list";
            // 
            // saveNodeListToCSVToolStripMenuItem
            // 
            this.saveNodeListToCSVToolStripMenuItem.Name = "saveNodeListToCSVToolStripMenuItem";
            this.saveNodeListToCSVToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveNodeListToCSVToolStripMenuItem.Text = "Save Node list to CSV";
            this.saveNodeListToCSVToolStripMenuItem.Click += new System.EventHandler(this.saveNodeListToCSVToolStripMenuItem_Click);
            // 
            // saveErrorListToCSVToolStripMenuItem
            // 
            this.saveErrorListToCSVToolStripMenuItem.Name = "saveErrorListToCSVToolStripMenuItem";
            this.saveErrorListToCSVToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveErrorListToCSVToolStripMenuItem.Text = "Save Error List to CSV";
            this.saveErrorListToCSVToolStripMenuItem.Click += new System.EventHandler(this.saveErrorListToCSVToolStripMenuItem_Click);
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 478);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.colourTB);
            this.Controls.Add(this.monitoringCB);
            this.Controls.Add(this.nodeErrorsLB);
            this.Controls.Add(this.nodeAlertBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nodesBox);
            this.Controls.Add(this.AlertsLabel);
            this.Controls.Add(this.alertsBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Monitor";
            this.Text = "Monitor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nodesBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeAlertBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBindingSource1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Label AlertsLabel;
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
        private System.Windows.Forms.ToolStripMenuItem mergeRemoveNodesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView nodeAlertBox;
        private System.Windows.Forms.BindingSource errorBindingSource1;
        private System.Windows.Forms.BindingSource errorBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestampDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label nodeErrorsLB;
        private System.Windows.Forms.CheckBox monitoringCB;
        private System.Windows.Forms.TextBox colourTB;
        private System.Windows.Forms.ToolStripMenuItem deleteErrorsDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteNodesDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteNodeToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestampDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem exportListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveNodeListToCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveErrorListToCSVToolStripMenuItem;
    }
}