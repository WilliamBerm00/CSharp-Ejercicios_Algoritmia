using System;

namespace EX_37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Con este programa usted podrá ver los números multiplos de 5 comprendidos entre 5 y 100.");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            for (int  n = 5;  n <= 100; n = n + 5)
            {
                Console.WriteLine(" ° " + n);
                Console.WriteLine("||||||||");
            }
            Console.ReadLine();
        }
    }
}
