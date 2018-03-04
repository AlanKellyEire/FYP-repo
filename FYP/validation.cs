using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP_10_2_18
{
    class Validation
    {


        /*
        private void ValIp(TextBox tbox)
        {

            // Checks the value of the text.
            int count = tbox.Text.Count(f => f == '.');
            if (count != 3)
            {

                // Initializes the variables to pass to the MessageBox.Show method.

                string message = "you have not enetered a correct IP address. Please reenter IP address";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.No)
                {

                    // Closes the parent form.
                    this.Close();

                }

            }

        }
        
        private void ValSubnet(TextBox tbox)
        {

            // Checks the value of the text.
            int count = tbox.Text.Count(f => f == '.');
            int zeros = tbox.Text.Count(f => f == '0');
            if (count != 3)
            {

                // Initializes the variables to pass to the MessageBox.Show method.

                string message = "you have not enetered a correct subnet address. Please reenter Subnet";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.No)
                {
                    // Closes the parent form.
                    this.Close();

                }

            }
            if (zeros == 1)
            {
                ipBase = tbox.Text.Substring(0, (tbox.Text.LastIndexOf(".") + 1));
            }
            if (zeros == 2)
            {
                ipBase = tbox.Text.Substring(0, (tbox.Text.LastIndexOf(".") + 1));
            }

            //IPNetwork ipnetwork = IPNetwork.Parse("2001:0db8::/64");

            //Trace.Write($"Network : {ipnetwork.Network}");
            //Console.WriteLine("Netmask : {0}", ipnetwork.Netmask);
            //Console.WriteLine("Broadcast : {0}", ipnetwork.Broadcast);
            //Console.WriteLine("FirstUsable : {0}", ipnetwork.FirstUsable);
            //Console.WriteLine("LastUsable : {0}", ipnetwork.LastUsable);
            //Console.WriteLine("Cidr : {0}", ipnetwork.Cidr);
        }
        */
    }
}
