using System;

namespace EX_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IMPRIMIR NÚMEROS IMPARES CONTENIDOS DEL 1 AL 100");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Pulse ENTER para continuar");

            int i, impar = 0;
            for (i = 0; i < 100; i++)
            {
            if (i % 2 != 0)
            {
                Console.WriteLine("{0}|", i);
                impar++;
            }
            Console.WriteLine("\n\n");

            }
            Console.ReadLine();
        }
    }
}
