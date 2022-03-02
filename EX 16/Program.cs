using System;

namespace EX_16
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Bienvenido, usted ingresara dos números y el sistema determinará si restarlos o sumarlos.");

            //declaración de variables
            int num1, num2, res;

            //algoritmo
            Console.WriteLine("Usuario, digite el primer número");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Usuario, digite el primer número");
            num2 = int.Parse(Console.ReadLine());

            //condicional
            if(num1 == num2)
            {
                res = num1 - num2;
                Console.WriteLine("Ya que los números que digito son iguales, estos se restan.");
                Console.WriteLine(num1 + " - " + num2 + " = " + res);
            }
            else
            {
                res = num1 + num2;
                Console.WriteLine("Ya que los números que digito son diferentes, estos se suman.");
                Console.WriteLine(num1 + " + " + num2 + " = " + res);
            }
            Console.ReadLine();
        }
    }
}
