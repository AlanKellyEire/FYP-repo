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
        String ipBase;
        String sub;

        public Form1()
        {
            InitializeComponent();
        }


        private void ScanNetwork_Click_1(object sender, EventArgs e)
        {
            AlertClass aC = new AlertClass();
            if (path != null)
            {
                upCount = 0;
                countdown = new CountdownEvent(1);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                aC.alert("what a load of crappy crap", "testing");
                ipBase = netIp1a.Value.ToString() + "." + netIp1b.Value.ToString() + "." + netIp1c.Value.ToString() + "." + netIp1d.Value.ToString();
                sub = subnet1a.Value.ToString() + "." + subnet1b.Value.ToString() + "." + subnet1c.Value.ToString() + "." + subnet1d.Value.ToString();
                Trace.WriteLine("\nipBase = " + ipBase + "\n");
                DateTime localDate = DateTime.Now;
                var culture = new CultureInfo("en-GB");
                writeToFile(localDate.ToString(culture));
                
                
                Trace.WriteLine("\nipBase = " + ipBase + "\n");
                Trace.WriteLine("\ntemp = " + ipBase + "\n");
                //getSubnet();
                if (cidr.Value != 24)
                {
                    ipBase = ipBase.Substring(0, (ipBase.LastIndexOf(".")));
                    ipBase = ipBase.Substring(0, (ipBase.LastIndexOf(".") + 1));
                    Trace.WriteLine("\nipBase = " + ipBase + "\n");
                    for (int c = 1; c < 255; c++)
                    {

                        for (int i = 1; i < 255; i++)
                        {
                            string ip = ipBase + c.ToString() + "." + i.ToString();
                            //string ip = ipBase + i.ToString();
                            Ping p = new Ping();
                            p.PingCompleted += new PingCompletedEventHandler(pingCompleted);
                            countdown.AddCount();
                            //Trace.WriteLine("\n IP = " + ip + "\n");
                            p.SendAsync(ip, 50, ip);
                            p.Dispose();
                        }
                    }
                }
                else
                {

                    ipBase = ipBase.Substring(0, (ipBase.LastIndexOf(".")));
                    Trace.WriteLine("\nipBase = " + ipBase + "\n");

                    for (int i = 1; i < 255; i++)
                    {
                        string ip = ipBase + "." + i.ToString();
                        //string ip = ipBase + i.ToString();
                        Ping p = new Ping();
                        p.PingCompleted += new PingCompletedEventHandler(pingCompleted);
                        //Trace.WriteLine("\n IP = " + ip + "\n");
                        p.SendAsync(ip, 100, ip);
                        //p.Dispose();
                    }
                }
                countdown.Signal();
            countdown.Wait();
            sw.Stop();
                aC.alert("Network scan is now complete", "Scan Successful");
            }
            else
            {
                aC.alert("Please enter a path to save the text file", "No Path");
            }


        }

        public void pingCompleted(object sender, PingCompletedEventArgs e)
        {
            sender.GetType();
            Ping p = ((Ping) sender);
            p.Dispose();
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
                        name = Get_Mac_Address(ip);
                        //name = "?";
                    }
                    Console.WriteLine("{0} ({1}) is up: ({2} ms)", ip, name, e.Reply.RoundtripTime);
                    //writeToFile($"Host {upCount} = {ip} ({name}) is up: ({e.Reply.RoundtripTime} ms)");
                }
                else
                {
                    Console.WriteLine("{0} is up: ({1} ms)", ip, e.Reply.RoundtripTime);
                    //writeToFile($"{ip} is up: ({e.Reply.RoundtripTime} ms)");
                }
            }
            else if (e.Reply == null)
            {
                Console.WriteLine("Pinging {0} failed. (Null Reply object?)", ip);
                //writeToFile($"Pinging {ip} failed. (Null Reply object?)");
            }
            p.Dispose();
            countdown.Signal();
        }

        public String getSubnet()
        {
            Trace.WriteLine("\nstring c = " + ipBase + "\n");
            ipBase = "192.168.0.1/" + cidr.Value.ToString();
            Trace.WriteLine("\nstring c = " + ipBase + "\n");
            IPNetwork ipnetwork = IPNetwork.Parse(ipBase);

            convertToMask(ipnetwork.Netmask.ToString());

            Console.WriteLine("FirstUsable : {0}", ipnetwork.FirstUsable);
            Console.WriteLine("LastUsable : {0}", ipnetwork.LastUsable);

            return "sfs";

        }

        public String[] convertToMask(String s)
        {

            String[] c = new string[4];
            s = dotAt(s);
            c[3] = s;
            s = s.Substring(0, (s.LastIndexOf(".")));
            c[2] = s;
            s = s.Substring(0, (s.LastIndexOf(".")));
            c[1] = s;
            s = s.Substring(0, (s.LastIndexOf(".")));
            c[0] = s;
            Trace.WriteLine("\nstring c = " + c + "\n");
            foreach (var i in c)
            {
                Trace.WriteLine(i.ToString());
            }
            return c;
        }

        public String dotAt(String s)
        {
            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] == '.')
                {
                    return s.Substring(s.Length - (i-1));
                }
            }
            return "Wrong fool";
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
            //IPNetwork ipnetwork = IPNetwork.Parse("2001:0db8::/64");

            //Trace.Write($"Network : {ipnetwork.Network}");
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

        public String Get_Mac_Address(String ipAddress)
    {
        String macAddress = string.Empty;
        System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
        pProcess.StartInfo.FileName = "arp";
        pProcess.StartInfo.Arguments = "-a " + ipAddress;
        pProcess.StartInfo.UseShellExecute = false;
        pProcess.StartInfo.RedirectStandardOutput = true;
        pProcess.StartInfo.CreateNoWindow = true;
        pProcess.Start();
        String strOutput = pProcess.StandardOutput.ReadToEnd();
        String[] substrings = strOutput.Split('-');
        if (substrings.Length >= 8)
        {
            macAddress = substrings[3].Substring(Math.Max(0, substrings[3].Length - 2))
                     + "-" + substrings[4] + "-" + substrings[5] + "-" + substrings[6]
                     + "-" + substrings[7] + "-"
                     + substrings[8].Substring(0, 2);
            return macAddress;
        }

        else
        {
            return "not found";
        }
    }

        private void cidr_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Subnet sub = new Subnet();
            IPNetwork ipnetwork = IPNetwork.Parse("192.168.0.0/24");
           
            Trace.Write($"Network : {ipnetwork.Netmask}");

            sub.convertToMask("192.168.0.1");
        }
    }

    
}

