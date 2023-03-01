using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum pool
{
   p, // as p is first letter , so it holds value =0;
   q, // q value will be , q = p+1 ,Hence q = 1;
   r, // similarly, r = p+2;

   s=15, // as we are changing s value , so value(s) will be 15.
   t,    // t holds 16;
   v=20  // v holds 20;
}
namespace Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Names - Values");
            string[] str = (string[])Enum.GetNames(typeof(pool));
            
            int[] values = (int[])Enum.GetValues(typeof(pool));

            for(int i= 0;i < str.Length;i++)
            {
                Console.WriteLine("   "+str[i] + " - " + values[i]);
            }

            // accessing single value from enums.

            Console.WriteLine("Using enum class name - accessing Names-values");
            pool pp = new pool();

            Console.WriteLine(pool.t + " " + (int)pool.t);
            Console.WriteLine(pool.v + " " + (int)pool.v);

        }
    }
}
