using System;

namespace EX_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1, var2, var3, res;

            Console.WriteLine("Bienvenido, con este programa usted podra calcular la distancia recorrida en un movimiento rectilíneo.");

            //algoritmo
            Console.WriteLine("Usuario, digite la Posición inicial (m) = [x0]");
            var1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Usuario, digite la Velocidad (m/s) = [v]");
            var2 = Int32.Parse(Console.ReadLine()); 

            Console.WriteLine("Usuario, digite el Tiempo (s) = [t]");
            var3 = Int32.Parse(Console.ReadLine());

            //resultado
            res = var1 + var2 * var3;
            Console.WriteLine("x = x0 + vt = " + var1 + "m" + " + " + var2 + "m/s" + " * " + var3 + "s ");
            Console.WriteLine("La distancia recorrida es: " + res + "m");
            Console.WriteLine("¡Gracias!");
            Console.ReadLine();
        }
    }
}
