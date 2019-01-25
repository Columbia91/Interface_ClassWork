using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageSender service = ServiceLocator.Sender;
            service.Send("text", "to");
        }
    }
}
