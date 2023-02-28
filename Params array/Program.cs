using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 1, 2, 3, 4, 5, 6 };
            Func1(ar);
            Func2(ar);//params parameter.
            Func3(); // no arguments passed, in such cases receiving function must be , params parameted.
            Func4(1, 2, 3, 4);
        }
        public static void Func1(int[] ar)
        {
            Console.WriteLine("There are {0} elements Fun1", ar.Length);
            foreach(int i in ar)
            { 
                Console.WriteLine(i);
            }
        }
        public static void Func2(params int[] ar)
        {
            Console.WriteLine("There are {0} elements in Fun2", ar.Length);
            foreach (int i in ar)
            {
                Console.WriteLine(i);
            }
        }
        public static void Func3(params int[] ar)
        {
            Console.WriteLine("There are {0} elements in Fun3", ar.Length);
            foreach (int i in ar)
            {
                Console.WriteLine(i);
            }
        }
        // params parameter must be last parameter in among all parameters passed to function.
        public static void Func4(int X ,params int[] ar)
        {
            Console.WriteLine("value of X :"+ X);
            Console.WriteLine("There are {0} elements in Fun2", ar.Length);
            foreach (int i in ar)
            {
                Console.WriteLine(i);
            }
        }
    }
}
