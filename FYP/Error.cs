using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP_10_2_18
{
    
    class Error
    {
        private long id;
        private long nodeId;
        private string hostname;
        private string errorType;
        private string comment;
        private string timestamp;
        private string ip;

        public Error(int errorId, int idOfNode, string hostN, string issue, string time, string errorIp)
        {
            Id = errorId;
            NodeId = idOfNode;
            Hostname = hostN;
            ErrorType = issue;
            Timestamp = time;
            Ip = errorIp;
        }

        public Error()
        {

        }

        public long Id { get => id; set => id = value; }
        public string Hostname { get => hostname; set => hostname = value; }
        public long NodeId { get => nodeId; set => nodeId = value; }
        public string ErrorType { get => errorType; set => errorType = value; }
        public string Comment { get => comment; set => comment = value; }
        public string Timestamp { get => timestamp; set => timestamp = value; }
        public string Ip { get => ip; set => ip = value; }

        public override string ToString()
        {
            return Id + ", " + Hostname + ", " + NodeId + ", " + ErrorType + ", " + Comment + ", " + Timestamp;
        }
    }
}
