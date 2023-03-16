using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        class Shape
        {
            public virtual void Draw()
            {
                Console.WriteLine("Base Draw");
            }
        }
        class Circle : Shape
        {
            public override void Draw()
            {
                // draw a circle...
                Console.WriteLine("Circle Draw");
            }
        }
        class Rectangle : Shape
        {
            public override void Draw()
            {
                // draw a rectangle...
                Console.WriteLine("Rect Draw");
            }
        }
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.Draw();

            Shape r = new Rectangle();
            r.Draw();
            Shape s = new Shape();
            s.Draw();
        }
    }
}
