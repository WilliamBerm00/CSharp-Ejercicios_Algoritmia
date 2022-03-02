using System;

namespace EX_27
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc, var4;
            float res, var1, var2, var3;

            Console.WriteLine("+++++++++++++++++++++++++++");
            Console.WriteLine("Seleccione una opcion:");
            Console.WriteLine(" ");
            Console.WriteLine("1. ¿El estudiante pasa o no la materia?");
            Console.WriteLine("2. ¿El estudiante es mayor o menor de edad?");
            Console.WriteLine("---------------------------");
            opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
            case 1 : Console.WriteLine("Opción 1");

            Console.WriteLine("Usuario, digite la primera nota");
            var1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Usuario, digite la segunda nota");
            var2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Usuario, digite la tercera nota");
            var3 = float.Parse(Console.ReadLine());

            Console.WriteLine("------------------------------");

            res = (var1 + var2 + var3) / 3;

            //condicional
            if (res >= 30)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Usted aprovó la matería con un promedio de: " + res );
            }
            else
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Usted reprovó la matería con un promedio de: " + res );
            } 
            break;

            case 2: Console.WriteLine("Opcion 2.");
            Console.WriteLine("+++++++++++++++++++++++++++");
            Console.WriteLine("Usuario, digite su edad");
            var4 = Int32.Parse(Console.ReadLine());
            
            if (var4 >= 18)
            {
                Console.WriteLine("Es Mayor de edad");
            }
            else
            {
                Console.WriteLine("Es Menor de edad");
            }
            break;

            default: Console.WriteLine("Elija una opcion correcta."); break;
            }
            Console.ReadLine();
        }
    }
}
