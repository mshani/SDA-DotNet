using Devices.Interfaces;

namespace Devices
{
    internal class SamsungPhone : IMobile
    {
        bool isSwitchedOn = false;
        List<string> installedApps = new List<string>();
        public void ConnectToInternet()
        {
            if (!isSwitchedOn)
            {
                Console.WriteLine("Please switch on the phone first");
            }
            else
            {
                Console.WriteLine("Connecting to internet");
            }
        }

        public void DisconenctInternet()
        {
            if (!isSwitchedOn)
            {
                Console.WriteLine("Please switch on the phone first");
            }
            else
            {
                Console.WriteLine("Disconnecting internet");
            }
        }

        public void InsertSim()
        {
            Console.WriteLine("Sim inserted");
        }

        public void InstallApp(string appName)
        {
            if (!isSwitchedOn)
            {
                Console.WriteLine("Please switch on the phone first");
                return;
            }

            bool isInstalled = installedApps.Contains(appName);
            if(isInstalled) 
            {
                Console.WriteLine("App :" + appName + " is already installed");
                return;             
            }
            else
            {
                if(installedApps.Count <= 2)
                {
                    installedApps.Add(appName);
                }
                else
                {
                    throw new OutOfMemoryException("Cannot install :" + appName);
                }
                
            }
            Console.WriteLine("Installing app :" + appName);
        }

        public void StartCharging()
        {
            Console.WriteLine("Start charging... ");
        }

        public void StopCharging()
        {
            Console.WriteLine("Stopped charging");
        }

        public void SwitchOff()
        {
            if (!isSwitchedOn)
            {
                Console.WriteLine("Please switch on the phone first");
            }
            else
            {
                Console.WriteLine("Switching off...");
            }
            
        }

        public void SwitchOn()
        {
            if (isSwitchedOn)
            {
                Console.WriteLine("Phone is already switched on");
            }
            else { 
                isSwitchedOn = true;
                Console.WriteLine("Switching on phone");
            }
        }

        public void TurnOffVolume()
        {
            if (!isSwitchedOn)
            {
                Console.WriteLine("Please switch on the phone first");
            }
            else { 
                Console.WriteLine("Volume down...");
            }
        }

        public void TurnOnVolume()
        {
            if (!isSwitchedOn)
            {
                Console.WriteLine("Please switch on the phone first");
            }
            else
            {
                Console.WriteLine("Volume up...");
            }
        }

        public void UnInstallApp(string appName)
        {
            if (!isSwitchedOn)
            {
                Console.WriteLine("Please switch on the phone first");
            }
            else
            {
                Console.WriteLine("Removing app: " + appName);
            }
        }
    }
}
