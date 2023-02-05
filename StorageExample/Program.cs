using StorageExample;

var storage = new Storage();
storage.AddStorage("std1", "a");
storage.AddStorage("std1", "b");
storage.AddStorage("std1", "b");
storage.AddStorage("std2", "c");
storage.AddStorage("std2", "a");

storage.PrintValues("std1");
var keys = storage.FindKeys("a");
if(keys != null)
{
    Console.Write("Keys: ");
    foreach (var element in keys)
    {
        if(keys.Last() != element)
        {
            Console.Write(element + ", ");
        }
        else
        {
            Console.Write(element);
        }
    }
    Console.WriteLine();
}


