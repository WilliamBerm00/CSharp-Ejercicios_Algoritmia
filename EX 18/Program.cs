using System;

namespace EX_18
{
    class Program
    {
        static void Main(string[] args)
        {
             int var1, var2, res;

            Console.WriteLine("Bienvenido, con este programa usted podrá calcular el valor que deberá pagar tras la compra que realizó de los elementos de la misma referencia y si se aplica un descuento de 20%.");
              Console.WriteLine("-------------------------");
              
            //algoritmo
            Console.WriteLine("Usuario, digite el valor unitario del elemento de referencia");
            var1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Usuario, digite el número de elementos de la misma referencia que compró");
            var2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------");

            //resultado
            res = var1 * var2;

            //condicional
            if (res >= 100000)
            {
                res = res - res * 20 / 100;
                Console.WriteLine("Su compra aplica para un descuento del 20%");
                Console.WriteLine("Usted compró " + var2 + " elementos " + "al valor de " + var1 + ". El precio final con DESCUENTO es de: " + "$" + res);
            }
            else
            {
                Console.WriteLine("Su compra no aplica para un descuento");
                Console.WriteLine("Usted compró " + var2 + " elementos " + "al valor de " + var1 + ". El precio final es de: " + "$" + res);
            }
             Console.ReadLine();
        }
    }
}
