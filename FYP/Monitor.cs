﻿using System;
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

namespace FYP_10_2_18
{
    public partial class Monitor : Form
    {
        private ObservableCollection<Node> nodeList;
        private ObservableCollection<Error> errorList = new ObservableCollection<Error>();
        private Settings set = new Settings();
        Boolean monitorCompleted = false;

        //private DataGrid alertbox = alertsBox;

        public Monitor()
        {
            InitializeComponent();
            PopulateNodesList();
            PopulateErrorList();
            System.Threading.Thread.Sleep(25);
            timer1.Start();
            new Thread(delegate () {
                Run_Monitor();
            }).Start();
            //Monitor_Thread();
            

        }

        internal ObservableCollection<Node> NodeList { get => nodeList; set => nodeList = value; }

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
            while (true)
            {
                if (!monitorCompleted)
                {
                    monitorCompleted = true;
                    Ping ping = new Ping();

                    foreach (Node n in NodeList)
                    {
                        var reply = await ping.SendPingAsync(n.Ip);
                        if (reply.Status == IPStatus.Success)
                        {

                            Trace.Write(n + " (OK)\n");
                        }
                        else
                        {
                            Trace.Write(n + " (FAILED)\n");
                            addError(n);
                        }
                    }
                    monitorCompleted = false;
                }
            }
            
        }

        private void Monitor_Thread()
        {
            BackgroundWorker bw = new BackgroundWorker();

            // this allows our worker to report progress during work
            bw.WorkerReportsProgress = true;

            // what to do in the background thread
            bw.DoWork += new DoWorkEventHandler(
            delegate (object o, DoWorkEventArgs args)
            {
                BackgroundWorker b = o as BackgroundWorker;

                // do some simple processing for 10 seconds
                //for (int i = 1; i <= 10; i++)
                //    {
                //    // report the progress in percent
                //    b.ReportProgress(i * 10);
                //        Thread.Sleep(1000);
                //    }
                monitor();

            });

            // what to do when progress changed (update the progress bar for example)
            bw.ProgressChanged += new ProgressChangedEventHandler(
            delegate (object o, ProgressChangedEventArgs args)
            {
                label1.Text = string.Format("{0}% Completed", args.ProgressPercentage);
            });

            // what to do when worker completes its task (notify the user)
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
            delegate (object o, RunWorkerCompletedEventArgs args)
            {
                monitorCompleted = false;
            });

            bw.RunWorkerAsync();

            //alertsBox.Refresh();
        }

        private void scanNetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 scanner = new Form1(this);

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

        private void button_Click(object sender, EventArgs e)
        {
            monitor();
        }

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

        private async void monitor()
        {
            Trace.Write(" (asdgfhjk;khgfsdaf)\n");
            Ping ping = new Ping();

            foreach (Node n in NodeList)
            {
                var reply = await ping.SendPingAsync(n.Ip);
                if (reply.Status == IPStatus.Success)
                {

                    Trace.Write(n + " (OK)\n");
                }
                else
                {
                    Trace.Write(n + " (FAILED)\n");
                    addError(n);
                }
            }
        }

        private void addError(Node n)
        {
            DatabaseIO db = new DatabaseIO();

            db.WriteErrorToDB(n);

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            PopulateErrorList();
            alertsBox.DataSource = null;
            alertsBox.DataSource = errorList;
            Trace.Write("Alert grid updated!!\n");

        }

        private void getNodeAlerts(string s)
        {
            DatabaseIO db = new DatabaseIO();
            db.getNodeAlerts(s);

        }

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
                    System.Text.StringBuilder sb =
                        new System.Text.StringBuilder();

                    for (int i = 0;
                        i < selectedCellCount; i++)
                    {
                        getNodeAlerts(nodesBox.SelectedCells[i].RowIndex
                            .ToString());
                        sb.Append("Row: ");
                        sb.Append(nodesBox.SelectedCells[i].RowIndex
                            .ToString());
                        sb.Append(", Column: ");
                        sb.Append(nodesBox.SelectedCells[i].ColumnIndex
                            .ToString());
                        sb.Append(Environment.NewLine);
                    }

                    sb.Append("Total: " + selectedCellCount.ToString());
                    MessageBox.Show(sb.ToString(), "Selected Cells");
                }
            }
        }
    }
}
