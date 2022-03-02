using System;

namespace EX_40
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont, n, suma = 0;

            Console.WriteLine("Digite el total de numeros a sumar: ");
            n = int.Parse(Console.ReadLine());

            cont = 1;

            while (cont <= n)
            {
                suma = suma + cont;
                cont++;
                
            }
            Console.WriteLine("La suma es: " + suma);
            Console.WriteLine("---------------------");
            Console.ReadKey();
        }
    }
}
