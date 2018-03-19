using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYP_10_2_18
{
    public partial class Monitor : Form
    {
        private ObservableCollection<Node> nodeList;
        private ObservableCollection<Error> errorList = new ObservableCollection<Error>();

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


    }
}
