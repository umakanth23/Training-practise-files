using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class read_Write
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hey Buddy , Learning Csharp");
        string name = Console.ReadLine();
        Console.WriteLine("You are "+name);
        string wish = "!GoodMorning";
        Console.WriteLine("Hey {0} {1}", name, wish);
    }
}

