using System;

namespace EX_10
{
    class Program
    {
        static void Main(string[] args)
        {
             int var1, var2, res;

            Console.WriteLine("Bienvenido, con este programa usted podrá determinar el salario a pagar de un empleado restando tambien los conceptos de pensión y salud.");

            //algoritmo
            Console.WriteLine("Usuario, digite el valor que gana el empleado por un día de trabajo");
            var1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Usuario, digite el número de días que trabajó el empleado");
            var2 = Int32.Parse(Console.ReadLine());

            //resultado
            res = var1 * var2;
            res = res - res * 25 / 100;
            Console.WriteLine("Con concepto de salud y pensión el salario total que se le debe pagar al empleado es: " + "$" + res);
            Console.ReadLine();
        }
    }
}
