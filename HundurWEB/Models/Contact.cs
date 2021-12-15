using System;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HundurWEB.Models
{
    public class Contact
    {
        public static void SendMail(string body)
        {
            var fromAddress = new MailAddress("email", "Web Sitesinden Gelen İletişim Formu...");
            var toAddress = new MailAddress("email");
            const string subject = "Web Sitesinden Gelen İletişim Formu...";
            using (var smtp = new SmtpClient
            {
                
                Host = "mail.email",
                Port = 587,
                EnableSsl = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, "^şifre")
                //trololol kısmı e-posta adresinin şifresi
            })
            {
                using (var message = new MailMessage(fromAddress, toAddress) { Subject = subject, Body = body })
                {
                    smtp.Send(message);
                }
            }
        }
    }
}
