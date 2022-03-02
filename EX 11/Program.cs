using System;

namespace EX_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido, con este programa usted podrá determinar si es mayor o menor de edad según su edad.");
            
            //declaración de variables
            int añoNa, añoAc, edad;

            //algoritmo
            Console.WriteLine("Usuario, digite su año de nacimiento");
            añoNa = int.Parse(Console.ReadLine());

            Console.WriteLine("Usuario, digite el año actual");
            añoAc = int.Parse(Console.ReadLine());

            edad = añoAc - añoNa;

            //Condicional
            if(edad >= 18)
            {
                Console.WriteLine("Su edad es: " + edad + " años.");
                Console.WriteLine("Por lo tanto usted es MAYOR de edad.");
            }
            else
            {
                Console.WriteLine("Su edad es: " + edad + " años.");
                Console.WriteLine("Por lo tanto usted es MENOR de edad.");
            }
            Console.ReadLine();
        }
    }
}
