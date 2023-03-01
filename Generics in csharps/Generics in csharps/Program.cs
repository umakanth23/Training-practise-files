using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class calculate
{
    public bool areEqual<T>(T x,T y) // making function generic
    {
        if(x.Equals(y))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public  void swap<T>(ref T x,ref T y)
    {
        T temp = x;
        x = y;
        y = temp;
    }

}
public class Maths<T> // by this way , we make class to Generic.
{
   

}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("------------Generics---------------");
        calculate c = new calculate();
        int x = 30, y = 60;
        Console.WriteLine("Before swapping x={0} y={1}", x, y);
        c.swap(ref x,ref y);
        Console.WriteLine("After swapping x={0} y={1}", x, y);
        if(c.areEqual(45, 90))
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not Equal");
        }
        if(c.areEqual<char>('M','M'))
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not Equal");
        }
        char ch1 = 'P', ch2 = 'p';
        
        Console.WriteLine("Before swapping x={0} y={1}", ch1, ch2);
        c.swap<char>(ref ch1, ref ch2);
        Console.WriteLine("After swapping x={0} y={1}", ch1, ch2);
    }
}

