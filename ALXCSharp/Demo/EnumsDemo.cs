using ALXCSharp.Enums;
using ALXCSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharp.Demo
{
    public class EnumsDemo
    {
        public static void Run()
        {
            EmailMessage message = new EmailMessage
                (
                "ka@op.pl",
                "lala@gmail.com",
                "Hejka",
                MessageStatus.DRAFT
                );

            message.ChangeStatus(MessageStatus.SENT);
        }
    }
}
