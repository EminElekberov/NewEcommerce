using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Service
{
    public interface IEmailService
    {
        void Send(string to,string subject,string html);
    }
    public class EmailService : IEmailService
    {
        public void Send(string to, string subject, string html)
        {
            MimeMessage email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("elsadrehimov096@gmail.com"));//kimden email gedecek bura yaziriq 
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text = html };

            //send message
            SmtpClient smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("elsadrehimov096@gmail.com", "emin123!A");
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}
