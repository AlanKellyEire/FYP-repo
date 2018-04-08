using System;
using System.IO;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace FYP_10_2_18
{
    public partial class Form1 : Form
    {
        private ObservableCollection<Node> list = new ObservableCollection<Node>();
        static CountdownEvent countdown;
        static int upCount = 0;
        static object lockObj = new object();
        const bool resolveNames = true;


        String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        String filename = "IpScanLog.txt";
        String ipBase;
        String sub;
        ReadAndWrite rw;

        internal ObservableCollection<Node> List { get => list; set => list = value; }

        public Form1()
        {
            InitializeComponent();
            filePath.Text = path + "\\IpScanLog.txt";
        }

        //scan network button click
        private void ScanNetworkClick(object sender, EventArgs e)
        {
                rw = new ReadAndWrite(path, filename);

                upCount = 1;
                ipBase = netIp1a.Value.ToString() + "." + netIp1b.Value.ToString() + "." + netIp1c.Value.ToString() + "." + netIp1d.Value.ToString();
                sub = subnet1a.Value.ToString() + "." + subnet1b.Value.ToString() + "." + subnet1c.Value.ToString() + "." + subnet1d.Value.ToString();

                //writing starttime to file;
                rw.writeTime();
                //testing what networks are selected to scan
                if (En_IP_Net_1.Checked)
                {
                    ipBase = netIp1a.Value.ToString() + "." + netIp1b.Value.ToString() + "." + netIp1c.Value.ToString() + "." + netIp1d.Value.ToString();
                    ScanNetwork(ipBase, cidr1.Text, Int32.Parse(netIp1b.Value.ToString()));
                }
                if (En_IP_Net_2.Checked)
                {
                    ipBase = netIp2a.Value.ToString() + "." + netIp2b.Value.ToString() + "." + netIp2c.Value.ToString() + "." + netIp2d.Value.ToString();
                    ScanNetwork(ipBase, cidr2.Text, Int32.Parse(netIp2b.Value.ToString()));
                }
                if (En_IP_Net_3.Checked)
                {
                    ipBase = netIp3a.Value.ToString() + "." + netIp3b.Value.ToString() + "." + netIp3c.Value.ToString() + "." + netIp3d.Value.ToString();
                    ScanNetwork(ipBase, cidr3.Text, Int32.Parse(netIp3b.Value.ToString()));
                }

                //prompt window telling user that scan is complete
                DialogResult result2 = MessageBox.Show("Network scan is now complete", "Scan Successful", MessageBoxButtons.OK, MessageBoxIcon.Question);

                //write list to file
                rw.writeList(List, path, filename);
                //writing finish time to file
                rw.writeTime();


                //this.dataGridView1.ItemsSource = list;
                dataGridView1.DataSource = List;
                //refreshes datagridview so it can be updated with recently added nodes
                dataGridView1.Refresh();

        }

        //function to scan a /24 network
        public void IpScan24(String ipNet)
        {
            //gets the first 24 bits of the ip address
            ipNet = ipNet.Substring(0, (ipNet.LastIndexOf(".")));

            //loops thruogh all the ip addresses in the range
            rw.writeToFile("\nipBase = " + ipBase + "\n");
            for (int i = 1; i < 255; i++)
            {
                string ip = ipNet + "." + i.ToString();

                Ping p = new Ping();
                p.PingCompleted += new PingCompletedEventHandler(pingCompleted);
                
                //sends ping
                p.SendAsync(ip, 50, ip);
                p.Dispose();
            }
        }

        ////function to scan a /15 network
        //public void IpScan15(String ipNet)
        //{
        //    //gets the first 15 bits of the ip address
        //    ipNet = ipNet.Substring(0, (ipNet.LastIndexOf(".")));
        //    ipNet = ipNet.Substring(0, (ipNet.LastIndexOf(".")+1));

        //    for (int c = 1; c < 255; c++)
        //    {
        //        //waits 25ms before each network scan to prevent out of memory exception
        //        System.Threading.Thread.Sleep(25);
        //        for (int i = 1; i < 255; i++)
        //        {
                    
        //            string ip = ipNet + c.ToString() + "." + i.ToString();
        //            Ping p = new Ping();
        //            p.PingCompleted += new PingCompletedEventHandler(pingCompleted);

        //            p.SendAsync(ip, 50, ip);
        //            p.Dispose();
        //        }
        //    }
        //}

        //function to scan a /16 network also used to scan a /15 network
        public void IpScan16(String ipNet)
        {
            
            for (int c = 1; c < 255; c++)
            {
                //waits 25ms before each network scan to prevent out of memory exception
                System.Threading.Thread.Sleep(25);
                for (int i = 1; i < 255; i++)
                {

                    string ip = ipNet + c.ToString() + "." + i.ToString();
                    Ping p = new Ping();
                    p.PingCompleted += new PingCompletedEventHandler(pingCompleted);
                    p.SendAsync(ip, 50, ip);
                    p.Dispose();
                }
            }
        }

        //function used to identify the network type.
        public void ScanNetwork(String ipNet, String cidr, int secOct)
        {
            //uses the cidr notation to identy what network size it is and scans it
            if (cidr == "/24")
            {
                IpScan24(ipNet);
            }
            else if (cidr == "/15")
            {
                //used to scan a /15 address
                //gets the first 15 bits of the IP address
                ipNet = ipNet.Substring(0, (ipNet.LastIndexOf(".")));
                ipNet = ipNet.Substring(0, (ipNet.LastIndexOf(".")));
                ipNet = ipNet.Substring(0, (ipNet.LastIndexOf(".") + 1));
                ipNet += secOct + ".";
                rw.writeToFile("\ntest    === = = = " + ipNet + "\n");
                //scans the first /16 address in teh /15 address
                IpScan16(ipNet);
                ipNet = ipNet.Substring(0, (ipNet.LastIndexOf(".")));
                ipNet = ipNet.Substring(0, (ipNet.LastIndexOf(".") + 1));
                ipNet += (secOct+1) + ".";
                rw.writeToFile("\ntest    === = = = " + ipNet + "\n");
                //scans the first /16 address in teh /15 address
                IpScan16(ipNet);
            }
            else
            {
                //scans a single /16 address
                ipNet = ipNet.Substring(0, (ipNet.LastIndexOf(".")));
                ipNet = ipNet.Substring(0, (ipNet.LastIndexOf(".")));
                ipNet = ipNet.Substring(0, (ipNet.LastIndexOf(".") + 1));
                ipNet += secOct + ".";
                IpScan16(ipNet);
            }
        }

        //function used to test if Node is active
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
                        //if node has no domain name it gives it the name ?
                        name = "?";
                    }
                    //calls mac address resolution function to get mac address of Node
                    mac = GetMacAddress(ip);
                    //creates and adds node to the nodes list
                    Node node = new Node(upCount, name, ip, mac);
                    List.Add(node);
                    //writes host details to log file
                    Trace.WriteLine($"Host {upCount} = {ip} ({name}) is up: ({e.Reply.RoundtripTime} ms)");
                }
                else
                {
                    //Console.WriteLine("{0} is up: ({1} ms)", ip, e.Reply.RoundtripTime);
                    //writeToFile($"{ip} is up: ({e.Reply.RoundtripTime} ms)");
                }
                //mutual exculsion code
                lock (lockObj)
                {
                    //increments the number of nodes
                    upCount++;
                }
            }
        }

        //private void active_Scan_button(object sender, EventArgs e)
        //{
        //    if (sender == netIp1a || sender == netIp1b || sender == netIp1c || sender == netIp1d || cidr1 == sender)
        //    {
        //        scanNet1.Enabled = true;
        //        enable_2nd_Network(sender, e);
        //    }
        //    else if (sender == netIp2a || sender == netIp2b || sender == netIp2c || sender == netIp2d || cidr2 == sender)
        //    {
        //        scanSecondNet = true;
        //        enable_3rd_Network(sender, e);
        //    }
        //    else
        //    {
        //        scanThirdNet = true;
        //    }
        //}

        //code for GUI to enable second network
        private void enable_2nd_Network(object sender, EventArgs e)
        {
            Boolean b = true;
            if (sender == En_IP_Net_2 && En_IP_Net_2.Checked == false)
            {
                b = false;
            }
            netIp2a.Enabled = b;
            netIp2b.Enabled = b;
            netIp2c.Enabled = b;
            netIp2d.Enabled = b;
            cidr2.Enabled = b;
            if (!En_IP_Net_3.Checked && !En_IP_Net_1.Checked)
            {
                scanNet1.Enabled = b;
            }

        }

        //code for GUI to enable third network
        private void enable_3rd_Network(object sender, EventArgs e)
        {
            Boolean b = true;
            if (sender == En_IP_Net_3 && En_IP_Net_3.Checked == false)
            {
                b = false;
            }
            netIp3a.Enabled = b;
            netIp3b.Enabled = b;
            netIp3c.Enabled = b;
            netIp3d.Enabled = b;
            cidr3.Enabled = b;
            if (!En_IP_Net_2.Checked && !En_IP_Net_1.Checked)
            {
                scanNet1.Enabled = b;
            }

        }

        //code for GUI to enable first network
        private void enable_1st_Network(object sender, EventArgs e)
        {
            Boolean b = true;
            if(sender == En_IP_Net_1 && En_IP_Net_1.Checked == false){
                b = false;
                }
            netIp1a.Enabled = b;
            netIp1b.Enabled = b;
            netIp1c.Enabled = b;
            netIp1d.Enabled = b;
            cidr1.Enabled = b;
            if(!En_IP_Net_2.Checked && !En_IP_Net_3.Checked)
            {
                scanNet1.Enabled = b;
            }

        }

        //function to change the subnet mask if cidr notation has changed
        private void change_SubnetMask(object sender, EventArgs e)
        {
            if (sender == cidr1)
            {
                if (cidr1.Text == "/24")
                {
                    TwoFoursubnet(subnet1a, subnet1b, subnet1c);
                }
                else if (cidr1.Text == "/16")
                {
                    OneSixsubnet(subnet1a, subnet1b, subnet1c);
                }
                else
                {
                    OneFivesubnet(subnet1a, subnet1b, subnet1c);
                }

            }
            else if (sender == cidr2)
            {
                if (cidr2.Text == "/24")
                {
                    TwoFoursubnet(subnet2a, subnet2b, subnet2c);
                }
                else if (cidr2.Text == "/16")
                {
                    OneSixsubnet(subnet2a, subnet2b, subnet2c);
                }
                else
                {
                    OneFivesubnet(subnet2a, subnet2b, subnet2c);
                }
            }
            else
            {
                if (cidr3.Text == "/24")
                {
                    TwoFoursubnet(subnet3a, subnet3b, subnet3c);
                }
                else if (cidr3.Text == "/16")
                {
                    OneSixsubnet(subnet3a, subnet3b, subnet3c);
                }
                else
                {
                    OneFivesubnet(subnet3a, subnet3b, subnet3c);
                }
            }
        }

        //setting the subnet mask fields for a /24 network
        private void TwoFoursubnet(NumericUpDown oct1, NumericUpDown oct2, NumericUpDown oct3)
        {
            oct1.Value = 255;
            oct2.Value = 255;
            oct3.Value = 255;
        }

        //setting the subnet mask fields for a /16 network
        private void OneSixsubnet(NumericUpDown oct1, NumericUpDown oct2, NumericUpDown oct3)
        {
            oct1.Value = 255;
            oct2.Value = 255;
            oct3.Value = 0;
        }

        //setting the subnet mask fields for a /15 network
        private void OneFivesubnet(NumericUpDown oct1, NumericUpDown oct2, NumericUpDown oct3)
        {
            oct1.Value = 255;
            oct2.Value = 254;
            oct3.Value = 0;
        }

        //function that is used to select the path of the logfile
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
        }

        //function used to get mac address
        public String GetMacAddress(String ipAddress)
        {
            //uses the nodes arp table to get mac address
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


        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cidr1.ValueMember.ToString() != "/24")
        //    {
        //        subnet1c.Value = 0;
        //    }
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    DatabaseIO db = new DatabaseIO();

        //    List = db.GetRows();
        //    dataGridView1.DataSource = List;
        //    dataGridView1.Refresh();
        //}

        private void AddToDB()
        {
            DatabaseIO db = new DatabaseIO();
            db.WriteNodeToDB(List);
            
        }

        private void DeleteRows()
        {
            DatabaseIO db = new DatabaseIO();

            db.DeleteRowsDB();
            
        }

        //private void addError(Node n)
        //{
        //    DatabaseIO db = new DatabaseIO();

        //    db.WriteErrorToDB(n);

        //}

        public void MergeNodes()
        {
            MergeNodes mN = new MergeNodes();

            List = mN.MergeDuplicates(List);

            dataGridView1.EndEdit();

        }

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    MergeNodes();
        //}

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            MergeNodes();
            DeleteRows();
            AddToDB();
            Trace.Write("fdghjkl;kjfdjkljfdsfgkjl;jgfdgjkljhdfghkjljfdghjklkjhfdghkjl;");
        }


        //function for monitoring a node
        //private async void button_click(object sender, EventArgs e)
        //{

        //    //byte[] buffer = Encoding.ASCII.GetBytes(".");
        //    //PingOptions options = new PingOptions(50, true);
        //    //AutoResetEvent reset = new AutoResetEvent(false);
        //    Ping ping = new Ping();
        //    //ping.PingCompleted += new PingCompletedEventHandler(ping_Complete);

        //    foreach (Node n in List)
        //    {
        //        var reply = await ping.SendPingAsync(n.Ip);
        //        if (reply.Status == IPStatus.Success)
        //        {

        //            Trace.Write(n + " (OK)\n");
        //        }
        //        else
        //        {
        //            Trace.Write(n + " (FAILED)\n");
        //            addError(n);
        //        }
        //    }
        //}


    }


}

