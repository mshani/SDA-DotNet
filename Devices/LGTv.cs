using Devices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices
{
    internal class LGTv : ISmartTv
    {
        public void ConnectToInternet()
        {
            Console.WriteLine("Connecting to internet");
        }

        public void DisconenctInternet()
        {
            Console.WriteLine("Disconnecting internet");
        }

        public void InstalApp(string appName)
        {
            Console.WriteLine("Installing app :" + appName);
        }
        public void UnInstalApp(string appName)
        {
            Console.WriteLine("Removing app: " + appName);
        }

        public void PluggedIn()
        {
            Console.WriteLine("Plugged in");
        }

        public void PuggledOut()
        {
            Console.WriteLine("Plugged out");
        }

        public void RegisterChannels()
        {
            Console.WriteLine("Channels registered");
        }

        public void ReturnToPreviousChannel()
        {
            Console.WriteLine("Returning to previous channel");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Switching off...");
        }

        public void SwitchOn()
        {
            Console.WriteLine("Switching on tv");
        }

        public void TurnOffVolume()
        {
            Console.WriteLine("Volume down...");
        }

        public void TurnOnVolume()
        {
            Console.WriteLine("Volume up...");
        }
    }
}
