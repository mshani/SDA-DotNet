using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multitasking
{
    internal class ThreadWithState
    {
        private string boilerplate;
        private int numberValue;

        // The constructor obtains the state information.
        public ThreadWithState(string text, int number)
        {
            boilerplate = text;
            numberValue = number;
        }

        public void ThreadProc()
        {
            Console.WriteLine(boilerplate, numberValue);
        }
    }

}
