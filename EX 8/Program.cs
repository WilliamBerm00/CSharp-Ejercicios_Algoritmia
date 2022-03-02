using System;

namespace EX_8
{
    class Program
    {
        static void Main(string[] args)
        {
             //declaración de variables
            int var1, var2, var3, var4, var5, res;

            Console.WriteLine("Bienvenido, con este programa usted podrá calcular el promedio de un total de 5");

            //algoritmo
            Console.WriteLine("Usuario, digite el primer número");
            var1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Usuario, digite el segundo número");
            var2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Usuario, digite el tercer número");
            var3 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Usuario, digite el cuarto número");
            var4 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Usuario, digite el quinto número");
            var5 = Int32.Parse(Console.ReadLine());

            //resultado
            res = (var1 + var2 + var3 + var4 + var5) / 5;
            Console.WriteLine("El promedio de los valores ingresados es de: " + res);
            Console.WriteLine("¡Gracias!");
            Console.ReadLine();
        }
    }
}
