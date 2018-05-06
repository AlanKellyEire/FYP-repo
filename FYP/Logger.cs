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
    class Logger
    {
        private string path = "";
        private string filename = "";
        private Boolean logTypeAll;

        public Logger(string pathToFile, string logFileName, Boolean loggingType)
        {
            this.Path = pathToFile;
            this.Filename = logFileName;
            this.LogTypeAll = loggingType;
        }

        public Logger()
        {

        }
        
        public string Path { get => path; set => path = value; }
        public string Filename { get => filename; set => filename = value; }
        public bool LogTypeAll { get => logTypeAll; set => logTypeAll = value; }
    }
}
