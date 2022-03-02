using System;

namespace EX_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido, con este programa usted podrá calcular el valor a pagar dependiendo del precio total y de los descuentos.");
            Console.WriteLine("--------------------------");

            //declaración de variables
            int var2;

            //algoritmo

            Console.WriteLine("Usuario, digite el precio total de su compra para aplicar los descuentos");
            var2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------");

           //condicional

           if (var2 >= 50000)
           {
               var2 = var2 - var2 * 50 / 100;
               Console.WriteLine("Su compra aplica para un descuento del 50%, el total es de: " + "$" + var2);
           }
           else if (var2 >= 20001)
           {
               var2 = var2 - var2 * 30 / 100;
                Console.WriteLine("Su compra aplica para un descuento del 30%, el total es de: " + "$" + var2);
           }
            else if (var2 >= 20001)
           {
               var2 = var2 - var2 * 10 / 100;
               Console.WriteLine("Su compra aplica para un descuento del 10%, el total es de: " + "$" + var2);
           }
           else
           {
              Console.WriteLine("Su compra no aplica para ningún descuento, el total es de: " + "$" + var2);
           }
             Console.ReadLine();
        }
    }
}
