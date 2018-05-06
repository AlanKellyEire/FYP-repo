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

            //Console.WriteLine("\nReading Employee Information");
            set = (Settings)bformatter.Deserialize(stream);
            stream.Close();
            
            loadSettings(set);
        }

        public void loadSettings(Settings settings){

            //ping tab
            pingIntNumField.Value = settings.PingInterval;

            //email server
            subjectTextbox.Text = settings.ServerSettings.Subject;
            mailServerTextbox.Text = settings.ServerSettings.OutGoingMailServer;
            smtpPortNumeric.Value = settings.ServerSettings.Port;
            if (settings.ServerSettings.Tls)
            {
                tlsSslCombobox.SelectedIndex = 0;
            }
            else
            {
                tlsSslCombobox.SelectedIndex = 1;
            }
            usernameTextbox.Text = settings.ServerSettings.Username;
            passwordTextbox.Text = settings.ServerSettings.Password;

            //emails tab
            if (settings.EmailEnabled) {
                emailEnableCheck.Checked = true;
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
            if (settings.LogSettings.LogTypeAll)
            {
                allLogTypeRB.Checked = true;
            }
            else
            {
                errorsLogTypeRB.Checked = true;
            }

        }

        private void saveBut_Click(object sender, EventArgs e)
        {
            saveSerial();
        }

        public void saveSerial()
        {
            if (!ValEmail(emailRepTextbox1.Text.ToString()))
            {
                DialogResult result = MessageBox.Show("Please Enter a Vaild email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ValEmail(emailRepTextbox2.Text.ToString()))
            {
                DialogResult result = MessageBox.Show("Please Enter a Vaild email address for 2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //if (!ValWebsite(mailServerTextbox.Text.ToString()))
            //{
            //    DialogResult result = MessageBox.Show("Please Enter a Vaild website", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            Trace.Write("\n\n\n\n\n\n  test \n\n\n\n\n\n\n");
            Boolean b = false;

            //ping interval
            set.PingInterval = Int32.Parse(pingIntNumField.Value.ToString());

            //email server settings
            set.ServerSettings.Subject = subjectTextbox.Text.ToString();
            set.ServerSettings.OutGoingMailServer = mailServerTextbox.Text.ToString();
            set.ServerSettings.Port = (ushort)smtpPortNumeric.Value;
            if (tlsSslCombobox.Text == "TLS")
            {
                b = true;
            }
            set.ServerSettings.Tls = b;
            set.ServerSettings.Username = usernameTextbox.Text.ToString();
            set.ServerSettings.Password = passwordTextbox.Text.ToString();

            Trace.Write(set.ServerSettings.ToString());

            //logger settings
            b = false;
            set.LogSettings.Path = logPathTextbox.Text.ToString();
            set.LogSettings.Filename = logFileNameTextbox.Text.ToString();
            if (allLogTypeRB.Checked)
            {
                b = true;
            }
            set.LogSettings.LogTypeAll = b;

            set.Emails[0] = emailRepTextbox1.Text.ToString();
            set.Emails[1] = emailRepTextbox2.Text.ToString();
            set.Emails[2] = emailRepTextbox3.Text.ToString();
            set.Emails[3] = emailRepTextbox4.Text.ToString();
            set.Emails[4] = emailRepTextbox5.Text.ToString();

            if (loggerEnableCheck.Checked)
            {
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

        private void testEmailButton_Click(object sender, EventArgs e)
        {
            saveSerial();
            Email em = new Email();
            em.sendTest(set);
        }

        public Boolean ValEmail(string email)
        {
            Validation val = new Validation();
            return val.IsValidEmail(email);
        }

        public Boolean ValWebsite(string website)
        {
            Validation val = new Validation();
            return val.IsValidDomainName(website);
        }

        private void logPathTextbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

 using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);

                    Trace.Write(fbd.SelectedPath);
                    set.LogSettings.Path = fbd.SelectedPath;
                    Trace.Write(set.LogSettings.Path);
                    logPathTextbox.Text = set.LogSettings.Path;
                    //rw.Path = path;
                }
            }
        }
    }
}
