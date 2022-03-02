using System;

namespace EX_17
{
    class Program
    {
        static void Main(string[] args)
        {
                         //declaración de variables
            float var1, var2, var3, res;
            int cod;
            string nom, nom_mat;

            Console.WriteLine("Bienvenido, con este programa usted podrá calcular el promedio de su nota y saber si usted es aprovado o reprobado.");

            //algoritmo
            Console.WriteLine("Usuario, escriba su nombre");
            nom = (Console.ReadLine());

            Console.WriteLine("Usuario, digite el código que le corresponde");
            cod = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Usuario, escriba el nombre de la materia");
            nom_mat = (Console.ReadLine());

            Console.WriteLine("Usuario, digite la primera nota");
            var1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Usuario, digite la segunda nota");
            var2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Usuario, digite la tercera nota");
            var3 = float.Parse(Console.ReadLine());

            Console.WriteLine("------------------------------");

            //resultado
            res = (var1 + var2 + var3) / 3;

            //condicional
            if (res >= 40)
            {
                Console.WriteLine(nom);
                Console.WriteLine("Estudiante con código: " + cod);
                Console.WriteLine("------------------------------");
                Console.WriteLine("Usted aprovó la matería " + nom_mat + " con un promedio de: " + res );
            }
            else
            {
                Console.WriteLine(nom);
                Console.WriteLine("Estudiante con código: " + cod);
                Console.WriteLine("------------------------------");
                Console.WriteLine("Usted reprovó la matería " + nom_mat + " con un promedio de: " + res );
            }
            Console.ReadLine();
        }
    }
}
