using System;

namespace EX_44
{
    class Program
    {
        static void Main(string[] args)
        {
            int materia = 0, me = 0, numero, n, count= 0, totalidad = 0, promedio;

            Console.WriteLine("Usuario, ingrese la cantidad de notas a Operar: ");
            n = int.Parse(Console.ReadLine());

            while (count < n)
            {
                Console.WriteLine("Escriba la nota: ");
                numero = int.Parse(Console.ReadLine());

                totalidad = totalidad + numero;

                if (count == 1)
                {
                    materia = numero;
                    me = numero;
                } 
                if (numero > materia)
                {
                    materia = numero;
                }

                numero = 0;
                count++;
            }

            promedio = totalidad / n;

            Console.WriteLine("------------------------------");
            Console.WriteLine("El promedio es: ");
            Console.WriteLine(promedio);
            Console.WriteLine("La nota mayor es: " + materia);

            if (promedio >= 40)
            {
                Console.WriteLine("El estudiante aprovó la materia");
            }
            else
            {
                Console.WriteLine("El estudiante reprovó la materia");
            }
            Console.ReadKey();
        }
    }
}
