using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLesson
{
    public class SmsSender : IMessageSender
    {
        public string Message { get; set; }
        public string To { get; set; }

        public void Send(string message, string to)
        {
            // logika otpravki sms cherez internet
        }
    }
}
