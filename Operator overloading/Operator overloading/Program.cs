using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_overloading
{
    class Program
    {
        class Box
        {
            public int Height;
            public int Width;
            public Box(int h, int w)
            {
                Height = h;
                Width = w;
            }
            public static Box operator +(Box a, Box b)
            {
                int h = a.Height + b.Height;
                int w = a.Width + b.Width;
                Box res = new Box(h, w);
                return res;
            }
        }
        static void Main(string[] args)
        {
            Box b1 = new Box(14, 3);
            Box b2 = new Box(5, 7);
            Box b3 = b1 + b2;

            Console.WriteLine(b3.Height);
            Console.WriteLine(b3.Width);
        }
    }
}