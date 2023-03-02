using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        string text = "This is some text about a dog. The word dog appears in this text a number of times. This is the end.";
        Console.WriteLine(text);
        text = text.Replace("dog", "cat");
        Console.WriteLine(text);
        text = text.Substring(0, text.IndexOf(".") + 1);
        Console.WriteLine(text);
        
    }
}
