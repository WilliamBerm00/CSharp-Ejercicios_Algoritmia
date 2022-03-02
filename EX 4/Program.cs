using System;

namespace EX_4
{
    class Program
    {
        static void Main(string[] args)
        {
             //declaración de variables
            int var1, var2, res;

            Console.WriteLine("Bienvenido, con este programa usted podra calcular la edad de una persona.");

            //algoritmo
            Console.WriteLine("Usuario, digite el año actual");
            var1 = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Usuario, digite el año de nacimiento de la persona que quiere saber su edad");
            var2 = Int32.Parse(Console.ReadLine());

            //resultado
            res = var1 - var2;
            Console.WriteLine("La edad de la persona es de "+ res + " años");
            Console.ReadLine();
        }
    }
}
