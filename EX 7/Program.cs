using System;

namespace EX_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaración de variables
            int var1, var2, res;

            Console.WriteLine("Bienvenido, con este programa usted podrá calcular el área de un cuadrado.");

            //algoritmo
            Console.WriteLine("Usuario, digite el número en CM del lado del cuadrado.");
            var1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Usuario, digite el número en CM de la base del cuadrado.");
            var2 = Int32.Parse(Console.ReadLine());

            //resultado
            res = var1 * var2;
            Console.WriteLine("De acuerdo a la formula: A = L*L");
            Console.WriteLine("El área del cuadrado es " + res + "cm2");
            Console.WriteLine("¡Gracias!");
            Console.ReadLine();
        }
    }
}
