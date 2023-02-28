using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        dict.Add(10, 100);
        dict.Add(20, 200);
        dict.Add(30, 300);
        foreach (var x in dict)
        {
            Console.WriteLine("Key : {0} & Value : {1}",x.Key, x.Value);
        }
        Console.WriteLine("----------------------");
        foreach(KeyValuePair<int, int> d in dict)
        {
            Console.WriteLine("Key-{0} && Value-{1}", d.Key, d.Value);
        }
        // checking whether Key 20 is present in "dict" or not.
        if(dict.ContainsKey(20))
        {
            Console.WriteLine("Key=20 is Present in Dictionary-dict");
        }
        dict.Add(50, 500);
        int count = dict.Count();
        Console.WriteLine("Count of Dictionary is : {0}", count);
        //removing key 30 from dict:
        dict.Remove(30);
        if(dict.ContainsKey(30))
        {
            Console.WriteLine("Key=30 is Present in Dictionary-dict");
        }
        else
        {
            Console.WriteLine("Key=30 is removed from Dictionary-dict");
        }
        //clear() , removes all elements from dict ;
        // Count fun gives , size of dict d;
    }
}

