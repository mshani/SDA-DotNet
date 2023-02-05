using Multitasking;
ServerClass serverObject = new ServerClass();

Console.WriteLine("Main Thread Started");

Thread t1 = new Thread(serverObject.Method1)
{
    Name = "Thread 1"
};
Thread t2 = new Thread(serverObject.Method2)
{
    Name = "Thread 2"
};
Thread t3 = new Thread(serverObject.Method3)
{
    Name = "Thread 3"
};
//Executing the methods
t1.Start();
t2.Start();
t3.Start();
Console.WriteLine("Main Thread Ended");

