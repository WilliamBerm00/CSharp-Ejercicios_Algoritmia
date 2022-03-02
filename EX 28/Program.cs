using System;

namespace EX_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Con este programa usted podrá ver los números comprendidos entre 0 y 100.");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            for (int  x = 0;  x <= 1000; x++)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
