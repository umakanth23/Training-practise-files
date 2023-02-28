using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void Dint(int x);
class Program
{   
    public static void peri(int x)
    {
        int res = x*4;
        Console.WriteLine("Perimeter of square with side {0} is {1}: " ,x, res);
    }
    public static void area(int x)
    {
        int res = x * x;
        Console.WriteLine("Area of square with side {0} is {1}: ",x , res);
    }
    public static void fun3(int x)
    {
        int res = x * x * x;
        Console.WriteLine("Cube of {0} is : {1}",x,res);
    }
    static void Main(string[] args)
    {
        Dint d1 = new Dint(area);
        d1(10);
        Dint d2 = new Dint(peri);
        d2(20);
        Dint d3 = new Dint(fun3);
        d3(30);

    }
}