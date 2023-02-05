using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifications
{
    internal interface IText
    {
        void SendText (string text, string phoneNumber);
        string ReceivedText();
    }
}
