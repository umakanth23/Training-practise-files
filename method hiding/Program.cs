using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class parent
{
    public parent()
    {
        Console.WriteLine("Parent Constructor");
    }
    parent(int x)
    {
        Console.WriteLine("Parent paramterized constructor");
    }
    public void print()
    {
        Console.WriteLine("Parent Func");
    }
}
public class child : parent
{
    public child()
    {
        Console.WriteLine("Child constructor");
    }
    public new void print()
    {   
        base.print();// to call base class - print() method.
        Console.WriteLine("Child Func");
    }
}
class Program
{
    
    static void Main(string[] args)
    {
        child c = new child();
        c.print();

    }
}
