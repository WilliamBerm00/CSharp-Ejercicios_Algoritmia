using System;

namespace EX_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido, con este programa usted podrá determinar si el ejercicio que digitó es par o impar.");

            //declaración variable
            int var;

            //algoritmo
            Console.WriteLine("Usuario, por favor digite un número");
            var = Int32.Parse(Console.ReadLine());

            if ((var % 2) == 0)
            {
                Console.WriteLine("El número " + var + " es PAR.");
            }
            else
            {
                 Console.WriteLine("El número " + var + " es IMPAR.");
            }
            Console.ReadLine();
        }
    }
}
