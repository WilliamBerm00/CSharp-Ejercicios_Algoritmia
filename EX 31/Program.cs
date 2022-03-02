using System;

namespace EX_31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuantos estudiantes son mayores de edad en un grupo de 20 estudiantes?");
            Console.WriteLine("--------------------------");

            int contador = 0;
            int edad = 0;

            Random numero = new Random();

            for (int n = 0; n <= 20; n++)
            {
                edad = numero.Next(1, 7);
                if (edad >= 18)
                {
                    contador = contador + 1;
                }
            }
            
        }
    }
}
