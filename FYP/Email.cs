using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Diagnostics;

namespace FYP_10_2_18
{
    class Email
    {
        public Email()
        {
        }


        public void sendTest(Settings set)
        {
            // Command line argument must the the SMTP host.
            SmtpClient client = new SmtpClient();
            client.Port = ((int)set.ServerSettings.Port);
            client.Host = set.ServerSettings.OutGoingMailServer.ToString();
            if (!set.ServerSettings.Tls)
            {
                client.EnableSsl = true;
            }
            else
            {

                client.EnableSsl = false;
            }
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(set.ServerSettings.Username.ToString(), set.ServerSettings.Password.ToString());

            MailMessage mm = new MailMessage(set.ServerSettings.Username, set.ServerSettings.Username, "TEST SUBJECT", "This Test Body");
            mm.BodyEncoding = UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.Send(mm);
           
        }

        public void sendEmailExchange(Settings set)
        {
            string To = set.ServerSettings.Username;
            string From = set.ServerSettings.Username;
            //string Subject = "Test exchange email Subject.";
            string Body = "Test Email Body.";

            //// create the email message
            //MailMessage completeMessage = new MailMessage(From, To, Subject, Body);

            //// create smtp client at mail server location
            //SmtpClient client = new SmtpClient(set.ServerSettings.OutGoingMailServer);

            //// add credentials
            //client.UseDefaultCredentials = true;

            //try
            //{
            //    // send message
            //    client.Send(completeMessage);
            //}
            //catch (Exception)
            //{
            //    throw;
            //}

            Validation val = new Validation();

            for (int i = 0; i < set.Emails.Length; i++)
            {
                if (val.IsValidEmail(set.Emails[i].ToString()))
                {

                    // create the email message
                    MailMessage completeMessage = new MailMessage(From, set.Emails[i].ToString(), set.ServerSettings.Subject.ToString(), Body);

                    // create smtp client at mail server location
                    SmtpClient client = new SmtpClient(set.ServerSettings.OutGoingMailServer);

                    // add credentials
                    client.UseDefaultCredentials = true;

                    try
                    {
                        // send message
                        client.Send(completeMessage);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        public void sendEmail(Settings set, Node n, int ipAdd)
        {
            Trace.Write("\n\n\n\n Email Sent \n\n\n\n");
            // Command line argument must the the SMTP host.
            SmtpClient client = new SmtpClient();
            client.Port = ((int)set.ServerSettings.Port);
            client.Host = set.ServerSettings.OutGoingMailServer.ToString();
            if (!set.ServerSettings.Tls)
            {
                client.EnableSsl = true;
            }
            else
            {

                client.EnableSsl = false;
            }
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(set.ServerSettings.Username.ToString(), set.ServerSettings.Password.ToString());

            string ip = "";

            ip = (ipAdd == 1) ? n.Ip : (ipAdd == 2) ? n.IpSecondary : (ipAdd == 3) ? n.IpThird : n.IpFourth;

            string message = "Nic with IP of " + ip + " on Node " + n.Hostname + " is unreachable\n";
            Validation val = new Validation();

            for (int i = 0; i < set.Emails.Length; i++)
            {
                if (val.IsValidEmail(set.Emails[i].ToString()))
                {
                    MailMessage mm = new MailMessage(set.ServerSettings.Username, set.Emails[i].ToString(), set.ServerSettings.Subject.ToString(), message);
                    mm.BodyEncoding = UTF8Encoding.UTF8;
                    mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                    client.Send(mm);
                }
            }
        }
    }
}
