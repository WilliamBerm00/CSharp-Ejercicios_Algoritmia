using System;

namespace EX_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuál es el promedio de edad en un grupo de 15 estudiantes?");
            Console.WriteLine("....................................");

            int cantidad = 15;
            int n = 0;
            int edad = 0;
            int suma = 0;
            int promedio = 0;

            for (n = 0; n < cantidad; n++)
            {
                Console.WriteLine("Escriba la edad del estudiante: ");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------");

                suma = suma + edad;
            }

            promedio = suma / 15;
            Console.WriteLine("El promedio de edad es: " + promedio);
        }
    }
}
