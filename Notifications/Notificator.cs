using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Notifications
{
    internal class Notificator : IText, IEmail
    {
        public string ReceivedText(){
            return "Text Received";
        }
        public string ReceiveEmail()
        {
            return "Email Received";
        }
        public void SendEmail(string email, string emailAdress)
        {
            Console.WriteLine("Emailing: " + emailAdress);
            Console.WriteLine(email);
        }
        public void SendText(string text, string phoneNumber){
            Console.WriteLine("Texting: "+ phoneNumber);
            Console.WriteLine(text);
        }
    }
}
