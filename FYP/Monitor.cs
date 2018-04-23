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

            for(int i = 0; i < alertsBox.ColumnCount; i++)
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
            
                if (!monitorCompleted && !ScannerEnabled)
                {
                    Trace.Write("running monitor \n");
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
                            }
                            else
                            {
                                Trace.Write(n.Hostname + ", " + n.Ip + " (FAILED)\n");
                                addError(n, 1);
                                n.MonitorEnabled = false;
                            }
                            if (n.IpSecondary.Length > 1)
                            {
                                var replySec = await ping.SendPingAsync(n.IpSecondary);
                                if (replySec.Status == IPStatus.Success)
                                {

                                    Trace.Write(n.Hostname + ", " + n.IpSecondary + " (OK)\n");
                                }
                                else
                                {
                                    Trace.Write(n.Hostname + ", " + n.IpSecondary + " (FAILED)\n");
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
                                }
                                else
                                {
                                    Trace.Write(n.Hostname + ", " + n.IpThird + " (FAILED)\n");
                                    addError(n, 3);
                                    n.MonitorEnabled = false;
                                }
                            }
                            if (n.IpSecondary.Length > 1)
                            {
                                var replyFourth = await ping.SendPingAsync(n.IpFourth);
                                if (replyFourth.Status == IPStatus.Success)
                                {

                                    Trace.Write(n.Hostname + ", " + n.IpFourth + " (OK)\n");
                                }
                                else
                                {
                                    Trace.Write(n.Hostname + ", " + n.IpFourth + " (FAILED)\n");
                                    addError(n, 4);
                                    n.MonitorEnabled = false;
                                }
                            }
                        }
                    }
                    monitorCompleted = false;
                }
            
            
        }

        private ObservableCollection<Error> SortList(ObservableCollection<Error> list)
        {
            ObservableCollection<Error> tempList = new ObservableCollection<Error>();

            for(int i = 1; i < list.Count; i++)
            {
                tempList.Add(list[list.Count - i]);
            }

            return tempList;
        }

        //private void Monitor_Thread()
        //{
        //    BackgroundWorker bw = new BackgroundWorker();

        //    // this allows our worker to report progress during work
        //    bw.WorkerReportsProgress = true;

        //    // what to do in the background thread
        //    bw.DoWork += new DoWorkEventHandler(
        //    delegate (object o, DoWorkEventArgs args)
        //    {
        //        BackgroundWorker b = o as BackgroundWorker;
        //        monitor();

        //    });

        //    // what to do when progress changed (update the progress bar for example)
        //    bw.ProgressChanged += new ProgressChangedEventHandler(
        //    delegate (object o, ProgressChangedEventArgs args)
        //    {
        //        label1.Text = string.Format("{0}% Completed", args.ProgressPercentage);
        //    });

        //    // what to do when worker completes its task (notify the user)
        //    bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
        //    delegate (object o, RunWorkerCompletedEventArgs args)
        //    {
        //        monitorCompleted = false;
        //    });

        //    bw.RunWorkerAsync();
        //}

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
            new Thread(delegate () {
                Run_Monitor();
            }).Start();
        }

        //populates the nodeerrorbox
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
            if(nodeErrorsLB.Text != "")
            {
                for(int i = 0; i<nodeList.Count; i++)
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
            
            PopulateErrorList();
            
            alertsBox.Refresh();
        }

        //used to delete node database
        private void deleteNodesDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseIO db = new DatabaseIO();
            db.DeleteRowsDB();


            PopulateNodesList();

            nodesBox.Refresh();
        }

        private void addNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Node add = new Add_Node(this);
            add.Show();

        }
    }
}