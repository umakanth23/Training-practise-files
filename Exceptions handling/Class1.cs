using System;

class A
{
    public static void Main()
    {
        int x = 10;
        try
        {
            int res = x / 0;
            Console.WriteLine(res);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.message);
        }
        finally
        {
            Console.WriteLine("Finally block is executed all time");
        }
    }
}