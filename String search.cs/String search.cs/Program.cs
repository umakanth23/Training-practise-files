using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        int size;
        Console.Write("Enter no.of strings :");
        size =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter {0} string values :",size);
        List<string> l = new List<string>();
        for (int i=0;i<size;i++)
        {
            string s;
            s = Console.ReadLine();
            l.Add(s);
        }
        bool found = false;
        Console.Write("Enter Key :");
        string key = Console.ReadLine();
        foreach(var x in l)
        {
            if(x == key)
            {
                Console.WriteLine("Key is Found");
                return;
            }
        }
        
        Console.WriteLine("Key is Not found");
        
        
    }
}

