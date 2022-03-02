using System;

namespace EX_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, opc;
            Console.WriteLine("Usuario, digite un número cualquiera");
            num = Int32.Parse(Console.ReadLine());

            Console.WriteLine("+++++++++++++++++++++++++++");
            Console.WriteLine("Ahora seleccione una opcion:");
            Console.WriteLine(" ");
            Console.WriteLine("1. Determinar si es positivo o negativo");
            Console.WriteLine("2. Determinar si es par o impar");
            Console.WriteLine("---------------------------");
            opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
            case 1 : Console.WriteLine("Determinar si es positivo o negativo: ");
            if (num == 0)
            {
                Console.Write("Su Numero es 0.");
            }
            else if (num >= 1)
            {
                Console.Write("Su numero '" + num + "' es Positivo.");
            }
            else if (num <= -1)
            {
                Console.Write("'Su numero '" + num + "' es Negativo.");
            }
            break;
              
            case 2 : Console.WriteLine("Determinar si es par o impar: ");
            if ((num % 2) == 0)
            {
                Console.WriteLine("El número " + num + " es PAR.");
            }
            else
            {
                Console.WriteLine("El número " + num + " es IMPAR.");
            }
            break;

            default: Console.WriteLine("Elija una opción entre la 1 y la 2.") ; break;
            }
            Console.ReadLine();
        }
    }
}
