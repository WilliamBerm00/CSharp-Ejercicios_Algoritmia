using System;

namespace EX_50
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion, n, contador=1;
            string linea;

            Console.WriteLine("Por favor, seleccione alguna de las siguientes opciones: ");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
            
            do
            {
                Console.WriteLine("1. Números pares hasta 100.");
                 Console.WriteLine("2. Múltiplos de 4.");
                  Console.WriteLine("3. Tabla de Multiplicar de un número hasta 10.");
                   Console.WriteLine("4. Salir del programa.");

             Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
             opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
             case 1:

            for (n = 0;  n <= 100; n = n + 2)
            {
                Console.WriteLine(" ° " + n);
                Console.WriteLine("||||||||");
            }
            Console.ReadLine();

             break;

             case 2:

             while (contador <= 100)
        {
            if (contador % 4 == 0)
            {
                Console.WriteLine(contador);
            }
            contador += 1;
            }
            Console.ReadLine();

             break;

             case 3:
            Console.WriteLine("Ingrese multiplicador: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);

            for(int i=1; i<=10; i++ ) {              
            Console.Write(i+" x "+n+" = "+i*n+"\n");       
            } 
            Console.WriteLine("......................");           
            Console.ReadKey();
             break;
            }
            }
            while (opcion != 4);
        }
    }
}
