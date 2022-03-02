using System;

namespace EX_39
{
    class Program
    {
        static void Main(string[] args)
        {
            int bas, expo, count=0;
             double Resultado=1;

            Console.WriteLine("Por favor, digite el valor de la base");
            bas = int.Parse(Console.ReadLine());

            Console.WriteLine("Por favor, digite el valor del exponente");
            expo = int.Parse(Console.ReadLine());

            while (count < expo)
            {
                Resultado = Resultado * bas;
                count++;
            }
            Console.WriteLine("La base: " + bas + " Elevada al exponente: " + expo + " Es: " + Resultado);
            Console.ReadKey();
        }
    }
}
