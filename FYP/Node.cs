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
        private string ipSecondary;
        private string macSecondary;
        private string ipThird;
        private string macThird;
        private string ipFourth;
        private string macFourth;
        private Boolean monitorEnabled = true;

        public Node(int id, string name, string ip, string mac)
        {
            this.Id = id;
            this.Hostname = name;
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
        public string IpSecondary { get => ipSecondary; set => ipSecondary = value; }
        public string MacSecondary { get => macSecondary; set => macSecondary = value; }
        public string IpThird { get => ipThird; set => ipThird = value; }
        public string MacThird { get => macThird; set => macThird = value; }
        public string IpFourth { get => ipFourth; set => ipFourth = value; }
        public string MacFourth { get => macFourth; set => macFourth = value; }
        public bool MonitorEnabled { get => monitorEnabled; set => monitorEnabled = value; }

        public override string ToString()
        {
            return id + ", " + hostname + ", " + ip + ", " + mac;
    }
    }  
}