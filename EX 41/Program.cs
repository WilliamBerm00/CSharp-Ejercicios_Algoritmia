using System;

namespace EX_41
{
    class Program
    {
        static void Main(string[] args)
        {
        
            int numeroingresado, cont=0, totalnumero, numeromayor=0, numeromenor=0;

            Console.WriteLine("Por favor, ingrese la totalidad de números a analizar: ");
            totalnumero = int.Parse(Console.ReadLine());

            while (cont < totalnumero)
            {
                Console.WriteLine("Escribe un número: ");
                numeroingresado = int.Parse(Console.ReadLine());

                if (cont == 1)
                {
                    numeromayor = numeroingresado;
                    numeromenor  = numeroingresado;
                }
                else
                {
                   if (numeroingresado > numeromayor)
                   {
                       numeromayor=numeroingresado;
                   }
                   if (numeroingresado < numeromenor)
                   {
                        numeromenor=numeroingresado;
                   }
                }
                cont++;
            }
            Console.WriteLine("Valor mas grande: " + numeromayor);
            Console.WriteLine("Valor más pequeño: "+ numeromenor);
            }
        }
    }
