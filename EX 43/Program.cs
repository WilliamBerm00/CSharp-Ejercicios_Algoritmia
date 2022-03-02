using System;
using System.Collections.Generic;
using System.Linq;

namespace EX_43
{
    class Program
    {
        static void Main(string[] args)
        {
           int n, count = 0, repeticion, numero, totalidad=0;

            Console.WriteLine("Por favor, digite cuantos numeros desea ingresar: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("===========================================");

            Console.WriteLine("¿Que número desea saber cuantas veces se repite?");
            repeticion = int.Parse(Console.ReadLine());
            Console.WriteLine("===========================================");

            while (count < n)
            {

                Console.WriteLine("Digite el número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero == repeticion)
                {
                    totalidad++;
                }

                count++;
            }
            if (totalidad > 1)
            {
                Console.WriteLine("El número " + repeticion + " se repite " + totalidad  + " veces.");
            }
            else if (totalidad != 1)
            {
                 Console.WriteLine("El número " + repeticion + " no se repite ninguna vez.");
            }
            else
            {
                Console.WriteLine("El número " + repeticion + " se repite 1 vez.");
            }
            Console.ReadKey();
        }
    }
}
