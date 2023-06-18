using Adv21;

List<char> chars = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
var list = Extender.GetEveryNthElement(chars, 0, 0);
foreach (char c in list)
{
    Console.Write($"{c} ");
}
Console.WriteLine();
List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
var list2 = Extender.GetEveryNthElement(ints, 2, 2);
foreach (int c in list2)
{
    Console.Write($"{c} ");
}