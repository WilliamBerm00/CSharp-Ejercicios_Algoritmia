using System;

namespace EX_42
{
    class Program
    {
        static void Main(string[] args)
        {
             int n, count=0, num;
             double ResultadoCubo=1, ResultadoCuarta=1, ResultadoQuinta=1;

            Console.WriteLine("Por favor, digite cuantos numeros desea ingresar: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("==================================");

            while (count < n)
            {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Por favor, escriba el número " + count + " : ");
            num = int.Parse(Console.ReadLine());

            ResultadoCubo = Math.Pow(num, 3);
            ResultadoCuarta = Math.Pow(num, 4);
            ResultadoQuinta = Math.Pow(num, 5);

            Console.WriteLine(".............................");
            Console.WriteLine("El cubo de " + num + " es: " + ResultadoCubo);
             Console.WriteLine("La cuarta de " + num + " es: " + ResultadoCuarta);
              Console.WriteLine("La quinta de " + num + " es: " + ResultadoQuinta);

              count++;
            }
            Console.WriteLine(".............................");
            Console.ReadKey();
        }
    }
}
