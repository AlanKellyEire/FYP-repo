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


        public override string ToString()
        {
            return id + ", " + hostname + ", " + ip + ", " + mac;
    }
    }  
}