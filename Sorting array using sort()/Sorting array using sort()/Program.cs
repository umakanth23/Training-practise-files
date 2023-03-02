using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sort_method
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("After Sorting :");
            Array.Sort(numbers);
            //your code goes here
            for (int i = 0; i < count; i++)
            {
                Console.Write(numbers[i]+" ");
            }
            Console.Write("\nAfter Sorting Week-days :");
            String[] str = { "mon", "tue", "wed", "thu", "fri", "sat" };
            Array.Sort(str);
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]+" ");
            }

        }
    }
}