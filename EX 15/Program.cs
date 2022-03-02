using System;

namespace EX_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido, con este programa usted podra determinar si la mitad del número que ingrese es mayor o menor a 100.");

            //declaración de variables
            int num, div;

            //algoritmo
            Console.WriteLine("Usuario, por favor digite un número");
            num = int.Parse(Console.ReadLine());

            div = num / 2;

            //condicional
            if(div >= 100)
            {
                Console.WriteLine("La mitad del número " + num + " (" + div + ") " +"es MAYOR a 100.");
            }
            else
            {
                 Console.WriteLine("La mitad del número " + num + " (" + div + ") " +" es MENOR a 100.");
            }
            Console.ReadLine();
        }
    }
}
