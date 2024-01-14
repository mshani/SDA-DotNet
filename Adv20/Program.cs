using Adv20;

Joiner joiner = new Joiner("-");
List<int> ints = new List<int> { 10, 8, 3 };
Console.WriteLine(joiner.Join(ints));

List<double> doubles = new List<double> { 14.2, 9.3, 3.1 };
Console.WriteLine(joiner.Join(doubles));

List<string> strings = new List<string> { "loli", "coli", "test" };
Console.WriteLine(joiner.Join(strings));

List<bool> bools = new List<bool> { false, false, false };
Console.WriteLine(joiner.Join(bools));





