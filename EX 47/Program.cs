using System;
using System.Collections.Generic;
using System.Linq;

namespace EX_47
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cont=0;
            double estatura,  mayor=0;

            Console.WriteLine("Por favor, ingrese la totalidad de intregantes en el grupo de estudiantes: ");
            n = int.Parse(Console.ReadLine());

            while (cont < n)
            {
                Console.WriteLine("Escriba la estatura " + cont + ":");
                estatura = double.Parse(Console.ReadLine());

                if (estatura > mayor)
                {
                    mayor = estatura;
                }
                cont++;
            }
            Console.WriteLine("La estatura mayor es de: " + mayor);
            Console.ReadKey();
        }
    }
}
