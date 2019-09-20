using System;

namespace ListaCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

             string[] lista = new String[5];
            

            int i = 0;
            
            while (i < 5)
            {
            Console.WriteLine("----------------Lista de compras----------------");
            Console.WriteLine();
                
                Console.WriteLine("O que deseja comprar");
                lista[i] = Console.ReadLine();

                Console.Clear();
                // Console.WriteLine();

                
                i++;
            }
            
            i = 0;

            Console.WriteLine("----------------Sua lista----------------");
            
             while (i < 5)
            {
                Console.WriteLine();
                Console.WriteLine($"Item {i + 1}: {lista[i]}");
                Console.WriteLine();
                                
                i++;
            }
        }
    }
}
