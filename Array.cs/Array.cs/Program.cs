using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
{
    static void Main(string[] args)
    {
        // declaring an array ;
        int[] ar1 = new int[5];
        int size1 = 5;

        for (int i = 0; i < 5; i++)
        {
            ar1[i] = (i+5) * 10;
        }
        Console.Write("Array1 Elements are :");
        for (int i = 0; i < ar1.Length; i++)
        {
            Console.Write(ar1[i] + " ");
        }
        Console.WriteLine();
        int[] ar2 = { 10, 20, 30, 40, 50, };
        int size2 = ar2.Length;

        Console.Write("Array2 Elements are :");
        for (int i = 0; i <size2; i++)
        {
            Console.Write(ar2[i] + " ");
        }
        Console.WriteLine();
        int[] ar3 = new int[5];

        for(int i=0;i<5;i++)
        {
            ar3[i] = ar2[i] + ar1[i];
        }
        Console.Write("Array3 Elements are :");
        for(int i=0;i<ar3.Length;i++)
        {
            Console.Write(ar3[i]+" ");
        }
        Console.WriteLine();

        int[] ar4 = new int[] { 100, 200, 300, 400 };

        // char array;
        char[] ch = { 'a', 'b', 'c', 'd' };
        Console.WriteLine("Elements of char array :");
        for(int i=0;i<ch.Length;i++)
        {
            Console.Write(ch[i] + " ");
        }    
        Console.Write("\nChanged to :");
        for (int i = 0; i < ch.Length; i++)
        {
            int x = ch[i] -32;
            char c = (char)x;
            Console.Write((c) + " ");
        }
        // string array;


    }
}

