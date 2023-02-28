using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class A
{
    public int x;
    public int y;
    public void Add()
    {
        Console.WriteLine(x + y);
    }
}
public class B:A
{
    int z = 45;
    public void mul()
    {
        Console.WriteLine(x*y*z);
    }
}
class Program
{
    static void Main(string[] args)
    {
        B obj = new B();
        obj.x = 10;
        obj.y = 20;
        obj.Add();
        obj.mul();
    }
}

