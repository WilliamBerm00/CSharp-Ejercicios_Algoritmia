using System;

namespace EX_38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int cantidad = 15;
            int i = 0;
            double nota = 0.0;
            double suma = 0.0;
            double promedio = 0.0;

            for (i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Por favor, digite la " + i + " nota");
                nota = double.Parse(Console.ReadLine());

                suma = suma + nota;
            }
            Console.WriteLine("----------------------------");
            promedio = suma / 15;

            if (promedio >= 40.0)
            {
                Console.WriteLine("Su promedio es de: ");
                Console.WriteLine("--- " + promedio + " ---");
                Console.WriteLine("USTED APROBÓ PROGRAMACIÓN DE SOFTWARE");
            }
            else
            {
                Console.WriteLine("Su promedio es de: ");
                Console.WriteLine("--- " + promedio + " ---");
                Console.WriteLine("USTED REPROBÓ PROGRAMACIÓN DE SOFTWARE");
            }
            Console.ReadLine();
        }
    }
}
