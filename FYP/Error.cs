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

        public Error(int errorId, int idOfNode, string hostN, string issue, string time)
        {
            Id = errorId;
            NodeId = idOfNode;
            Hostname = hostN;
            ErrorType = issue;
            timestamp = time;
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
    }
}
