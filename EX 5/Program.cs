using System;

namespace EX_5
{
    class Program
    {
        static void Main(string[] args)
        {
              //declaración de variables
            int var1, res;

            Console.WriteLine("Bienvenido, con este programa usted podrá calcular el 20% de un número.");

            //algoritmo
            Console.WriteLine("Usuario, digite el número del cual desea sacar el porcentaje");
            var1 = Int32.Parse(Console.ReadLine());

            //resultado
            res = var1 * 20 / 100;
            Console.WriteLine("El porcentaje es: " + res);
            Console.WriteLine("¡Gracias!");
            Console.ReadLine();
        }
    }
}
