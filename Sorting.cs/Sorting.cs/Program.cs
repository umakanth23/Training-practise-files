using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{   
    public static void swap(ref int x,ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
    public static void insertionSort(int[] ar)
    {
        int size = ar.Length;
        for(int i=1;i<size;i++)
        {
            int j = i - 1;
            int min = ar[i];
            while(j>=0 && ar[j] > ar[j+1])
            {
                ar[j + 1] = ar[j];
                j--;
            }
            ar[j + 1] = min;
        }
        Console.Write("After applying insertionSort Sort :");
        foreach (var i in ar)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
    public static void BubbleSort(int[]ar)
    {
        int size = ar.Length;
        for(int i=0;i<size-1;i++)
        {
            for(int j=0;j<size-i-1;j++)
            {
                if (ar[j] > ar[j+1])
                {
                    swap(ref ar[j], ref ar[j + 1]);
                }
            }
        }
        Console.Write("After applying Bubble Sort :");
        foreach(var i in ar)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
    public static void selectionSort(int[] ar)
    {
        int size = ar.Length;
        for(int i=0;i<size-1;i++)
        {
            int min = i;
            for(int j=i+1;j<size;j++)
            {
                if (ar[j] < ar[min])
                {
                    min = j;
                }
            }
            swap(ref ar[i], ref ar[min]);
        }
        Console.Write("After applying selectionSort :");
        foreach (var i in ar)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
    static void Main(string[] args)
    {

        Console.Write("Enter array size: ");
        int size = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter {0} array elements:", size);
        string str = Console.ReadLine();
        string[] strArray = str.Split(' ');
        size = strArray.Length;
        int[] ar = new int[size];
        for(int i=0;i<size;i++)
        {
            ar[i] = Convert.ToInt32(strArray[i]);
        }
        Console.Write("Original Array Elements are :");
        foreach(var i in ar)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        BubbleSort(ar);
        insertionSort(ar);
        selectionSort(ar);
    }
}
