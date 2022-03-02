using System;

namespace EX_46
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=0, suma=0, valor, n;
            string linea;

            Console.WriteLine("Por favor, ingrese la totalidad de productos a sumar: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("=================================");

            while (x < n)
            {
                Console.Write("Ingrese el valor del producto "+x+": ");
                linea = Console.ReadLine();
                Console.WriteLine("=================================");

                valor = int.Parse(linea);

                suma = suma + valor;
                x = x + 1;
            }
            
            Console.Write("El valor que usted debe pagar en caja es de: ");
            Console.WriteLine("$" + suma);
            Console.ReadKey();
        }
    }
}
