using Devices;
using Devices.Interfaces;
using System.Numerics;

SamsungPhone phone = new SamsungPhone();
LGTv tv = new LGTv();
try
{  
    List<ISwitchable> switchables= new List<ISwitchable>();
    switchables.Add(phone);
    switchables.Add(tv);
    ISwitchable test = switchables[1];
    foreach(ISwitchable s in switchables)
    {
        s.SwitchOn();
    }
}
catch(OutOfMemoryException ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    //phone.SwitchOff();
}