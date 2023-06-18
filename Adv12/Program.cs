using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

var numArray = GenerateRandomArray();
var dict = FindDistinctElements(numArray);
var dublicates = FindDuplicates(dict);
var notDublicates = FindDuplicates(dict);

int[] GenerateRandomArray()
{
    var arr = new int[100000];
    for(int i = 0; i< arr.Length; i++)
    {
        var random = new Random().Next(1, 1000);
        arr[i] = random;
    }
    return arr;
}
Dictionary<int, int> FindDistinctElements(int[] arr)
{
    var dict = new Dictionary<int, int>();
    for(int i = 0; i < arr.Length; i++)
    {
        if (dict.ContainsKey(arr[i]))
        {
            dict[arr[i]]++;
        }
        else
        {
            dict.Add(arr[i], 1);
        }
    }
    return dict;
}
Dictionary<int, int> FindDuplicates(Dictionary<int, int> dict)
{
    var dublicates = new Dictionary<int, int>();
    foreach (var element in dict)
    {
        if(element.Value > 1)
            dublicates.Add(element.Key, element.Value);
    }
    return dublicates;
}
List<KeyValuePair<int, int>> FindMostDublicated(Dictionary<int,int> dict)
{
    var top25 = new List<KeyValuePair<int, int>> ();
    var max = new KeyValuePair<int, int>();
    int counter = 1;
    while (counter <= 25)
    {
        //foreach (var element in dict)
        //{
        //    if (element.Value > max.Value)
        //    {
        //        var isFound = false;
        //        foreach (var item in top25)
        //        {
        //            if (max.Key == item.Key)
        //            {
        //                isFound = true;
        //                break;
        //            }
        //        }
        //        if (!isFound)
        //            max = element;
        //    }
        //}
        //top25.Add(max);
        max = dict.Where(x => !top25.Contains(x)).Max();
        top25.Add(max);
    }
    return top25;
}
List<KeyValuePair<int, int>> FindMostDublicatedWithSorting(Dictionary<int, int> dict)
{
    var top25 = new List<KeyValuePair<int, int>>();
    top25 = dict.OrderBy(x => x.Value).Take(25).ToList();
    return top25;
}