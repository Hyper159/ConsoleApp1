using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Enter a positive integer: ");
            n = Int32.Parse(Console.ReadLine());

            if (n % 2 == 0) //n is even
            {
                n = n / 2;
            }
            else
            {
                n = 3 * n + 1;
            }

            Console.WriteLine("The final value of n is " + n);
        }
    }
}
