using Leuka.Core.Models;
using Microsoft.AspNetCore.Http;
using System.Net;
using System.Net.Mail;

namespace Leuka.Core
{
    public static class SmtpHelper 
    {    
        public static void SendEmail(EmailSettings emailSettings, string firstName, string lastName, string email, string messageText, bool involveInActions, IEnumerable<IFormFile> attachments)
        {
            var subject = $"Leuka - Kontakt";
            var actions = involveInActions ? "Želim da se priključim akcijama." : "";
            var body = $"Ime: {firstName}\nPrezime: {lastName}\nEmail: {email} \nPoruka: {messageText} \n{actions}";
            
            PerformSending(emailSettings, subject, body, attachments);
        }

        public static void SendDonationEmail(EmailSettings emailSettings, string name, string amount, string companyName, string email)
        {
            var subject = $"Leuka - Donacija";
            var body = $"Ime i Prezime: {name}\nIznos: {amount}\nKompanija: {companyName} \nEmail: {email}";

            PerformSending(emailSettings, subject, body, null);
        }

        private static void PerformSending(EmailSettings emailSettings, string subject, string body, IEnumerable<IFormFile> attachments)
        {
            var fromAddress = new MailAddress(emailSettings.SenderEmailAddress);
            var toAddress = new MailAddress(emailSettings.ReceiverEmailAddress);


            var smtp = new SmtpClient
            {
                Host = emailSettings.ServerAddress,
                Port = emailSettings.Port,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(emailSettings.SenderEmailAddress, emailSettings.Password)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
                   {
                       Subject = subject,
                       Body = body
                   })
            {
                if (attachments != null)
                {
                    foreach (var file in attachments)
                    {
                        if (file == null || file.Length <= 0) continue;
                        try
                        {
                            var fileName = Path.GetFileName(file.FileName);
                            var attachment = new Attachment(file.OpenReadStream(), fileName);
                            message.Attachments.Add(attachment);
                        }
                        catch (Exception)
                        {
                            // ignored
                        }
                    }
                }

                smtp.Send(message);
            }
        }
    }
}
