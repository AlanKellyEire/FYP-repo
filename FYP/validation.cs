using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FYP_10_2_18
{
    class Validation
    {
        //validates email address
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        //checks if email server iput is valid
        public bool IsValidDomainName(string name)
        {
            return Uri.CheckHostName(name) != UriHostNameType.Unknown;
        }

        public bool ValidSMTP(string hostName)
        {
            bool valid = false;
            try
            {
                TcpClient smtpTest = new TcpClient();
                smtpTest.Connect(hostName, 25);
                if (smtpTest.Connected)
                {
                    NetworkStream ns = smtpTest.GetStream();
                    StreamReader sr = new StreamReader(ns);
                    if (sr.ReadLine().Contains("220"))
                    {
                        valid = true;
                    }
                    smtpTest.Close();
                }
            }
            catch
            {

            }
            return valid;
        }

        /*
        private void ValIp(TextBox tbox)
        {

            // Checks the value of the text.
            int count = tbox.Text.Count(f => f == '.');
            if (count != 3)
            {

                // Initializes the variables to pass to the MessageBox.Show method.

                string message = "you have not enetered a correct IP address. Please reenter IP address";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.No)
                {

                    // Closes the parent form.
                    this.Close();

                }

            }

        }
        
        private void ValSubnet(TextBox tbox)
        {

            // Checks the value of the text.
            int count = tbox.Text.Count(f => f == '.');
            int zeros = tbox.Text.Count(f => f == '0');
            if (count != 3)
            {

                // Initializes the variables to pass to the MessageBox.Show method.

                string message = "you have not enetered a correct subnet address. Please reenter Subnet";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.No)
                {
                    // Closes the parent form.
                    this.Close();

                }

            }
            if (zeros == 1)
            {
                ipBase = tbox.Text.Substring(0, (tbox.Text.LastIndexOf(".") + 1));
            }
            if (zeros == 2)
            {
                ipBase = tbox.Text.Substring(0, (tbox.Text.LastIndexOf(".") + 1));
            }

            //IPNetwork ipnetwork = IPNetwork.Parse("2001:0db8::/64");

            //Trace.Write($"Network : {ipnetwork.Network}");
            //Console.WriteLine("Netmask : {0}", ipnetwork.Netmask);
            //Console.WriteLine("Broadcast : {0}", ipnetwork.Broadcast);
            //Console.WriteLine("FirstUsable : {0}", ipnetwork.FirstUsable);
            //Console.WriteLine("LastUsable : {0}", ipnetwork.LastUsable);
            //Console.WriteLine("Cidr : {0}", ipnetwork.Cidr);
        }
        */
    }
}
