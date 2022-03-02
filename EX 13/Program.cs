using System;

namespace EX_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido, este programa permitirá determinar que número es mayor entre dos números.");

             //declaración de variables
            int num1, num2;

            //algoritmo
            Console.WriteLine("Usuario, digite un número");
            num1 = int.Parse(Console.ReadLine());

             Console.WriteLine("Usuario, digite el segundo número");
            num2 = int.Parse(Console.ReadLine());

            if (num1 >= num2)
            {
                Console.WriteLine("El número " + num1 + " es MAYOR que " + num2);
            }
            else
            {
                Console.WriteLine("El número " + num2 + " es MAYOR que " + num1);
            }
            Console.ReadLine();
        }
    }
}
