using System;

namespace EX_34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROMEDIO DE ESTATURA EN UN GRUPO DE ESTUDIANTES");
            Console.WriteLine("....................................");

            int cantidad = 18;
            int n = 0;
            int estat = 0;
            int suma = 0;
            int promedio = 0;

            for (n = 0; n < cantidad; n++)
            {
                Console.WriteLine("Escriba la estatura del estudiante en CM:");
                estat = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------");

                suma = suma + estat;
            }

            promedio = suma / 18;

            if (promedio >= 170)
            {   
                Console.WriteLine("El promedio de la estatura es de: " + promedio + "CM");
                Console.WriteLine("Estudiantes muy altos");
            }
            else if (promedio >= 140)
            {
                Console.WriteLine("El promedio de la estatura es de: " + promedio + "CM");
                Console.WriteLine("Estudiantes de estatura normal");
            }
            else
            {
                Console.WriteLine("El promedio de la estatura es de: " + promedio + "CM");
                Console.WriteLine("Estudiantes muy bajos");
            }
            Console.ReadLine();
        }
    }
}
