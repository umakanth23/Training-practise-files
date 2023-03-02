using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Password
{
    static void Main(string[] args)
    {
        string password = Console.ReadLine();
        char[] notAllowedSymbols = { '!', '#', '$', '%', '&', '(', ')', '*', ',', '+', '-' };

        bool present = false;
        foreach (char ch in notAllowedSymbols)
        {
            if (password.Contains(ch))
            {

                present = true;
                break;
            }
        }
        if(present)
        {
            Console.WriteLine("Invalid");
        }
        else
        {
            Console.WriteLine("Valid");
        }
    }
}
