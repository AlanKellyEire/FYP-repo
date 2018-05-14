using System;
using System.Threading;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FYP_10_2_18
{
    public partial class Monitor : Form
    {
        private ObservableCollection<Node> nodeList;
        private ObservableCollection<Error> errorList = new ObservableCollection<Error>();
        private ObservableCollection<Error> nodeErrorsList = new ObservableCollection<Error>();
        private ObservableCollection<Node> searchNodeList;
        private Settings set = new Settings();
        Boolean monitorCompleted = false;
        Boolean scannerEnabled = false;

        public Monitor()
        {
            InitializeComponent();
            PopulateNodesList();
            PopulateErrorList();
            System.Threading.Thread.Sleep(25);
            timer1.Start();

            Stream stream = File.Open("settingsSerial.osl", FileMode.Open);
            BinaryFormatter bformatter = new BinaryFormatter();

            //Console.WriteLine("\nReading Employee Information");
            set = (Settings)bformatter.Deserialize(stream);
            stream.Close();
            Trace.Write(set.PingInterval);
            timer2.Interval = (set.PingInterval * 1000);
            timer2.Start();
            //new Thread(delegate () {
            //    Run_Monitor();
            //}).Start();

            for (int i = 0; i < alertsBox.ColumnCount; i++)
            {
                alertsBox.Columns[i].ReadOnly = true;
            }
            alertsBox.Columns[4].ReadOnly = false;
        }

        internal ObservableCollection<Node> NodeList { get => nodeList; set => nodeList = value; }
        public bool ScannerEnabled { get => scannerEnabled; set => scannerEnabled = value; }

        public void PopulateNodesList()
        {
            DatabaseIO db = new DatabaseIO();

            nodeList = db.GetRows();
            nodesBox.DataSource = nodeList;
            nodesBox.Refresh();
        }

        public void PopulateErrorList()
        {
            DatabaseIO db = new DatabaseIO();

            db.PopulateErrorListFromDB(errorList);
            
            errorList = SortList(errorList);
            alertsBox.DataSource = null;
            alertsBox.DataSource = errorList;
            alertsBox.Refresh();
        }

        public void loadFromDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopulateNodesList();
            PopulateErrorList();
            nodesBox.Refresh();
            alertsBox.Refresh();
        }

        private void deleteDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseIO db = new DatabaseIO();

            db.DeleteRowsDB();
            db.DeleteErrorsDB();

            PopulateNodesList();
            PopulateErrorList();

            nodesBox.Refresh();
            alertsBox.Refresh();
        }

        private async void Run_Monitor()
        {

            List<string> logList = new List<string>();
            if (!monitorCompleted && !ScannerEnabled)
            {
                Trace.Write("running monitor \n");
                logList.Add(DateTime.Now.ToString() + ": running monitor \n");
                monitorCompleted = true;
                Ping ping = new Ping();

                foreach (Node n in NodeList)
                {
                    if (n.MonitorEnabled)
                    {
                        var reply = await ping.SendPingAsync(n.Ip);
                        if (reply.Status == IPStatus.Success)
                        {

                            Trace.Write(n.Hostname + ", " + n.Ip + " (OK)\n");
                            if (set.LogSettings.LogTypeAll)
                            {
                                logList.Add(logString(n, 0));
                            }
                        }
                        else
                        {
                            Trace.Write(DateTime.Now.ToString() + " - " + n.Hostname + ", " + n.Ip + " (Ping FAILED)\n");
                            logList.Add(logString(n, 1));
                            addError(n, 1);
                            n.MonitorEnabled = false;
                        }
                        if (n.IpSecondary.Length > 1)
                        {
                            var replySec = await ping.SendPingAsync(n.IpSecondary);
                            if (replySec.Status == IPStatus.Success)
                            {

                                Trace.Write(n.Hostname + ", " + n.IpSecondary + " (OK)\n");
                                if (set.LogSettings.LogTypeAll)
                                {
                                    logList.Add(logString(n, 0));
                                }
                            }
                            else
                            {
                                Trace.Write(n.Hostname + ", " + n.IpSecondary + " (FAILED)\n");
                                logList.Add(logString(n, 1));
                                addError(n, 2);
                                n.MonitorEnabled = false;
                            }
                        }
                        if (n.IpThird.Length > 1)
                        {
                            var replyThird = await ping.SendPingAsync(n.IpThird);
                            if (replyThird.Status == IPStatus.Success)
                            {

                                Trace.Write(n.Hostname + ", " + n.IpThird + " (OK)\n");
                                if (set.LogSettings.LogTypeAll)
                                {
                                    logList.Add(logString(n, 0));
                                }
                            }
                            else
                            {
                                Trace.Write(n.Hostname + ", " + n.IpThird + " (FAILED)\n");
                                logList.Add(logString(n, 1));
                                addError(n, 3);
                                n.MonitorEnabled = false;
                            }
                        }
                        if (n.IpFourth.Length > 1)
                        {
                            var replyFourth = await ping.SendPingAsync(n.IpFourth);
                            if (replyFourth.Status == IPStatus.Success)
                            {
                                Trace.Write(n.Hostname + ", " + n.IpFourth + " (OK)\n");
                                if (set.LogSettings.LogTypeAll)
                                {
                                    logList.Add(logString(n, 0));
                                }
                            }
                            else
                            {
                                Trace.Write(n.Hostname + ", " + n.IpFourth + " (FAILED)\n");

                                logList.Add(logString(n, 1));

                                addError(n, 4);
                                n.MonitorEnabled = false;
                            }
                        }
                    }
                }
                monitorCompleted = false;
            }
            if (set.LoggerEnabled)
            {
                ReadAndWrite rw = new ReadAndWrite(set.LogSettings.Path, set.LogSettings.Filename);
                rw.writeList(logList);
            }
        }

        private string logString(Node n, int error)
        {
            if (error == 1)
            {
                return DateTime.Now.ToString() + ": " + n.Hostname + ", " + n.Ip + " (Ping FAILED)\n";
            }
            else
            {
                return DateTime.Now.ToString() + ": " + n.Hostname + ", " + n.Ip + " (OK)\n";
            }
        }

        private ObservableCollection<Error> SortList(ObservableCollection<Error> list)
        {
            ObservableCollection<Error> tempList = new ObservableCollection<Error>();

            for (int i = 1; i <= list.Count; i++)
            {
                tempList.Add(list[list.Count - i]);
            }

            return tempList;
        }

        private void scanNetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 scanner = new Form1(this);
            scannerEnabled = true;
            scanner.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options opt = new Options(set);

            opt.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Defeat();
        }

        //private void button_Click(object sender, EventArgs e)
        //{
        //    monitor();
        //}

        private void Defeat()
        {
            //MessageBox.Show("Goodbye");
            DialogResult result = MessageBox.Show("Do you want to save the data before exiting?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //code for Yes
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                //code for No
                Application.Exit();
            }
            else if (result == DialogResult.Cancel)
            {
                //code for Cancel
            }

        }

        private void addError(Node n, int i)
        {
            DatabaseIO db = new DatabaseIO();
            db.WriteErrorToDB(n, i);
            if (set.EmailEnabled)
            {
                //Settings set = new Settings();
                Email mail = new Email();
                mail.sendEmail(set, n, i);
            }

        }

        private void AddToDB()
        {
            DatabaseIO db = new DatabaseIO();
            db.WriteNodeToDB(NodeList);

        }

        private void mergeRemoveNodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MergeNodes();
        }

        public void MergeNodes()
        {
            MergeNodes mN = new MergeNodes();

            NodeList = mN.MergeDuplicates(NodeList);

            nodesBox.EndEdit();
            AddToDB();
            nodesBox.Refresh();
            PopulateNodesList();
            PopulateErrorList();
        }

        // updates the 
        private void timer1_Tick(object sender, EventArgs e)
        {
            PopulateErrorList();
            alertsBox.DataSource = null;
            alertsBox.DataSource = errorList;
            Trace.Write("Alert grid updated!!\n");

        }

        //timer that runs every 
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = (set.PingInterval * 1000);
            new Thread(delegate ()
            {
                Run_Monitor();
            }).Start();
        }

        //populates the nodeerroralert for one node
        private void getNodeAlerts(string s)
        {
            DatabaseIO db = new DatabaseIO();
            
            nodeErrorsList = SortList(db.getNodeAlerts(s));

        }

        //gets the row selected from the nodelistbox and populates the top left section of the monitoring window
        private void selectedCellsButton_Click(object sender, System.EventArgs e)
        {
            Int32 selectedCellCount =
                nodesBox.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                if (nodesBox.AreAllCellsSelected(true))
                {
                    MessageBox.Show("All cells are selected", "Selected Cells");
                }
                else
                {
                    int row = nodesBox.CurrentCell.RowIndex;
                    string sqlSearchRow = (row + 1) + "";
                    getNodeAlerts(sqlSearchRow);

                    nodeAlertBox.DataSource = null;
                    nodeAlertBox.DataSource = nodeErrorsList;
                    nodeErrorsLB.Text = nodeList[row].Hostname.ToString();
                    monitoringCB.Visible = true;
                    colourTB.Visible = true;
                    monitoringCB.Checked = nodeList[row].MonitorEnabled;
                    if (monitoringCB.Checked)
                    {
                        colourTB.BackColor = Color.Green;
                    }
                    else
                    {
                        colourTB.BackColor = Color.Red;
                    }
                }
            }
        }

        //changes the checkbox value when clicked
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (nodeErrorsLB.Text != "")
            {
                for (int i = 0; i < nodeList.Count; i++)
                {
                    if (nodeErrorsLB.Text.Equals(nodeList[i].Hostname) && monitoringCB.Checked)
                    {
                        nodeList[i].MonitorEnabled = true;
                        colourTB.BackColor = Color.Green;
                    }
                    else if (nodeErrorsLB.Text.Equals(nodeList[i].Hostname) && !monitoringCB.Checked)
                    {
                        nodeList[i].MonitorEnabled = false;
                        colourTB.BackColor = Color.Red;
                    }
                }
            }
        }

        //used to delete error database
        private void deleteErrorsDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseIO db = new DatabaseIO();
            db.DeleteErrorsDB();
            errorList.Clear();
            PopulateErrorList();
            
            alertsBox.Refresh();
        }

        //used to delete node database
        private void deleteNodesDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseIO db = new DatabaseIO();
            db.DeleteRowsDB();
            nodeList.Clear();

            PopulateNodesList();

            nodesBox.Refresh();
        }

        private void addNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Node add = new Add_Node(this);
            add.Show();

        }

        private void deleteNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_Node delete = new Delete_Node(this);
            delete.Show();
        }

        private void alertsBox_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedCellCount =
        alertsBox.GetCellCount(DataGridViewElementStates.Selected);
            DataGridViewRow selectedRow = alertsBox.Rows[alertsBox.CurrentRow.Index];

            Trace.Write(selectedRow.Cells[0].Value.ToString());
            DatabaseIO db = new DatabaseIO();
            db.updateErrorComment(selectedRow.Cells[0].Value.ToString(), selectedRow.Cells[4].Value.ToString());
            Trace.Write("SELCETED CELL = " + selectedCellCount);

            Trace.Write("SELCETED row = " + selectedRow);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (searchTB.Text.Count() > 0)
            {
                searchNodeList = new ObservableCollection<Node>();
                //if (Char.IsLetter(searchTB.Text.First()))
                //{
                if (IpCheck(searchTB.Text.ToString()))
                    {
                    Trace.Write("entered if");
                    for (int i = 0; i < nodeList.Count; i++)
                    {

                        if (nodeList[i].Ip.ToString().Contains(searchTB.Text.ToString()))
                        {
                            searchNodeList.Add(nodeList[i]);
                        }
                        else if (nodeList[i].IpSecondary.ToString().Contains(searchTB.Text.ToString()))
                        {
                            searchNodeList.Add(nodeList[i]);
                        }
                        else if (nodeList[i].IpThird.ToString().Contains(searchTB.Text.ToString()))
                        {
                            searchNodeList.Add(nodeList[i]);
                        }
                        else if (nodeList[i].IpFourth.ToString().Contains(searchTB.Text.ToString()))
                        {
                            searchNodeList.Add(nodeList[i]);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < nodeList.Count; i++)
                    {

                        if (nodeList[i].Hostname.ToLower().Contains(searchTB.Text.ToString().ToLower()))
                        {
                            searchNodeList.Add(nodeList[i]);
                        }
                        if (nodeList[i].Mac.ToLower().Contains(searchTB.Text.ToString().ToLower()))
                        {
                            searchNodeList.Add(nodeList[i]);
                        }
                        if (nodeList[i].MacSecondary.ToLower().Contains(searchTB.Text.ToString().ToLower()))
                        {
                            searchNodeList.Add(nodeList[i]);
                        }
                        if (nodeList[i].MacThird.ToLower().Contains(searchTB.Text.ToString().ToLower()))
                        {
                            searchNodeList.Add(nodeList[i]);
                        }
                        if (nodeList[i].MacFourth.ToLower().Contains(searchTB.Text.ToString().ToLower()))
                        {
                            searchNodeList.Add(nodeList[i]);
                        }
                    }
                }
                nodesBox.DataSource = searchNodeList;
                nodesBox.Refresh();
            }
            else {
                PopulateNodesList();
            }
        }

        private Boolean IpCheck(string ip)
        {
            if (ip.Count() <= 16)
            {
                Trace.Write(ip.Count());
                for (int i = 0; i < ip.Count(); i++)
                {
                    if (ip[i] != '.'&& !char.IsNumber(ip[i]))
                    {
                        Boolean b = ip[i] != '.';
                        Trace.Write("char = " + ip[i] + " result =" + !char.IsNumber(ip[i]));
                        Trace.Write("is char = . = " + ip[i] + " result =" + b);
                        return false;
                    }
                }
                //if (ip[i] == '.' )
                //    {
                //        Trace.Write("char = " + ip[i] + " result =" + !char.IsNumber(ip[i]));
                //    }
                //    else if (char.IsNumber(ip[i]))
                //    {
                //        Trace.Write("is char = . = " + ip[i] + " result =" + b);
                //    }
                //    else
                //    {
                //        Trace.Write("returning flase");
                //        return false;
                //    }
                //}
            }
            else
            {
                Trace.Write("returning else flase");
                return false;
            }
            Trace.Write("returning true");
            return true;
        }

        private void saveNodeListToCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ReadAndWrite rw = new ReadAndWrite(path, "NodeListCSV");
            rw.writeList(nodeList);
            DialogResult result = MessageBox.Show("List Exported to file called NodeListCSV.txt on Desktop", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void saveErrorListToCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ReadAndWrite rw = new ReadAndWrite(path, "ErrorListCSV");
            rw.writeList(errorList);
            DialogResult result = MessageBox.Show("List Exported to file called ErrorListCSV.txt on Desktop", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}