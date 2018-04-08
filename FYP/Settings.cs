using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP_10_2_18
{
    public class Settings
    {
        private int pingInterval;
        private string[] emails = new string[5];
        private Logger logSettings;
        private EmailServer serverSettings = new EmailServer();

        private Boolean loggerEnabled;
        private Boolean emailEnabled;

        public Settings() {

        }

        public int PingInterval { get => pingInterval; set => pingInterval = value; }
        public string[] Emails { get => emails; set => emails = value; }
        public bool LoggerEnabled { get => loggerEnabled; set => loggerEnabled = value; }
        public bool EmailEnabled { get => emailEnabled; set => emailEnabled = value; }
        internal Logger LogSettings { get => logSettings; set => logSettings = value; }
        internal EmailServer ServerSettings { get => serverSettings; set => serverSettings = value; }
    }
}
