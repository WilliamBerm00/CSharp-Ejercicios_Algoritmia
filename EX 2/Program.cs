using System;

namespace EX_2
{
    class Program
    {
        static void Main(string[] args)
        {
             //declaración de variables
            int var1, var2, var3, res;

            Console.WriteLine("Bienvenido, con este programa usted podrá calcular una multiplicación.");

            //algoritmo
            Console.WriteLine("Usuario, digite el primer número");
            var1 = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Usuario, digite el segundo número");
            var2 = Int32.Parse(Console.ReadLine());

             Console.WriteLine("Usuario, digite el tercer número");
            var3 = Int32.Parse(Console.ReadLine());

            //resultado
            res = var1 * var2 * var3;
            Console.WriteLine("El resultado de la multiplicación es: " + res);
            Console.WriteLine("¡Gracias!");
            Console.ReadLine();
        }
    }
}
