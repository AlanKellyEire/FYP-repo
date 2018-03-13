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
using System.Collections.ObjectModel;
using Finisar.SQLite;

namespace FYP_10_2_18
{
    public partial class Form1 : Form
    {
        ObservableCollection<Node> list = new ObservableCollection<Node>();
        static CountdownEvent countdown;
        static int upCount = 0;
        static object lockObj = new object();
        const bool resolveNames = true;
        private bool scanSecondNet = false;
        private bool scanThirdNet = false;


        String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        
        String filename = "IpScanLog.txt";
        String ipBase;
        String sub;
        ReadAndWrite rw;


        public Form1()
        {
            InitializeComponent();
            filePath.Text = path + "\\IpScanLog.txt";
        }

        private void ScanNetwork_Click_1(object sender, EventArgs e)
        {
            AlertClass aC = new AlertClass();
            rw = new ReadAndWrite(path, filename);

                upCount = 1;
                //aC.alert("what a load of crappy crap", "testing");
                ipBase = netIp1a.Value.ToString() + "." + netIp1b.Value.ToString() + "." + netIp1c.Value.ToString() + "." + netIp1d.Value.ToString();
                sub = subnet1a.Value.ToString() + "." + subnet1b.Value.ToString() + "." + subnet1c.Value.ToString() + "." + subnet1d.Value.ToString();
            
            //writing starttime to file;
            rw.writeTime();
            scanNetwork(ipBase, cidr1.Text);
                if (scanSecondNet)
                {
                ipBase = netIp2a.Value.ToString() + "." + netIp2b.Value.ToString() + "." + netIp2c.Value.ToString() + "." + netIp2d.Value.ToString();
                scanNetwork(ipBase, cidr2.Text);
            }
            if (scanThirdNet)
            {
                ipBase = netIp3a.Value.ToString() + "." + netIp3b.Value.ToString() + "." + netIp3c.Value.ToString() + "." + netIp3d.Value.ToString();
                scanNetwork(ipBase, cidr3.Text);
            }
            else
                {
                ipScan24(ipBase);
                }
                
                DialogResult result2 = MessageBox.Show("Network scan is now complete", "Scan Successful", MessageBoxButtons.OK, MessageBoxIcon.Question);

                //write list to file
                rw.writeList(list, path, filename);
                //writing finish time to file
                rw.writeTime();
            

            //this.dataGridView1.ItemsSource = list;
            dataGridView1.DataSource = list;
        }

        public void ipScan24(String ipNet)
        {
            ipNet = ipNet.Substring(0, (ipNet.LastIndexOf(".")));
            //Trace.WriteLine("\n entered /24 ipBase = " + ipBase + "\n");

            for (int i = 1; i < 255; i++)
            {
                string ip = ipNet + "." + i.ToString();
                //string ip = ipBase + i.ToString();
                Ping p = new Ping();
                p.PingCompleted += new PingCompletedEventHandler(pingCompleted);
                //countdown.AddCount();
                //Trace.WriteLine("\n IP = " + ip + "\n");
                p.SendAsync(ip, 50, ip);
                p.Dispose();
            }
        }

        public void ipScan16(String ipNet)
        {
            ipNet = ipNet.Substring(0, (ipBase.LastIndexOf(".")));
            ipNet = ipBase.Substring(0, (ipBase.LastIndexOf(".") + 1));
            //Trace.WriteLine("\nipBase = " + ipBase + "\n");
            for (int c = 1; c < 255; c++)
            {
                System.Threading.Thread.Sleep(25);
                for (int i = 1; i < 255; i++)
                {
                    string ip = ipBase + c.ToString() + "." + i.ToString();
                    //string ip = ipBase + i.ToString();
                    Ping p = new Ping();
                    p.PingCompleted += new PingCompletedEventHandler(pingCompleted);
                    //countdown.AddCount();
                    //Trace.WriteLine("\n IP = " + ip + "\n");
                    p.SendAsync(ip, 50, ip);
                    p.Dispose();
                }
            }
        }

        public void scanNetwork(String ipNet, String cidr)
        {
            if (cidr != "/24")
            {
                Trace.WriteLine("\n/16 IP = \n");
                Trace.WriteLine("\n IP = " + ipNet + cidr + "\n");
                ipScan16(ipNet);
            }
            else
            {
                Trace.WriteLine("\n/24 IP = \n");
                Trace.WriteLine("\n IP = " + ipNet + cidr + "\n");
                ipScan24(ipNet);
            }
        }

        public void pingCompleted(object sender, PingCompletedEventArgs e)
        {
            string ip = (string)e.UserState;
            if (e.Reply != null && e.Reply.Status == IPStatus.Success)
            {
                if (resolveNames)
                {
                    string name;
                    string mac;
                    try
                    {
                        IPHostEntry hostEntry = Dns.GetHostEntry(ip);
                        name = hostEntry.HostName;
                    }
                    catch (SocketException ex)
                    {
                        name = "?";
                    }
                    mac = Get_Mac_Address(ip);
                    Node node = new Node(upCount, name, ip, mac);
                    list.Add(node);
                    Trace.WriteLine($"Host {upCount} = {ip} ({name}) is up: ({e.Reply.RoundtripTime} ms)");
                    //Console.WriteLine("{0} ({1}) is up: ({2} ms)", ip, name, e.Reply.RoundtripTime);
                    //writeToFile($"Host {upCount} = {ip} ({name}) is up: ({e.Reply.RoundtripTime} ms)");
                }
                else
                {
                    //Console.WriteLine("{0} is up: ({1} ms)", ip, e.Reply.RoundtripTime);
                    //writeToFile($"{ip} is up: ({e.Reply.RoundtripTime} ms)");
                }
                lock (lockObj)
                {
                    upCount++;
                }
            }
        }

        private void active_Scan_button(object sender, EventArgs e)
        {
            if (sender == netIp1a || sender == netIp1b || sender == netIp1c || sender == netIp1d || cidr1 == sender)
            {
                
                scanNet1.Enabled = true;
                enable_2nd_Network();
            }
            else if(sender == netIp2a || sender == netIp2b || sender == netIp2c || sender == netIp2d || cidr2 == sender)
                {
                    scanSecondNet = true;
                    enable_3rd_Network();
                }
            else
            {
                scanThirdNet = true;
            }
        }

        private void enable_2nd_Network()
        {
            netIp2a.Enabled = true;
            netIp2b.Enabled = true;
            netIp2c.Enabled = true;
            netIp2d.Enabled = true;
            cidr2.Enabled = true;

        }

        private void enable_3rd_Network()
        {
            netIp3a.Enabled = true;
            netIp3b.Enabled = true;
            netIp3c.Enabled = true;
            netIp3d.Enabled = true;
            cidr3.Enabled = true;

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
                    filePath.Text = path + "\\IpScanLog.txt";
                    rw.Path = path;
                }
            }
            //IPNetwork ipnetwork = IPNetwork.Parse("2001:0db8::/64");

            //Trace.Write($"Network : {ipnetwork.Network}");
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
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cidr1.ValueMember.ToString() != "/24")
            {
                subnet1c.Value = 0;
            }
        }

        private void pop_but_Click(object sender, EventArgs e)
        {
            List<string> dblist = new List<string>();
            using (var db = new mainEntities())
            {
                dblist = (from g in db.NodesTables select g.Hostname).ToList();
                db.Dispose();
            }
            foreach(string str in dblist)
            {
                listView1.Items.Add(str);
            }
        }
       
    }

    
}

