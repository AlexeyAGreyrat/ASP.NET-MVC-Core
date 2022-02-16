using System;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace Lesson9.Utils
{
    public sealed class Message
    {
        public string Subject { get; set; }

        public string Body { get; set; }

        public string To { get; set; }

        public string Name { get; set; }

        public bool IsHtml { get; set; }
    }
}
