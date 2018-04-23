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
    public class Settings
    {
        private int pingInterval;
        private string[] emails = new string[5];
        private Logger logSettings = new Logger();
        private EmailServer serverSettings = new EmailServer();

        private Boolean loggerEnabled;
        private Boolean emailEnabled;

        public Settings() {

        }

        public Settings(SerializationInfo info, StreamingContext ctxt)
        {
            //Get the values from info and assign them to the appropriate properties
            pingInterval = (int)info.GetValue("pingInterval", typeof(int));
            emails = (String[])info.GetValue("emails", typeof(string[]));
            logSettings = (Logger)info.GetValue("logSettings", typeof(Logger));
            serverSettings = (EmailServer)info.GetValue("serverSettings", typeof(EmailServer));
            loggerEnabled = (Boolean)info.GetValue("loggerEnabled", typeof(Boolean));
            emailEnabled = (Boolean)info.GetValue("emailEnabled", typeof(Boolean));
            serverSettings.ToString();
        }

        public int PingInterval { get => pingInterval; set => pingInterval = value; }
        public string[] Emails { get => emails; set => emails = value; }
        public bool LoggerEnabled { get => loggerEnabled; set => loggerEnabled = value; }
        public bool EmailEnabled { get => emailEnabled; set => emailEnabled = value; }
        internal Logger LogSettings { get => logSettings; set => logSettings = value; }
        internal EmailServer ServerSettings { get => serverSettings; set => serverSettings = value; }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            //You can use any custom name for your name-value pair. But make sure you
            // read the values with the same name. For ex:- If you write EmpId as "EmployeeId"
            // then you should read the same with "EmployeeId"
            info.AddValue("pingInterval", pingInterval);
            info.AddValue("emails", emails);
            info.AddValue("logSettings", logSettings);
            info.AddValue("loggerEnabled", loggerEnabled);
            info.AddValue("emailEnabled", emailEnabled);
            info.AddValue("serverSettings", serverSettings);
            serverSettings.ToString();
        }
    }
}
