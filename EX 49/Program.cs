using System;

namespace EX_49
{
    class Program
    {
        static void Main(string[] args)
        {   
            int opcion, var1, fac, expo, res=1, count=0;

            Console.WriteLine("Digite un valor.");
            var1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Pulse cualquier tecla para mostrar el menú.");
            Console.WriteLine("");
            Console.ReadKey();

            Console.WriteLine("Por favor, seleccione alguna de las siguientes opciones: ");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
            
            do
            {
                Console.WriteLine("1. Calcular el factorial del número.");
                 Console.WriteLine("2. Calcular la potencia.");
                     Console.WriteLine("3. Salir del programa.");

             Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
             Console.WriteLine("");
             opcion = int.Parse(Console.ReadLine());

             switch (opcion)
            {

            case 1: 
            if (var1 == 0)
            {
                Console.WriteLine($"El factorial de {0} es 1" + var1);
            }
            else
            {

            fac = var1;

            for (int i = var1; i > 1; i--)
            {
                fac = fac * (i - 1);
            }
            Console.WriteLine("La factorial es: " + fac);
            Console.ReadKey();
            }
            
            break;

            case 2:
             Console.WriteLine("Por favor, digite el valor del exponente");
            expo = int.Parse(Console.ReadLine());

            while (count < expo)
            {
                res = res * var1;
                count++;
            }
            Console.WriteLine("La base: " + var1 + " Elevada al exponente: " + expo + " Es: " + res);
            Console.ReadKey();
            break;
            }
            } while (opcion != 3);
        }
    }
}
