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
    public partial class Form1 : Form
    {
        static CountdownEvent countdown;
        static int upCount = 0;
        static object lockObj = new object();
        const bool resolveNames = true;
        String s;
        String path;
        String netIp = "192.168.0.";

    public Form1()
        {
            InitializeComponent();    
        }


        private void ScanNetwork_Click_1(object sender, EventArgs e)
        {
            if (path != null)
            {
                upCount = 0;
                countdown = new CountdownEvent(1);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                string ipBase = netIp1a.Value.ToString() + "." + netIp1b.Value.ToString() + "." + netIp1c.Value.ToString() + "." + netIp1d.Value.ToString();
                Trace.WriteLine("\nipBase = " + ipBase + "\n");
                DateTime localDate = DateTime.Now;
                var culture = new CultureInfo("en-GB");
                writeToFile(localDate.ToString(culture));

                ipBase = ipBase.Substring(0, (ipBase.LastIndexOf(".")));

                ipBase = ipBase.Substring(0, (ipBase.LastIndexOf(".") + 1));
                Trace.WriteLine("\nipBase = " + ipBase + "\n");
                Trace.WriteLine("\ntemp = " + ipBase + "\n");
                for (int c = 1; c < 255; c++)
                {
                    for (int i = 1; i < 255; i++)
                    {
                        string ip = ipBase + c.ToString() + i.ToString();

                        Ping p = new Ping();
                        p.PingCompleted += new PingCompletedEventHandler(pingCompleted);

                        p.SendAsync(ip, 25, ip);
                        p.Dispose();
                    }
                }
                string message = "Network scan is now complete";
                string caption = "Scan Successful";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                string message = "Please enter a path to save the text file";
                string caption = "No Path";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }


        }

        public void pingCompleted(object sender, PingCompletedEventArgs e)
        {
            string ip = (string)e.UserState;
            if (e.Reply != null && e.Reply.Status == IPStatus.Success)
            {
                lock (lockObj)
                {
                    upCount++;
                }
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
                        name = "?";
                    }
                    //Console.WriteLine("{0} ({1}) is up: ({2} ms)", ip, name, e.Reply.RoundtripTime);
                    writeToFile($"Host {upCount} = {ip} ({name}) is up: ({e.Reply.RoundtripTime} ms)");
                }
                else
                {
                    //Console.WriteLine("{0} is up: ({1} ms)", ip, e.Reply.RoundtripTime);
                    writeToFile($"{ip} is up: ({e.Reply.RoundtripTime} ms)");
                }
            }
            else if (e.Reply == null)
            {
                //Console.WriteLine("Pinging {0} failed. (Null Reply object?)", ip);
                writeToFile($"Pinging {ip} failed. (Null Reply object?)");
            }
            
        }

        public void writeToFile(String word)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@path + "/sample.txt", true))
            {
                file.WriteLine(word);
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

            IPNetwork ipnetwork = IPNetwork.Parse("2001:0db8::/64");

            Trace.Write($"Network : {ipnetwork.Network}");
            Console.WriteLine("Netmask : {0}", ipnetwork.Netmask);
            Console.WriteLine("Broadcast : {0}", ipnetwork.Broadcast);
            Console.WriteLine("FirstUsable : {0}", ipnetwork.FirstUsable);
            Console.WriteLine("LastUsable : {0}", ipnetwork.LastUsable);
            Console.WriteLine("Cidr : {0}", ipnetwork.Cidr);
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
                    path = fbd.SelectedPath;
                    Trace.Write(path);
                    textBox1.Text = path + "\\sample.txt";
                }
            }
            IPNetwork ipnetwork = IPNetwork.Parse("2001:0db8::/64");

            Trace.Write($"Network : {ipnetwork.Network}");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void netIp1b_ValueChanged(object sender, EventArgs e)
        {

        }

        private void netIp1d_ValueChanged(object sender, EventArgs e)
        {

        }

        private void subnet1b_ValueChanged(object sender, EventArgs e)
        {

        }

        private void subnet1d_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    
}
