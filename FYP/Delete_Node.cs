using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYP_10_2_18
{
    public partial class Delete_Node : Form
    {

        private Monitor sender;

        public Delete_Node(Monitor send)
        {
            this.sender = send;
            InitializeComponent();
        }

        private void deleteBut_Click(object sender, EventArgs e)
        {
            DatabaseIO db = new DatabaseIO();
            db.DeleteNode(hostnameToDeleteTB.Text.ToString());
            this.sender.PopulateNodesList();
            Trace.Write("node deleted");
        }

        private void cancelBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
