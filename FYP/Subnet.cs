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
    class Subnet
    {
        public String getSubnet(String ip, NumericUpDown cidr)
        {
            Trace.WriteLine("\nstring c = " + ip + "\n");
            ip = "192.168.0.1/" + cidr.Value.ToString();
            Trace.WriteLine("\nstring c = " + ip + "\n");
            IPNetwork ipnetwork = System.Net.IPNetwork.Parse(ip);

            convertToMask(ipnetwork.Netmask.ToString());

            Console.WriteLine("FirstUsable : {0}", ipnetwork.FirstUsable);
            Console.WriteLine("LastUsable : {0}", ipnetwork.LastUsable);

            return "sfs";

        }

        public String dotAt(String s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '.')
                {
                    return s.Substring(s.Length - (i - 1));
                }
            }
            return "Wrong fool";
        }

        public String[] convertToMask(String s)
        {
            //array of octs
            String[] c = new string[4];
            //getting each oct of the subnet/ip
            c[0] = s.Substring(0, (s.IndexOf('.')));
            s = s.Substring(c[0].Length + 1, s.Length - c[0].Length - 1);
            c[1] = s.Substring(0, (s.IndexOf('.')));
            s = s.Substring(c[1].Length + 1, s.Length - c[1].Length - 1);
            c[2] = s.Substring(0, (s.IndexOf('.')));         
            s = s.Substring(c[2].Length + 1, s.Length - c[2].Length - 1);
            c[3] = s;
            //prining each string
            foreach (var i in c)
            {
                Trace.WriteLine(i.ToString());
            }
            return c;
        }

    }
}
