using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP_10_2_18
{
    class Node
    {
        private long id;
        private string hostname;
        private string ip;
        private string mac;
        private string ip_sec;
        private string mac_sec;
        private string ip_third;
        private string mac_third;

        public Node(int id, string name, string ip, string mac)
        {
            this.Id = id;
            this.hostname = name;
            this.Ip = ip;
            this.Mac = mac;
        }

        public Node()
        {
        }

        public long Id { get => id; set => id = value; }
        public string Hostname { get => hostname; set => hostname = value; }
        public string Ip { get => ip; set => ip = value; }
        public string Mac { get => mac; set => mac = value; }
        public string Ip_sec { get => ip_sec; set => ip_sec = value; }
        public string Mac_sec { get => mac_sec; set => mac_sec = value; }
        public string Ip_third { get => ip_third; set => ip_third = value; }
        public string Mac_third { get => mac_third; set => mac_third = value; }

        public override string ToString()
        {
            return id + ", " + hostname + ", " + ip + ", " + mac;
    }
    }  
}