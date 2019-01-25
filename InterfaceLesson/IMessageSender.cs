using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLesson
{
    public interface IMessageSender
    {
        string Message { get; set; }
        string To { get; set; }
        void Send(string message, string to);
    }
}
