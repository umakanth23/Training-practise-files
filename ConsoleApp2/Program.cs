using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {   
        public static int checkOperator(char ch)
        {   
            
            //char opr = Convert.ToChar(Console.ReadLine());
            List<char> L = new List<char>(5);
            L.Add('+');
            L.Add('-');
            L.Add('*');
            L.Add('/');
            L.Add('%');
            int ind = L.IndexOf(ch);
            if (ind == -1)
            {
                do
                {


                    Console.WriteLine("entered wrong operator");
                    Console.WriteLine("Enter Correct operator");
                    ch = Convert.ToChar(Console.ReadLine());
                    ind = L.IndexOf(ch);
                } while (ind == -1);
            }
            return ind;
        }
        public static int performOperation(int n1,int opr,int n2)
        {
            int res = 0;
            switch(opr)
            {
                case 0: res= n1+n2;
                    break;
                case 1: res= n1 - n2;
                    break;
                case 2: res= n1 * n2;
                    break;
                case 3: res= n1 / n2;
                    break;
                case 4: res= n1 % n2;
                    break;
            }
            return res;
        }
        static void Main(string[] args)
        {
            int count = 1;
            Console.Write("Enter {0} number:",count++);
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter operator:");
            char opr = Convert.ToChar(Console.ReadLine());
            int ind = checkOperator(opr);
            Console.Write("Enter {0} number:", count++);
            int n2 = Convert.ToInt32(Console.ReadLine());
            int res = performOperation(n1, ind, n2);
            Console.WriteLine("Result : " + res);
        }
    }
}
