using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLesson
{
    public class EmailService : IMessageSender, ILogger
    {
        public string Message { get; set; }
        public string To { get; set; }

        void IMessageSender.Send(string message, string to)
        {
            // logika otpravki email cherez smtp
        }

        void ILogger.Send(string message, string to)
        {
            // logika otpravki email cherez smtp
        }

        public void Send(string message, string to)
        {
            (this as IMessageSender).Send(message, to);
            // gde to eshe
            (this as ILogger).Send(message, to);
        }

        public void ToDo()
        {
            // какой-то еще метод для чего то
        }
    }
}
