var swapper = new Swapper();
string s1 = "first";
string s2 = "second";
Console.WriteLine($"{s1}, {s2}");
swapper.Swap(ref s1, ref s2);
Console.WriteLine($"{s1}, {s2}");

int i1 = 5;
int i2 = 17;
Console.WriteLine($"{i1}, {i2}");
swapper.Swap(ref i1, ref i2);
Console.WriteLine($"{i1}, {i2}");

class Swapper
{
    public void Swap<T>(ref T value1, ref T value2)
    {
        T temp = value1; 
        value1 = value2;
        value2 = temp;
    }
}

class GenericList<T>
{
    private List<T> list = new List<T>();
    public void Insert<T>(T element)
    {

    }
}