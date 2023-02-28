using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface Isearch
{
    bool binarySearch(int[] ar,int T);
    bool linearSearch(int[] ar,int T);   
}
public interface Isort
{
    void sortArray(ref int[] ar);
    void swap(ref int x,ref int y);
}
public class data:Isearch,Isort
{
    public bool binarySearch(int[] ar,int T)
    {
        sortArray(ref ar);
        int size = ar.Length;
        int low = 0, high = size - 1;
        while(low<=high)
        {
            int mid = (low+high)/ 2;
            if (ar[mid]==T)
            {
                return true;
            }
            if (ar[mid]<T)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return false;
    }
    public bool linearSearch(int[] ar,int T)
    {
        foreach(var x in ar)
        {
            if(x==T)
            {
                return true;
            }
        }
        return false;
    }
    public void sortArray(ref int[] ar)
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
        Console.Write("Sorted Elements are: ");
        foreach(var x in ar)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();
    }
    public void swap(ref int x,ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
}
public class Program
{
    static void Main(string[] args)
    {
        data d = new data();
        int[] ar = new int[] { 83, 32, 5, 96, 17, 20, 9, 13, 67, 56 };
        if( d.binarySearch(ar, 21))
        {
            Console.WriteLine("21 is present");
        }
        else
        {
            Console.WriteLine("21 is not present");
        }

        if(d.linearSearch(ar,32))
        {
            Console.WriteLine("56 is present");
        }
        else
        {
            Console.WriteLine("56 is not present");
        }
    }
}

