using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ToolLayer.MyTools
{
    public static class MailSender
    {
        public static void Send(string receiver, string password, string body, string subject, string sender = "yazılımfikirleriekibi@outlook.com")
        {
            
            MailAddress senderEmail = new MailAddress(sender);

            MailAddress receiverEmail = new MailAddress(receiver);

            SmtpClient smtp = new SmtpClient()
            {
                Host = "smtp-mail.outlook.com",
                Port=587,
                EnableSsl=true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials=false,
                Credentials= new NetworkCredential(senderEmail.Address,password)
            };

            using (MailMessage mesaj = new MailMessage(senderEmail, receiverEmail)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(mesaj);
            }
        }
    }
}
