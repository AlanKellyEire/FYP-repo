using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYP_10_2_18
{
    public partial class Add_Node : Form
    {
        private Monitor sender;

        public Add_Node(Monitor send)
        {
            this.sender = send;
            InitializeComponent();
        }

        private void addNodeBT_Click(object sender, EventArgs e)
        {
            if (hostTB.TextLength < 1 || macTB.TextLength < 12)
            {
                MessageBox.Show("Invalid hostname or Mac address.\n nodes must contain at least a Hostname, IP and Mac", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Node n = new Node();
            n.Hostname = hostTB.Text;
            n.Ip = netIp1a.Value.ToString() + "." + netIp1b.Value.ToString() + "." + netIp1c.Value.ToString() + "." + netIp1d.Value.ToString();
            n.Mac = macTB.Text;

            string ipSec = netIp2a.Value.ToString() + "." + netIp2b.Value.ToString() + "." + netIp2c.Value.ToString() + "." + netIp2d.Value.ToString();
            string macSec = macSecTB.Text;
            if (ipSec != "0.0.0.0" && macSec.Length >= 12)
            {
                n.IpSecondary = ipSec;
                n.MacSecondary = macSec;
            }

            string ipThird = netIp3a.Value.ToString() + "." + netIp3b.Value.ToString() + "." + netIp3c.Value.ToString() + "." + netIp3d.Value.ToString();
            string macThird = macThirdTB.Text;
            if (ipThird != "0.0.0.0" && macThird.Length >= 12)
            {
                n.IpThird = ipSec;
                n.MacThird = macThird;
            }

            string ipFourth = netIp4a.Value.ToString() + "." + netIp4b.Value.ToString() + "." + netIp4c.Value.ToString() + "." + netIp4d.Value.ToString();
            string macFourth = macFourthTB.Text;
            if (macFourth != "0.0.0.0" && macTB.TextLength < 1)
            {
                n.IpFourth = ipSec;
                n.MacFourth = macFourth;
            }
            AddNode(n);
            this.sender.PopulateNodesList();
        }

        private void AddNode(Node n)
        {
            DatabaseIO db = new DatabaseIO();
            db.addNodeToDB(n);


        }
    }
}
