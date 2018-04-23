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

        //public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        //{
        //    //You can use any custom name for your name-value pair. But make sure you
        //    // read the values with the same name. For ex:- If you write EmpId as "EmployeeId"
        //    // then you should read the same with "EmployeeId"
        //    info.AddValue("subject", subject);
        //    info.AddValue("outGoingMailServer", outGoingMailServer);
        //    info.AddValue("port", port);
        //    info.AddValue("tls", tls);
        //    info.AddValue("username", username);
        //    info.AddValue("password", password);

        //}
    }
}
