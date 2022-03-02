using System;

namespace EX_48
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcion;
            float res, var1 = 0, var2 = 0;

            Console.WriteLine("Por favor, seleccione alguna de las siguientes opciones: ");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");

            do
            {
                Console.WriteLine("1. Ingresar 2 números.");
                 Console.WriteLine("2. Realizar la suma.");
                  Console.WriteLine("3. Realizar la resta.");
                   Console.WriteLine("4. Realizar la multiplicación.");
                    Console.WriteLine("5. Realizar la división.");
                     Console.WriteLine("6. Salir del programa.");

             Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
             Console.WriteLine("");
             opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: Console.WriteLine("Ingrese el primer número: ");
                          var1 = float.Parse(Console.ReadLine());
                          Console.WriteLine("Ingrese el segundo número: ");
                          var2 = float.Parse(Console.ReadLine());

                          Console.WriteLine("Usted ha ingresado los valores " + var1 + " y " + var2);Console.ReadKey();
                break;

                 case 2: res= var1 + var1;
                 
                 Console.WriteLine("La suma: ");
                 Console.WriteLine(var1 + " + " + var2 + " = " + res);Console.ReadKey();
                 break;

                  case 3: res = var1 - var2;
                  
                 Console.WriteLine("La resta: ");
                 Console.WriteLine(var1 + " - " + var2 + " = " + res);Console.ReadKey(); break;

                   case 4: res = var1 * var2;
                  
                 Console.WriteLine("La Multiplicación: ");
                 Console.WriteLine(var1 + " * " + var2 + " = " + res);Console.ReadKey(); break;
                    
                    case 5:res = var1 / var2;
                  
                 Console.WriteLine("La división: ");
                 Console.WriteLine(var1 + " / " + var2 + " = " + res);Console.ReadKey(); break;
            
            }
            }
             while (opcion != 6);
        
        }

    }

}
