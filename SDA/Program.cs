//int[] numbers = { 1, 2, 3, 4, 5, 7, 1, 3, 0, 7, 9, 3 };

//Dictionary<int, int> result = new Dictionary<int, int>();
//foreach(int key in numbers)
//{
//    if(!result.TryAdd(key, 1))
//    {
//        result[key]++;
//    };
//}

//foreach (KeyValuePair<int, int> element in result)
//{
//    Console.WriteLine(element.Key + " => "+ element.Value);
//}



//using System.Xml.Linq;

//string[] basket =
//{"apple", "cherry", "grapes", "grapes", "apple", "orange"};

//using SDA;
//using System.Globalization;

//Dictionary<string, int> fruits = new Dictionary<string, int>();

//foreach (string fruit in basket)
//{
//    if(!fruits.TryAdd(fruit, 1))
//    {
//        fruits[fruit]++;
//    }
//}

//foreach (var fruit in fruits)
//{
//    Console.WriteLine(fruit.Key + " => " + fruit.Value);
//}



//int candies = 100;

//Queue<int> requests = new Queue<int>();
//requests.Enqueue(10);
//requests.Enqueue(20);
//requests.Enqueue(30);
//requests.Enqueue(10);
//requests.Enqueue(5);
//requests.Enqueue(12);
//requests.Enqueue(5);
//requests.Enqueue(2);
//requests.Enqueue(10);

//while (candies > 0 && requests.Count > 0)
//{
//    var quantity = requests.Dequeue();
//    if(candies - quantity >= 0)
//    {
//        candies = candies - quantity;
//        Console.WriteLine($"{quantity} candies sold -- remaining: {candies}");
//    }
//    else
//    {
//        Console.WriteLine($"Request cannot be served:  {quantity}");
//    }
//}













//string value = Console.ReadLine();
//try
//{
//    uint nr = Convert.ToUInt32(value);
//    double sqrt = Math.Sqrt(nr);
//    Console.WriteLine("Square root is: " + sqrt);
//}
//catch (Exception e)
//{
//    Console.WriteLine("Invalid number");
//}
//finally
//{
//    Console.WriteLine("Goodbye");
//}












//string value = Console.ReadLine();
//int nr = Convert.ToInt32(value);

//Stack<int> stack = new Stack<int>();

//while (nr > 0)
//{
//    int r = nr % 2;
//    stack.Push(r);
//    nr = nr / 2;
//}
//Console.Write("Binary:");
//foreach (int r in stack)
//{
//    Console.Write(r);
//}











//string value = Console.ReadLine();
//string[] split = value.Split('.');
//string fileExtension = split[1];

//Dictionary<string, string> documentTypes = new Dictionary<string, string>();
//documentTypes.Add("doc", "MS Word");
//documentTypes.Add("docx", "MS Word 2003");
//documentTypes.Add("pdf", "PDF");
//documentTypes.Add("json", "JSON");
//documentTypes.Add("js", "Javascript");
//documentTypes.Add("xls", "Excel");
//documentTypes["xls"] = "Excel2";

//bool isFound = (documentTypes.TryGetValue(fileExtension, out var description));
//bool isFound2 = documentTypes.ContainsKey(fileExtension);
//if (isFound)
//{
//    Console.WriteLine(description);

//}
//else
//{
//    Console.WriteLine("Unable to process this file");
//}

//foreach (KeyValuePair<string, string> element in documentTypes)
//{
//    Console.WriteLine(element.Key + ": "+ element.Value);
//}

//Dictionary<int, string> notat = new Dictionary<int, string>();
//notat.Add(1, "Dobet");
//notat.Add(2, "Mjaftueshem");
//notat.Add(3, "A.k");
//notat.Add(4, "A.sh.k");
//notat.Add(5, "A.sh");
//Console.WriteLine(notat[4]);
//var my1 = new MyGenericClass<string>();
//my1.Add("a");
//my1.Add("b");
//my1.Add("c");
//my1.Count();
//my1.Print();
//public class MyGenericClass<T>{
//    private List<T> listeMeGjona = new List<T>();
//    public void Add(T element){
//        listeMeGjona.Add(element);
//    }
//    public int Count(){
//        return listeMeGjona.Count;
//    }
//    public void Print(){
//        foreach(T item in listeMeGjona)
//        {
//            Console.WriteLine(item);
//        }
//    }
//};




//var my2 = new MyGenericClass<int>();
//var m3 = new MyGenericClass<Person>();
//var m4 = new MyGenericClass<Drejkendesh>();



//string[] myArr = { "test0","test1", "test2", "test3" };

//for (int i = 0;i < myArr.Length; i++)
//{
//    Console.WriteLine(myArr[i]);
//}

//foreach(string word in myArr) { Console.WriteLine(word); }

Parent parent = new Parent();
parent.Display();
Child child = new Child();
child.Display();   

class Parent
{
    public virtual void Display()
    {

        Console.WriteLine("Parent");
    }
}

class Child : Parent
{
    public override void Display()
    {

        Console.WriteLine("Child");
    }
    public void Display2()
    {
        Console.WriteLine("Child 2");
    }
}


