using Leuka.Core.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace Leuka.Core
{
    public static class SmtpHelper
    {
        public static void SendEmail(EmailSettings emailSettings, string firstName, string lastName, string email, string messageText, bool involveInActions, string formDescription, IEnumerable<HttpPostedFileBase> attachments)
        {
            var fromAddress = new MailAddress(emailSettings.SenderEmailAddress);
            var toAddress = new MailAddress(emailSettings.ReceiverEmailAddress);
            string subject = $"Leuka - {formDescription}";
            string actions = involveInActions ? "Želim da se priključim akcijama." : "";
            string body = $"Ime: {firstName}\n Prezime: {lastName}\n Email: {email} \n Poruka: {messageText} \n {actions}";

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
                if(attachments != null)
                {
                    foreach (var file in attachments)
                    {
                        if (file != null && file.ContentLength > 0)
                        {
                            try
                            {
                                string fileName = Path.GetFileName(file.FileName);
                                var attachment = new Attachment(file.InputStream, fileName);
                                message.Attachments.Add(attachment);
                            }
                            catch (Exception) { }
                        }
                    }
                }

                smtp.Send(message);
            }
        }
    }
}
