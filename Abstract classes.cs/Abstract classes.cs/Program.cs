using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Triangle
{
    
    public abstract void perimeter();
    public abstract int area(int Base,int height);
    public void line()
    {
        Console.WriteLine("Executed Successfully");
    }
    
}
class Program : Triangle
{
    public override void perimeter()
    {
        int sideA = 10;
        int sideB = 8;
        int sideC = 6;
        Console.WriteLine("Perimeter is :" + (sideA + sideB + sideC));
    }
    public override int area(int Base, int height)
    {   
        return  (Base*height);        
    }
    static void Main(string[] args)
    {
        Program p = new Program();
        p.perimeter();
        Console.WriteLine("Area of Right angled Triangle is :" + p.area(8, 6));
    }
}

