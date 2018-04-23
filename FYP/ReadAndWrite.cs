using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using System.Globalization;
using System.Collections.ObjectModel;


namespace FYP_10_2_18
{
    class ReadAndWrite
    {
        private String path;
        private String filename;
        private Boolean startFinish = false;

        public string Path { get => path; set => path = value; }
        public string Filename { get => filename; set => filename = value; }

        public ReadAndWrite(String p, String file ){

            Path = p;
            Filename = file;
        }

       

        public void writeToFile(String word)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@path + "/" + filename + ".txt", true))
            {
                file.WriteLine(word);
            }
        }

        public void writeList(ObservableCollection<Node> list, String path, String filename)
        {
            for (int i = 0; i < list.Count(); i++)
            {
                writeToFile(list[i].ToString());
            }
        }

        public void writeTime()
        {
            DateTime localDate = DateTime.Now;
            var culture = new CultureInfo("en-GB");
            if (!startFinish)
            {
                writeToFile("Scan started at " + localDate.ToString(culture));
                startFinish = false;
            }
            else
            {
                writeToFile("Scan Finished at " + localDate.ToString(culture));
                startFinish = true;
            }

        }


}
}
