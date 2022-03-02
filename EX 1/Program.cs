using System;

namespace EX_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaración de variables
            int var1, var2, res;

            Console.WriteLine("Bienvenido, con este programa usted podra calcular una suma.");

            //algoritmo
            Console.WriteLine("Usuario, digite el primer número");
            var1 = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Usuario, digite el segundo número");
            var2 = Int32.Parse(Console.ReadLine());

            //resultado
            res = var1 + var2;
            Console.WriteLine("El resultado de la suma es: " + res);
            Console.WriteLine("¡Gracias!");
            Console.ReadLine();

        }
    }
}
