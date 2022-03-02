using System;

namespace EX_36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Con este programa usted podrá visualizar las tablas de multiplicar del número que ingrese.");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            int n;
            string linea;
            
            Console.WriteLine("Ingrese multiplicador: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);

            for(int i=1; i<=10; i++ ) {              
                Console.Write(i+" x "+n+" = "+i*n+"\n");       
            } 
            Console.WriteLine("......................");           
            Console.ReadKey();
        }
    }
}
