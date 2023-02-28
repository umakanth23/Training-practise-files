using System;
using System.IO;

class A
{
    public static void Main()
    {
        Console.WriteLine("Exceptions Handling in C#");
        int x = 10;
        try
        {
            int res = x / 0;
            Console.WriteLine(res);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception is due to :"+ex.Message);
        }
        finally
        {
            Console.WriteLine("Finally block is executed all time");
        }
        check();
    }
    public static void check()
    {
        var x = 10;
        Console.WriteLine(x);
        var n = true;
        Console.WriteLine(n);
    }
    
}