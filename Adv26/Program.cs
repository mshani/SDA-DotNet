using Adv26;
CoffeeMachine coffeeMachine = new CoffeeMachine(0);
Thread monitoringThread = new Thread(coffeeMachine.MonitorWaterTank);
Thread brewingThread = new Thread(coffeeMachine.StartBrewing);

monitoringThread.Start();
brewingThread.Start();

// Simulate water refill after some time
Thread.Sleep(6000);
coffeeMachine.RefillWaterTank(5);

brewingThread.Join();
monitoringThread.Join();
Console.WriteLine("Coffee making simulation completed.");
