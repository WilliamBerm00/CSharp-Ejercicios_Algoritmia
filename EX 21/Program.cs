using System;

namespace EX_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido, con este programa usted podrá calcular el promedio de temperatura durante una semana.");
            Console.WriteLine("--------------------");

            //declaración de variables
            int dom, lun, mar, mie, jue, vie, sab, res;

            //algoritmo
            Console.WriteLine("Usuario, por favor escriba la temperatura del domingo");
            dom = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Usuario, por favor escriba la temperatura del lunes");
            lun = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Usuario, por favor escriba la temperatura del martes");
            mar = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Usuario, por favor escriba la temperatura del miércoles");
            mie = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Usuario, por favor escriba la temperatura del jueves");
            jue = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Usuario, por favor escriba la temperatura del viernes");
            vie = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Usuario, por favor escriba la temperatura del sábado");
            sab = Int32.Parse(Console.ReadLine());

            Console.WriteLine("--------------------");

            res = (dom + lun + mar + mie + jue + vie + sab) / 7;

            //condicional
            if (res >= 35)
            {   
                Console.WriteLine("La temperatura promedio de la semana es " + res + "° C.");
                Console.WriteLine("¡Que semana tan calurosa!");
            }
            else if (res >= 15)
            {
                Console.WriteLine("La temperatura promedio de la semana es " + res + "° C.");
                Console.WriteLine("¡Que clima tan delicioso!");
            }
            else
            {
                Console.WriteLine("La temperatura promedio de la semana es " + res + "° C.");
                Console.WriteLine("¡Que semana tan fría!");
            }
             Console.ReadLine();
        }
    }
}
