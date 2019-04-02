using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SmsService
    {
        public string Message { get; set; }
        public SmsService(string message)
        {
            Message = message;
        }
        public void SendMessage(string message, string to)
        {
            Console.Writeline($"SMS:{message} for {to}");
        }
    }
}
