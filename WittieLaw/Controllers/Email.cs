using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Linq;

using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;

namespace WittieLaw.Controllers
{
    public class Email
    {
        public static void sendmail(string emailmessage,string fullname,string emailaddress)
        {
            MailDefinition message = new MailDefinition();
            MailMessage ConfirmationMail = new MailMessage();
            String sFrom = "info@wittielaw.com ";
            String sTo = "info@wittielaw.com ";
            sTo = sTo.Trim();
            ConfirmationMail.From = new MailAddress(sFrom);
          
            ConfirmationMail.To.Add(sTo);
            if (emailmessage !=string.Empty)
            {
                emailmessage="Visitor Name: " + fullname + "\n" + "Message: " + emailmessage;
            ConfirmationMail.Body = emailmessage;
            }else
            {
                emailmessage="Visitor Name: " + fullname + "\n" + "Message: Visitor left no message available.";
                ConfirmationMail.Body = emailmessage;

            }
                message.IsBodyHtml = true;
            ConfirmationMail.Subject = "New Inquiry";
            SmtpClient Client = new SmtpClient("smtpout.secureserver.net", 25);
            //SmtpClient Client = new SmtpClient("dedrelay.secureserver.net", 25);
            Client.Credentials = new NetworkCredential("info@wittielaw.com", "abc123");
            Client.Send(ConfirmationMail);
            return;
        }
    }
}