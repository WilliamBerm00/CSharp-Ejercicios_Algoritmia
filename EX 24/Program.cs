using System;

namespace EX_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido, este programa determinará si usted ingresó una vocal o no.");

            char letra;
            Console.WriteLine("Por favor, digite la vocal");
            letra = char.Parse(Console.ReadLine());

            switch (letra)
            {
                case 'a': Console.WriteLine("Usted ingresó la vocal A"); break;
                 case 'e': Console.WriteLine("Usted ingresó la vocal E"); break;
                  case 'i': Console.WriteLine("Usted ingresó la vocal I"); break;
                   case 'o': Console.WriteLine("Usted ingresó la vocal O"); break;
                    case 'u': Console.WriteLine("Usted ingresó la vocal U"); break;
                default: Console.WriteLine("Usted no ingreso una vocal, es otro tipo de caracter."); break;
            }
            Console.ReadLine();
        }
    }
}
