using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        List<int> L = new List<int>(3);
        L.Add(15);
        L.Add(30);
        L.Add(45);
        L.Add(60);
        L.Add(30);
        foreach(var x  in L)
        {
            Console.WriteLine(x);
        }
        Console.WriteLine("Size of List-L :"+L.Count);
        //searching for an element
        if(L.Contains(30))
        {
            Console.WriteLine("30 is present in List");
        }
        else
        {
            Console.WriteLine("30 is not present in the List");
        }
        if (L.Contains(40))
        {
            Console.WriteLine("40 is present in List");
        }
        else
        {
            Console.WriteLine("40 is not present in the List");
        }
        //Exists() function.
        int ind = L.IndexOf(30);
        Console.WriteLine("FirstIndexOf(30):" + ind);
        int last = L.LastIndexOf(30);
        Console.WriteLine("LastIndexOf(30):" + last);
        int size = L.Count;
        Console.WriteLine("Size of List L :" + size);
        //remove
        L.Remove(45); //45 is removed;
        Console.WriteLine("List elements after 40 is removed : ");
        foreach(var x in L)
        {
            Console.Write(x + " ");
        }

        L.Clear();
        Console.WriteLine("Clearing the List ");
        Console.WriteLine("Size of List L :" + L.Count);
    } 
}

