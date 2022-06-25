using ALXCSharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharp.Models
{
    public class EmailMessage
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Message { get; set; }

        public MessageStatus MessageStatus { get; set; }

        public EmailMessage(string from, string to, string message, MessageStatus status)
        {
            From = from;
            To = to;
            Message = message;
            MessageStatus = status;

        }

        public void ChangeStatus(MessageStatus status)
        {
            MessageStatus = status;
            Console.WriteLine($"Status changed to {MessageStatus}");
        }
    }
}
