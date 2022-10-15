using Leuka.Models.Generated;

namespace Leuka.Core.Models
{
    public class EmailSettings
    {
        public EmailSettings(ISiteSettings settings)
        {
            this.ServerAddress = settings.ServerAddress;
            this.Port = int.Parse(settings.Port);
            this.Password = settings.SenderEmailPassword;
            this.SenderEmailAddress = settings.SenderEmailAddress;
            this.ReceiverEmailAddress = settings.ReceiverEmailAddress;
        }
        public string ServerAddress { get; set; }

        public int Port { get; set; }

        public string SenderEmailAddress { get; set; }

        public string Password { get; set; }

        public string ReceiverEmailAddress { get; set; }
    }
}
