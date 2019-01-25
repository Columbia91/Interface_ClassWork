using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLesson
{
    public static class ServiceLocator
    {
        public static IMessageSender Sender
        {
            get
            {
                return new EmailService();
            }
        }
    }
}
