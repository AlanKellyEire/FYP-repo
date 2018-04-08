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
    public partial class Options : Form
    {
        private Settings set;

        public Options(Settings settings)
        {
            InitializeComponent();
            this.set = settings;
        }

        private void cancelBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pingIntNumField_ValueChanged(object sender, EventArgs e)
        {
            //set.PingInterval = Int32.Parse(pingIntNumField.Value.ToString());
        }

        private void saveBut_Click(object sender, EventArgs e)
        {
            Boolean b = false;

            Trace.Write("ping interval = "  + set.PingInterval);
            set.PingInterval = Int32.Parse(pingIntNumField.Value.ToString());
            Trace.Write("ping interval = " + set.PingInterval);

            set.ServerSettings.Subject = subjectTextbox.Text.ToString();
            set.ServerSettings.OutGoingMailServer = mailServerTextbox.Text.ToString();
            set.ServerSettings.Port = (ushort)smtpPortNumeric.Value;
            if(tlsSslCombobox.Text == "TLS")
            {
                b = true;
            }
            set.ServerSettings.Tls = b;
            set.ServerSettings.Username = usernameTextbox.Text.ToString();
            set.ServerSettings.Password = passwordTextbox.Text.ToString();

            Trace.Write(set.ServerSettings.ToString());
            b = false;
            set.LogSettings.Path = logPathTextbox.Text.ToString();
            set.LogSettings.Filename = logFileNameTextbox.Text.ToString();
            if (allLogTypeRB.Enabled)
            {
                b = true;
            }
            set.LogSettings.LogType = b;

            set.Emails[0] = emailRepTextbox1.Text.ToString();
            set.Emails[1] = emailRepTextbox2.Text.ToString();
            set.Emails[2] = emailRepTextbox3.Text.ToString();
            set.Emails[3] = emailRepTextbox4.Text.ToString();
            set.Emails[4] = emailRepTextbox5.Text.ToString();

            if (loggerEnableRB.Enabled) {
                set.LoggerEnabled = true;
            }
            else
            {
                set.LoggerEnabled = false;
            }

            if (emailRB.Enabled)
            {
                set.EmailEnabled = true;
            }
            else
            {
                set.EmailEnabled = false;
            }
        }
    }
}
