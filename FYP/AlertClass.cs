using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using System.Globalization;

namespace FYP_10_2_18
{
    class AlertClass
    {
        
        public AlertClass()
        {

        }


        public void alert(String s, String s2)
        {
            DialogResult result2 = MessageBox.Show(s, s2, MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
