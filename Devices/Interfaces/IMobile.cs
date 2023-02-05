using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices.Interfaces
{
    internal interface IMobile : IVolume, IChargable, ISwitchable, IInternet
    {
        void InsertSim();
        void InstallApp(string appName);
        void UnInstallApp(string appName);

    }
}
