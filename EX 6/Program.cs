using System;

namespace EX_6
{
    class Program
    {
        static void Main(string[] args)
        {
             //declaración de variables
            int var1, res, res2, res3;

            Console.WriteLine("Bienvenido, con este programa usted podrá calcular el 30, el 60 y el 90% de un número.");

            //algoritmo
            Console.WriteLine("Usuario, digite el número del cual desea sacar los porcentajes");
            var1 = Int32.Parse(Console.ReadLine());

            //resultado
            res = var1 * 30 / 100;
            res2 = var1 * 60 / 100;
            res3 = var1 * 90 / 100;

            Console.WriteLine("Los porcentajes son: " + res + ", " + res2 + " y " + res3 +" respectivamente.");
            Console.WriteLine("¡Gracias!");
            Console.ReadLine();
        }
    }
}
