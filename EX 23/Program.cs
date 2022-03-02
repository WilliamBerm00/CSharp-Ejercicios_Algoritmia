using System;

namespace EX_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido, este programa determinará si usted podrá ser aceptado o no en el equipo de baloncesto.");

            //variables
            int edad, peso, estatura;

            //algoritmo
            Console.WriteLine("¿Cúal es su edad?");
            edad = Int32.Parse(Console.ReadLine());

            Console.WriteLine("¿Cúal es su estatura?");
            estatura = Int32.Parse(Console.ReadLine());

            Console.WriteLine("¿Cúal es su peso?");
            peso = Int32.Parse(Console.ReadLine());

            //condicional
            if (edad <= 18)
            {
            Console.WriteLine("Usted puede ser aceptado");
            }
            else if (estatura >= 180)
            {
            Console.WriteLine("Usted puede ser aceptado");
            }
            else if (peso >= 80)
            {
             Console.WriteLine("Usted puede ser aceptado");
            }
            else
            {
                Console.WriteLine("Usted no cumple con los requisitos para ser aceptado");
            }

             Console.ReadLine();
        }
    }
}
