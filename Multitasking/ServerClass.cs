using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multitasking
{
    internal class ServerClass
    {
        public void Method1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Thread.Sleep(5000);
                Console.WriteLine("Method-1* :" + i);
            }
        }

        public void Method2()
        {
            for (int i = 1; i <= 5; i++)
            {
                Thread.Sleep(10000);
                Console.WriteLine("Method-2*** :" + i);
            }
        }
        public void Method3()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method-3****** :" + i);
            }
        }
    }
}