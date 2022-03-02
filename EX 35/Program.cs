using System;

namespace EX_35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Con este programa usted podrá ver los números multiplos de 3 comprendidos entre 3 y 99.");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            for (int  n = 3;  n <= 99; n = n + 3)
            {
                Console.WriteLine(" ° " + n);
                Console.WriteLine("||||||||");
            }
            Console.ReadLine();
        }
    }
}
