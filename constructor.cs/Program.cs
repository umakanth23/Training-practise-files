using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    //constructor 
    int x;
    int y;
    Program()
    {
        x = 30;
        y = 40;
    }
    void display()
    {
        Console.WriteLine("Value of X :" + x);
        Console.WriteLine("Value of y :" + y);

    }
    void Perimeter()
    {
        System.Console.WriteLine("Perimater of rect is:" + ((x + y) * 2));
    }
    public static void Area()
    {
        Program obj = new Program();
        Console.WriteLine("Area of rect is :" + (obj.x * obj.y)); // we are accessing non static varibles in static method 
        // hence we require object to access the variables.
    }
    static void Main(string[] args)
    {
        //creating an object of class - Program.
        Program p = new Program();
        p.display();
        p.Perimeter();
        Area();
    }
}

