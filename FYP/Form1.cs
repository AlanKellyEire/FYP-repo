using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Net.Sockets;

namespace FYP_10_2_18
{
    public partial class Form1 : Form
    {
        static int upCount = 0;
        const bool resolveNames = true;
        String s;
        String netIp = "192.168.0.";

    public Form1()
        {
            InitializeComponent();    
        }


        public void pingCompleted(object sender, PingCompletedEventArgs e)
        {
            
            string ip = (string)e.UserState;
            if (e.Reply != null && e.Reply.Status == IPStatus.Success)
            {
                    upCount++;
                
                if (resolveNames)
                {
                    string name;
                    try
                    {
                        IPHostEntry hostEntry = Dns.GetHostEntry(ip);
                        name = hostEntry.HostName;
                    }
                    catch (SocketException ex)
                    {
                        name = "Unknown Host Name";
                    }
                    s = $"host {upCount}: {ip} ({name}) is up: ({e.Reply.RoundtripTime} ms)";
                    writeToFile(s);
                }
                else
                {
                    s = $"{ip} is up: ({e.Reply.RoundtripTime} ms))";
                    writeToFile(s);
                }
            }
            else if (e.Reply == null)
            {
                s = $"Pinging {ip} failed. (Null Reply object?)";
                writeToFile(s);
            }
        }

        public void writeToFile(String word)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Grim\fyptestnw.txt", true))
            {
                file.WriteLine(word);
            }
        }
        
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
                netIp = tbox.Text.Substring(0, (tbox.Text.LastIndexOf(".") + 1));
            }
            if (zeros == 2)
            {
                netIp = tbox.Text.Substring(0, (tbox.Text.LastIndexOf(".") + 1));
            }

        }

        private void ScanNetwork_Click_1(object sender, EventArgs e)
        {


            string ipBase = netIp1a.Value.ToString() + "." + netIp1b.Value.ToString() + "." + netIp1c.Value.ToString() + "." + netIp1d.Value.ToString();
            //ipBase = ipBase.Substring(0, (ipBase.LastIndexOf(".") + 1));

            if(subnet1d.Value == 0)
            {
                if(subnet1c.Value == 0)
                {
                    if (subnet1a.Value == 255)
                    {

                        ipBase = ipBase.Substring(0, (ipBase.LastIndexOf(".")));

                        ipBase = ipBase.Substring(0, (ipBase.LastIndexOf(".") + 1));
                        
                        for (int i = 1; i < 255; i++)
                        {
                            for (int f = 1; f < 255; f++)
                            {
                                string ip = ipBase + i.ToString() + "." + f.ToString();

                                Ping p = new Ping();
                                p.PingCompleted += new PingCompletedEventHandler(pingCompleted);
                                p.SendAsync(ip, ip);
                                
                            }
                        }
                    }
                }
                else if (subnet1c.Value == 255)
                {
                    if (subnet1b.Value == 255)
                    {
                        if (subnet1a.Value == 255)
                        {
                            ipBase = ipBase.Substring(0, (ipBase.LastIndexOf(".") + 1));
                            for (int i = 1; i < 255; i++)
                            {
                                string ip = ipBase + i.ToString();

                                Ping p = new Ping();
                                p.PingCompleted += new PingCompletedEventHandler(pingCompleted);
                                p.SendAsync(ip, 100, ip);
                            }
                        }
                    }
                }
            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void network1_TextChanged(object sender, EventArgs e)
        {
            //netIp = network1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void network2_TextChanged(object sender, EventArgs e)
        {

        }

        private void network3_TextChanged(object sender, EventArgs e)
        {

        }

        private void network4_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
    
}
