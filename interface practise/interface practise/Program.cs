using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



interface IProgram
{
    int perimeter(int side); // be default public
    int area(int side);

}
class square:IProgram
{
    public int perimeter(int side) // public method
    {
        return 4 * side;
    }
    public int area(int side)
    {
        return side * side;
    }
}
class main
{
    public static void Main()
    {
        square s = new square();
        int per =s.perimeter(10);
        int ar = s.area(10);
        Console.WriteLine("Area of Square :" + ar);
        Console.WriteLine("Perimeter of Square :" + per);
    }
}

