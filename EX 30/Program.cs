using System;

namespace EX_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IMPRIMIR NÚMEROS IMPARES CONTENIDOS DEL 201 AL 499");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Pulse ENTER para continuar");

            int i, impar = 0;
            for (i = 201; i < 499; i++)
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
