using System;

namespace EX_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido, con este programa se podrá determinar si usted digita un numero positivo.");
            
            //declaración de variables
            int num;

            //algoritmo
            Console.WriteLine("Usuario, digite un número");
            num = int.Parse(Console.ReadLine());

            //condicional
            if (num >= 0)
            {
                Console.WriteLine("El número " + num + " es POSITIVO.");
            }
            else
            {
                Console.WriteLine("El número " + num + " es NEGATIVO.");
            }
            Console.ReadLine();
        }
    }
}
