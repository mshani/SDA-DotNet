﻿////using Generics;

////string a = "AbC";
////string b = "CDE";
////Console.WriteLine($"a: {a}, b: {b}");
////Exchanger<string> v1 = new Exchanger<string>();
////v1.Swap(ref a, ref b);
////Console.WriteLine($"a: {a}, b: {b}");
////string s = v1.GetDefault();
////Console.WriteLine(s);

////int nr1 = 100;
////int nr2 = 200;
////Console.WriteLine($"nr1: {nr1}, nr2: {nr2}");
////Exchanger<int> v2 = new Exchanger<int>();
////v2.Swap(ref nr1, ref nr2);
////Console.WriteLine($"nr1: {nr1}, nr2: {nr2}");
////int d = v2.GetDefault();
////Console.WriteLine(d);






//var ex = new Exchanger2<int>();
//ex.Item1 = 3;
//ex.Item2 = 4;
//ex.Swap();
//Console.WriteLine($"item1:{ex.Item1}, item2:{ex.Item2}");

//var stringExchanger = new Exchanger2<string>();
//stringExchanger.Item1 = "Filani";
//stringExchanger.Item2 = "Fisteku";
//stringExchanger.Swap();
//Console.WriteLine($"item1:{stringExchanger.Item1}, item2:{stringExchanger.Item2}");

//class Exchanger2<T>{
//    public T Item1;
//    public T Item2;
//    public void Swap(){
//        T temp = Item1;
//        Item1 = Item2;
//        Item2 = temp;
//    }
//}

//using Generics;

//string a = "AbC";
//string b = "CDE";
//Console.WriteLine($"a: {a}, b: {b}");
//Exchanger<string> v1 = new Exchanger<string>();
//v1.Swap(ref a, ref b);
//Console.WriteLine($"a: {a}, b: {b}");
//string s = v1.GetDefault();
//Console.WriteLine(s);

//int nr1 = 100;
//int nr2 = 200;
//Console.WriteLine($"nr1: {nr1}, nr2: {nr2}");
//Exchanger<int> v2 = new Exchanger<int>();
//v2.Swap(ref nr1, ref nr2);
//Console.WriteLine($"nr1: {nr1}, nr2: {nr2}");
//int d = v2.GetDefault();
//Console.WriteLine(d);
