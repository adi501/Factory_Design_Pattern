using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace With_Factory_Design_Pattern
{
    public class VoiceNotification:INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending Voice Notification: " + message);
        }
    }
}
