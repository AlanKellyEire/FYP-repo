using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace FYP_10_2_18
{
    [Serializable()]
    class EmailServer
    {
        private string subject = "";
        private string outGoingMailServer = "";
        private ushort port = 0;
        private Boolean tls = false;
        private string username = "";
        private string password = "";

        public EmailServer(string sub, string mailServer, ushort portNum, Boolean enabled, string user, string pass)
        {
            this.subject = sub;
            this.OutGoingMailServer = mailServer;
            this.Port = portNum;
            this.Tls = enabled;
            this.Username = user;
            this.Password = pass;
        }

        public EmailServer()
        {
        }

        public override string ToString()
        {
            return subject + ", " + outGoingMailServer + ", " + port + ", " + tls + ", " + username + ", " + password;
        }

        public string Subject { get => subject; set => subject = value; }
        public string OutGoingMailServer { get => outGoingMailServer; set => outGoingMailServer = value; }
        public ushort Port { get => port; set => port = value; }
        public bool Tls { get => tls; set => tls = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
