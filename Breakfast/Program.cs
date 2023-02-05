using BreakfastExample;

Coffee cup = BreakfastAsync.PourCoffee();
Console.WriteLine("coffee is ready");

var eggsTask = BreakfastAsync.FryEggsAsync(2);
var baconTask = BreakfastAsync.FryBaconAsync(3);
var toastTask = BreakfastAsync.MakeToastWithButterAndJamAsync(2);

var breakfastTasks = new List<Task> { eggsTask, baconTask, toastTask };
while (breakfastTasks.Count > 0)
{
    Task finishedTask = await Task.WhenAny(breakfastTasks);
    if (finishedTask == eggsTask)
    {
        Console.WriteLine("eggs are ready");
    }
    else if (finishedTask == baconTask)
    {
        Console.WriteLine("bacon is ready");
    }
    else if (finishedTask == toastTask)
    {
        Console.WriteLine("toast is ready");
    }
    await finishedTask;
    breakfastTasks.Remove(finishedTask);
}

Juice oj = BreakfastAsync.PourOJ();
Console.WriteLine("oj is ready");
Console.WriteLine("Breakfast is ready!");