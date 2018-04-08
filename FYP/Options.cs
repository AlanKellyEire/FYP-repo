using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
            deserailise();
            this.set = settings;
            //pingIntNumField.Value
        }

        private void cancelBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pingIntNumField_ValueChanged(object sender, EventArgs e)
        {
            //set.PingInterval = Int32.Parse(pingIntNumField.Value.ToString());
        }

        private void serialise()
        {
            Stream stream = File.Open("settingsSerial.osl", FileMode.Create);
            BinaryFormatter bformatter = new BinaryFormatter();

            Console.WriteLine("Writing settings Information");
            bformatter.Serialize(stream, set);
            stream.Close();
        }

        public void deserailise()
        {
            set = null;

            //Open the file written above and read values from it.
            Stream stream = File.Open("settingsSerial.osl", FileMode.Open);
            BinaryFormatter bformatter = new BinaryFormatter();

            Console.WriteLine("\nReading Employee Information");
            set = (Settings)bformatter.Deserialize(stream);
            stream.Close();

            Console.WriteLine("Employee Id: {0}", set.PingInterval.ToString());
            Console.WriteLine("Employee Name: {0}", set.Emails[2].ToString());
            Console.WriteLine("Employee Name: {0}", set.LogSettings.Path);
            Console.WriteLine("Employee enabled: {0}", set.LoggerEnabled);
            loadSettings(set);
        }

        public void loadSettings(Settings settings){

            //ping tab
            pingIntNumField.Value = settings.PingInterval;


            //emails tab
            if (settings.EmailEnabled) {
                emailEnableCheck.Enabled = true;
            }
            emailRepTextbox1.Text = settings.Emails[0];
            emailRepTextbox2.Text = settings.Emails[1];
            emailRepTextbox3.Text = settings.Emails[2];
            emailRepTextbox4.Text = settings.Emails[3];
            emailRepTextbox5.Text = settings.Emails[4];

            //logger tab
            if (settings.LoggerEnabled)
            {
                loggerEnableCheck.Checked = true;
            }
            logPathTextbox.Text = settings.LogSettings.Path;
            logFileNameTextbox.Text = settings.LogSettings.Filename;
            //log
            if (settings.LogSettings.LogType)
            {
                loggerEnableCheck.Enabled = true;
            }

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

            if (loggerEnableCheck.Checked) {
                set.LoggerEnabled = true;
            }
            else
            {
                set.LoggerEnabled = false;
            }

            if (emailEnableCheck.Checked)
            {
                set.EmailEnabled = true;
            }
            else
            {
                set.EmailEnabled = false;
            }
            serialise();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
