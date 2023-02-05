using Generics;

string a = "AbC";
string b = "CDE";
Console.WriteLine($"a: {a}, b: {b}");
Exchanger<string> v1 = new Exchanger<string>();
v1.Swap(ref a, ref b);
Console.WriteLine($"a: {a}, b: {b}");
string s = v1.GetDefault();
Console.WriteLine(s);

int nr1 = 100;
int nr2 = 200;
Console.WriteLine($"nr1: {nr1}, nr2: {nr2}");
Exchanger<int> v2 = new Exchanger<int>();
v2.Swap(ref nr1, ref nr2);
Console.WriteLine($"nr1: {nr1}, nr2: {nr2}");
int d = v2.GetDefault();
Console.WriteLine(d);