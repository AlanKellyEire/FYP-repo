using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP_10_2_18
{
    class MergeNodes
    {

        public ObservableCollection<Node> merge_duplicates(ObservableCollection<Node> arrayList)
        {

            ObservableCollection<Node> temp = new ObservableCollection<Node>();

            for (int i = 0; i < arrayList.Count; i++)
            {
                bool name = exists(arrayList[i].Hostname.ToLower().ToString(), temp, i, 1);
                //bool ip = exists(arrayList[i].Ip.ToLower().ToString(), temp, i, 2);
                if (!name)
                {
                    temp.Add(arrayList[i]); 
                }
                else
                {
                    //if (!exists(arrayList[i].Ip.ToLower().ToString(), temp, i, 2))
                    //{
                    //    temp.Add(arrayList[i]);
                    //}

                    //todo get the mac address of the controllers the next day at work.
                    if (!exists(arrayList[i].Ip.ToLower().ToString(), temp, i, 2))
                    {
                        for (int c = 0; c < temp.Count; c++)
                        {
                            if (temp[c].Hostname.ToLower() == arrayList[i].Hostname.ToLower())
                            {
                                temp[c].Ip_sec = arrayList[i].Ip.ToLower().ToString();
                                //Node n = new Node();
                                //n.Id = 456;
                                //n.Ip = "dfgjkldfghjk";
                                //n.Hostname = "hhhhhh";
                                //n.Mac = "mmmmmmmmmmmmm";
                                //n.Ip_sec = "second";
                                //n.Ip_third = "third";
                                //temp.Add(n);
                            }
                        }
                    }
                }
            }

            return temp;

        }


        private Boolean exists(string s, ObservableCollection<Node> arrayList, int z, int mode)
        {
            if (mode == 1)
            {
                for (int i = 0; i < arrayList.Count; i++)
                {
                    if (i != z)
                    {
                        if (s == arrayList[i].Hostname.ToLower().ToString())
                        {
                            return true;
                        }
                    }
                }
            }
            if (mode == 2)
            {
                for (int i = 0; i < arrayList.Count; i++)
                {
                    if (i != z)
                    {
                        if (s == arrayList[i].Ip.ToLower().ToString())
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
