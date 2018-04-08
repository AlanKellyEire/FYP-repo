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
                //Trace.Write(i);
                bool name = ExistsHostname(arrayList[i].Hostname.ToLower().ToString(), temp, i);
                Trace.Write(i + " node ip =" + arrayList[i].Ip.ToLower().ToString() + "\n");

                if (!name)
                {
                    temp.Add(arrayList[i]);
                }
                else
                {

                    if (!ExistsIp(arrayList[i].Ip.ToLower().ToString(), temp, i))
                    {
                        bool b = false;
                        for (int c = 0; c < temp.Count; c++)
                        {
                            b = false;
                            ////test to see if the hostname of the current node is the same as the node in the new list.
                            if (temp[c].Hostname.ToLower() == arrayList[i].Hostname.ToLower())
                            {
                                if (!IsController(arrayList[i]))
                                {
                                    //b = true;
                                    //tests if the new node to be added has an ip that is already in another node.
                                    if (!arrayList[i].Ip.ToLower().ToString().Equals(temp[c].Ip.ToLower().ToString()) && !arrayList[i].Ip.ToLower().ToString().Equals(temp[c].IpSecondary.ToLower().ToString()) && !arrayList[i].Ip.ToLower().ToString().Equals(temp[c].IpThird.ToLower().ToString()) && !arrayList[i].Ip.ToLower().ToString().Equals(temp[c].IpFourth.ToLower().ToString()))
                                    {
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
                                else
                                {
                                    //if (!ExistsIp(arrayList[i].Ip.ToLower().ToString(), temp, i) && !ExistsIp(arrayList[i].IpSecondary.ToLower().ToString(), temp, i))
                                    //{
                                    string ipOfTemp;
                                    string ipOfCurrent;
                                    ipOfTemp = temp[c].Ip.ToLower().ToString();
                                    ipOfTemp = ipOfTemp.Substring(ipOfTemp.LastIndexOf(".") + 1);
                                    ipOfCurrent = arrayList[i].Ip.ToLower().ToString();
                                    ipOfCurrent = ipOfCurrent.Substring(ipOfCurrent.LastIndexOf(".") + 1);
                                    Trace.Write("ip =" + ipOfTemp + " == " + ipOfCurrent + "\n");
                                    Trace.Write("is it true??? == " + ipOfTemp.Equals(ipOfCurrent) + "\n");
                                    if (ipOfTemp == ipOfCurrent)
                                    {
                                        Trace.Write("ip =" + ipOfTemp + " == " + ipOfCurrent + "\n");
                                        //ipNet.Substring(0, (ipNet.LastIndexOf(".")));
                                        if (string.IsNullOrEmpty(temp[c].IpSecondary))
                                        {
                                            b = true;
                                            temp[c].IpSecondary = arrayList[i].Ip.ToLower().ToString();
                                            temp[c].MacSecondary = arrayList[i].Mac.ToLower().ToString();
                                        }
                                    }
                                }
                            }
                        }
                        if (!b)
                        {
                            temp.Add(arrayList[i]);
                        }
                    }
                }
            }

            return temp;

        }

        //tests if IP exists on a node already in the array
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

        //tests if hostname exists on a node already in the array
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

        private Boolean IsController(Node currentNode)
        {
            if (currentNode.Mac.ToLower().StartsWith("00-22-e5") || currentNode.Mac.ToLower().StartsWith("00-80-74"))
            {

                //ipOfCurrent = ipOfTemp.Substring(index, last);
                return true;
            }
            return false;
        }
    }
}
////todo get the mac address of the controllers the next day at work.
//if (!ExistsIp(arrayList[i].Ip.ToLower().ToString(), temp, i))
//{
//    for (int c = 0; c < temp.Count; c++)
//    {
//        if (temp[c].Hostname.ToLower() != "?")
//        {
//            if (temp[c].Hostname.ToLower() == arrayList[i].Hostname.ToLower())
//            {
//                //if(temp[c].Hostname.ToLower() == "?" && (temp[c].Mac.ToLower().StartsWith("00-22-e5") || temp[c].Mac.ToLower().StartsWith("00-80-74")))
//                //{
//                //    DialogResult result2 = MessageBox.Show("test " + temp[c].Hostname + " test", "test", MessageBoxButtons.OK, MessageBoxIcon.Question);
//                //}

//                if (!arrayList[i].Ip.ToLower().ToString().Equals(temp[c].Ip.ToLower().ToString()) && !arrayList[i].IpSecondary.ToLower().ToString().Equals(temp[c].Ip.ToLower().ToString()) && !arrayList[i].IpThird.ToLower().ToString().Equals(temp[c].Ip.ToLower().ToString()) && !arrayList[i].IpFourth.ToLower().ToString().Equals(temp[c].Ip.ToLower().ToString()))
//                {
//                    if (string.IsNullOrEmpty(temp[c].IpSecondary))
//                    {
//                        temp[c].IpSecondary = arrayList[i].Ip.ToLower().ToString();
//                        temp[c].MacSecondary = arrayList[i].Mac.ToLower().ToString();
//                    }
//                    else if (string.IsNullOrEmpty(temp[c].IpThird))
//                    {
//                        temp[c].IpThird = arrayList[i].Ip.ToLower().ToString();
//                        temp[c].MacThird = arrayList[i].Mac.ToLower().ToString();
//                    }
//                    else if (string.IsNullOrEmpty(temp[c].IpFourth))
//                    {
//                        temp[c].IpFourth = arrayList[i].Ip.ToLower().ToString();
//                        temp[c].MacFourth = arrayList[i].Mac.ToLower().ToString();
//                    }
//                    else
//                    {
//                        DialogResult result2 = MessageBox.Show("Node " + temp[c].Hostname + " is full", "Scan Successful", MessageBoxButtons.OK, MessageBoxIcon.Question);
//                    }
//                }
//            }

//        }
//        //else
//        //{
//        //    if (arrayList[i].Mac.ToLower().StartsWith("00-22-e5") || arrayList[i].Mac.ToLower().StartsWith("00-80-74"))
//        //    {
//        //        string ipOfTemp;
//        //        string ipOfCurrent;
//        //        ipOfTemp = temp[c].Ip.ToLower().ToString();
//        //        ipOfTemp = ipOfTemp.Substring(ipOfTemp.LastIndexOf("."), ipOfTemp.Length);
//        //        Trace.Write("\n\n\n\n\n\n\n === \n\n\n\n" + ipOfTemp);
//        //        //ipNet.Substring(0, (ipNet.LastIndexOf(".")));
//        //        if (!arrayList[i].Ip.ToLower().ToString().Equals(temp[c].Ip.ToLower().ToString()) && !arrayList[i].IpSecondary.ToLower().ToString().Equals(temp[c].Ip.ToLower().ToString()))
//        //        {
//        //            if (string.IsNullOrEmpty(temp[c].IpSecondary))
//        //            {
//        //                temp[c].IpSecondary = arrayList[i].Ip.ToLower().ToString();
//        //                temp[c].MacSecondary = arrayList[i].Mac.ToLower().ToString();
//        //            }
//        //        }
//        //    }
//        //}
//    }
//}