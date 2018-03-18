using System;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using System.Collections.ObjectModel;
//using Finisar.SQLite;
using System.Data.SQLite;

namespace FYP_10_2_18
{
    public partial class Form1 : Form
    {
        ObservableCollection<Node> list = new ObservableCollection<Node>();
        static CountdownEvent countdown;
        static int upCount = 0;
        static object lockObj = new object();
        const bool resolveNames = true;


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

        private void ScanNetworkClick(object sender, EventArgs e)
        {
           
                //AlertClass aC = new AlertClass();
                rw = new ReadAndWrite(path, filename);

                upCount = 1;
                ipBase = netIp1a.Value.ToString() + "." + netIp1b.Value.ToString() + "." + netIp1c.Value.ToString() + "." + netIp1d.Value.ToString();
                sub = subnet1a.Value.ToString() + "." + subnet1b.Value.ToString() + "." + subnet1c.Value.ToString() + "." + subnet1d.Value.ToString();

                //writing starttime to file;
                rw.writeTime();
                //scanNetwork(ipBase, cidr1.Text);
                if (En_IP_Net_1.Checked)
                {
                    ipBase = netIp1a.Value.ToString() + "." + netIp1b.Value.ToString() + "." + netIp1c.Value.ToString() + "." + netIp1d.Value.ToString();
                    ScanNetwork(ipBase, cidr1.Text);
                }
                if (En_IP_Net_2.Checked)
                {
                    ipBase = netIp2a.Value.ToString() + "." + netIp2b.Value.ToString() + "." + netIp2c.Value.ToString() + "." + netIp2d.Value.ToString();
                    ScanNetwork(ipBase, cidr2.Text);
                }
                if (En_IP_Net_3.Checked)
                {
                    ipBase = netIp3a.Value.ToString() + "." + netIp3b.Value.ToString() + "." + netIp3c.Value.ToString() + "." + netIp3d.Value.ToString();
                    ScanNetwork(ipBase, cidr3.Text);
                }


                DialogResult result2 = MessageBox.Show("Network scan is now complete", "Scan Successful", MessageBoxButtons.OK, MessageBoxIcon.Question);

                //write list to file
                rw.writeList(list, path, filename);
                //writing finish time to file
                rw.writeTime();


                //this.dataGridView1.ItemsSource = list;
                dataGridView1.DataSource = list;
            dataGridView1.Refresh();

        }

        public void IpScan24(String ipNet)
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

        public void IpScan16(String ipNet)
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

        public void ScanNetwork(String ipNet, String cidr)
        {
            if (cidr != "/24")
            {
                Trace.WriteLine("\n/16 IP = \n");
                Trace.WriteLine("\n IP = " + ipNet + cidr + "\n");
                IpScan16(ipNet);
            }
            else
            {
                Trace.WriteLine("\n/24 IP = \n");
                Trace.WriteLine("\n IP = " + ipNet + cidr + "\n");
                IpScan24(ipNet);
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
                    mac = GetMacAddress(ip);
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

        public String GetMacAddress(String ipAddress)
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
            if (cidr1.ValueMember.ToString() != "/24")
            {
                subnet1c.Value = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DatabaseIO db = new DatabaseIO();

            list = db.GetRows();
            dataGridView1.DataSource = list;
            dataGridView1.Refresh();
        }

        private void AddToDBClick(object sender, EventArgs e)
        {
            DatabaseIO db = new DatabaseIO();
            db.WriteNodeToDB(list);
            
        }

        private void DeleteRows(object sender, EventArgs e)
        {
            DatabaseIO db = new DatabaseIO();

            db.DeleteRowsDB();
            
        }

        public void MergeNodes()
        {
            MergeNodes mN = new MergeNodes();

            list = mN.MergeDuplicates(list);

            dataGridView1.EndEdit();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MergeNodes();
        }
    }


}

