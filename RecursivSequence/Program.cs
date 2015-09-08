using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecursivSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            fib(6);
            Console.ReadLine();
        }
            public static int fib(int n)
            {
                Console.WriteLine(n);
                if (n == 1)
                { return 1; }
                else if (n == 2)
                { return 2; }
                else
                { return fib(n - 1) + fib(n - 2); }
            
            }






    }
}
