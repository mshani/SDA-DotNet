using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifications
{
    internal interface IEmail
    {
        void SendEmail(string email, string emailAddress);
        string ReceiveEmail();
    }
}
