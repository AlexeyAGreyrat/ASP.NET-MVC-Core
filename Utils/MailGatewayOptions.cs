using System;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace Lesson9.Utils
{
    public sealed class MailGatewayOptions
    {
        public MailGatewayOptions()
        {
            Port = 465;
        }

        public string SenderName { get; set; }

        public string SMTPServer { get; set; }

        public int Port { get; set; }

        public string Sender { get; set; }

        public string Password { get; set; }
    }
}
