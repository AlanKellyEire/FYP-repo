using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYP_10_2_18
{
    class MergeNodes
    {

        public ObservableCollection<Node> MergeDuplicates(ObservableCollection<Node> arrayList)
        {

            ObservableCollection<Node> temp = new ObservableCollection<Node>();

            for (int i = 0; i < arrayList.Count; i++)
            {
                bool name = ExistsHostname(arrayList[i].Hostname.ToLower().ToString(), temp, i);
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
                    if (!ExistsIp(arrayList[i].Ip.ToLower().ToString(), temp, i))
                    {
                        for (int c = 0; c < temp.Count; c++)
                        {
                            if (temp[c].Hostname.ToLower() == arrayList[i].Hostname.ToLower())
                            {
                                if(!arrayList[i].Ip.ToLower().ToString().Equals(temp[c].Ip.ToLower().ToString()) && !arrayList[i].IpSecondary.ToLower().ToString().Equals(temp[c].Ip.ToLower().ToString()) && !arrayList[i].IpThird.ToLower().ToString().Equals(temp[c].Ip.ToLower().ToString()) && !arrayList[i].IpFourth.ToLower().ToString().Equals(temp[c].Ip.ToLower().ToString()))
                                if (string.IsNullOrEmpty(temp[c].IpSecondary))
                                {
                                    temp[c].IpSecondary = arrayList[i].Ip.ToLower().ToString();
                                    temp[c].MacSecondary = arrayList[i].Mac.ToLower().ToString();
                                }
                                else if (string.IsNullOrEmpty(temp[c].IpThird))
                                {
                                    temp[c].IpThird = arrayList[i].Ip.ToLower().ToString();
                                    temp[c].MacThird = arrayList[i].Mac.ToLower().ToString();
                                }
                                else if (string.IsNullOrEmpty(temp[c].IpFourth))
                                {
                                    temp[c].IpFourth = arrayList[i].Ip.ToLower().ToString();
                                    temp[c].MacFourth = arrayList[i].Mac.ToLower().ToString();
                                }
                                else
                                {
                                    DialogResult result2 = MessageBox.Show("Node " + temp[c].Hostname + " is full", "Scan Successful", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                }
                            }
                        }
                    }
                }
            }

            return temp;

        }


        private Boolean ExistsIp(string s, ObservableCollection<Node> arrayList, int z)
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
            
            return false;
        }

        private Boolean ExistsHostname(string s, ObservableCollection<Node> arrayList, int z)
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
            return false;
        }
    }
}
