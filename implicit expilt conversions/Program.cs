using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {   
        //implicit conversions.
        int i = 268;
        float f = i;
        Console.WriteLine(f);

        //Explicit Conversions.
        float d = 345.33F;
        int j = (int)d;
        int p = Convert.ToInt32(d);
        Console.WriteLine(j);
        Console.WriteLine(p);

    }
}

