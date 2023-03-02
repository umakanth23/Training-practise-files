using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Webpage
{
    public static int hits = 0;
    public int count = 1;
    public Webpage()
    {
        hits++;        
    }
    public void print()
    {
        Console.WriteLine("hits :" + hits);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Webpage w1 = new Webpage();
        w1.print();
        Webpage w2 = new Webpage();
        w2.print();
        Console.WriteLine(w1.count);
        Console.WriteLine(Webpage.hits);
    }
}

