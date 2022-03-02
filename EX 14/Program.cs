using System;

namespace EX_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Colegio Enrique Olaya Herrera");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Bienvenido, con este programa usted sabrá si es beneficiario de un refrigerio.");

            //declarar variables
            int grado;

            //algoritmo
            Console.WriteLine("Usuario, escriba el grado que cursa (Número)");
            grado = int.Parse(Console.ReadLine());

            //condicional
            if (grado <= 6)
            {
                Console.WriteLine("Usted cursa " + grado + "°. " + "Usted es beneficiario del refrigerio.");
            }
            else
            {
                Console.WriteLine("Usted cursa " + grado + "°. " + "Usted no es beneficiario del refrigerio.");
            }
            Console.ReadLine();
        }
    }
}
