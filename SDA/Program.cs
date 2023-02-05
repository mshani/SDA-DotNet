int[] numbers = { 1, 2, 3, 4, 5, 7, 1, 3, 0, 7, 9, 3 };

Dictionary<int, int> result = new Dictionary<int, int>();
foreach(int nr in numbers)
{
    if(!result.TryAdd(nr, 1))
    {
        result[nr]++;
    };
}

foreach (KeyValuePair<int, int> element in result)
{
    Console.WriteLine(element.Key + " => "+ element.Value);
}
















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
//    nr = nr/ 2;
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
