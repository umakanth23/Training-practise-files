using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    public static int Binary_search(int[] ar,int key)
    {
        int size = ar.Length;
        int found = -1;
        int low = 0, high = size - 1;
        while(low<=high)
        {
            int mid = (low+high)/ 2;

            if (ar[mid]==key)
            {
                found = mid;
                return found;
            }
            if (ar[mid]<key)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return found;
    }
    static void Main(string[] args)
    {
        Console.Write("Enter array size: ");
        int size = Convert.ToInt32( Console.ReadLine());
        int[] ar = new int[size];
        Console.Write("Enter {0} array elements : ",size);
        for(int i=0;i<size;i++)
        {
            ar[i] = Convert.ToInt32(Console.ReadLine()); // this will lead to give input in every next line.
        }
        Console.Write("Enter search key element :");
        int key = Convert.ToInt32(Console.ReadLine());
        int found = Binary_search(ar, key);
        if(found!=-1)
        {
            Console.Write("Key {0} present in the array at index {1}", key, found);
        }
        else
        {
            Console.Write("It is not present in the array");
        }
    }
}

