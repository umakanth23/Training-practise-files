using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface I1
{
    void print(int x);
}
interface I2
{
    void print(int x);
}
public class Calculate : I1,I2
{
    void I1.print(int x)
    {
        int res = x * 10;
        Console.WriteLine("I1 interface :" + res);
    }
    void I2.print(int x)
    {
        int res = x * 100;
        Console.WriteLine("I2 interface :" + res);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Calculate c = new Calculate();
        ((I1)c).print(70);
        ((I2)c).print(70);
    }
}

