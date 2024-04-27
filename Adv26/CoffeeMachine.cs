using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv26
{
    public class CoffeeMachine
    {
        private int tankCapacity = 9;
        private int coffeCapacity = 3;
        private int waterLevel;
        private bool brewing;
        private readonly object lockObject = new object();
        private ManualResetEvent waterRefilledEvent = new ManualResetEvent(false);

        public CoffeeMachine(int waterLevel)
        {
            this.waterLevel = waterLevel;
            this.brewing = false;
        }
        public void StartBrewing()
        {
            lock (lockObject)
            {
                brewing = true;
                Console.WriteLine("Coffee brewing started.");
            }

            // Simulate coffee brewing process
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Brewing... {i + 1}s");
            }

            lock (lockObject)
            {
                brewing = false;
                Console.WriteLine("Coffee brewing finished.");
            }
        }

        public void MonitorWaterTank()
        {
            while (true)
            {
                lock (lockObject)
                {
                    if (!brewing && waterLevel == 0)
                    {
                        Console.WriteLine("Water tank is empty. Brewing stopped.");
                        waterRefilledEvent.Reset();
                        Monitor.Wait(lockObject); // Wait for water to be refilled
                        Console.WriteLine("Water tank refilled. Resuming brewing.");
                    }
                }

                // Simulate checking water level periodically
                Thread.Sleep(2000);

                lock (lockObject)
                {
                    if (!brewing && waterLevel < coffeCapacity)
                    {
                        Console.WriteLine("Water level is low. Refill the water tank.");
                    }
                }
            }
        }

        public void RefillWaterTank(int amount)
        {
            lock (lockObject)
            {
                waterLevel += amount;
                if (waterLevel > tankCapacity)
                {
                    waterLevel = tankCapacity;
                }

                Console.WriteLine($"Water tank refilled. Current water level: {waterLevel}/{tankCapacity}");
                waterRefilledEvent.Set();
                Monitor.Pulse(lockObject); // Notify brewing thread that water is refilled
            }
        }
    }

}
