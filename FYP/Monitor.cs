using System;
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

namespace FYP_10_2_18
{
    public partial class Monitor : Form
    {
        private ObservableCollection<Node> nodeList;
        private ObservableCollection<Error> errorList = new ObservableCollection<Error>();
        private Settings set = new Settings();

        public Monitor()
        {
            InitializeComponent();
            PopulateNodesList();
            PopulateErrorList();
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

        private void loadFromDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopulateNodesList();
            PopulateErrorList();
        }

        private void deleteDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseIO db = new DatabaseIO();

            db.DeleteRowsDB();
            db.DeleteErrorsDB();
        }

        private void scanNetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 scanner = new Form1();

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

        private void Defeat()
        {
            //MessageBox.Show("Goodbye");
            DialogResult result = MessageBox.Show("Do you want to save the data before exiting?", "Warning",
MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
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

        private async void monitor(object sender, EventArgs e)
        {
            
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
    }
}
