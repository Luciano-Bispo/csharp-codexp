using System;

namespace DoWhileArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Console.WriteLine("Digite a quantidade de nomes que você quer inserir");
            
            int qtd = int.Parse(Console.ReadLine());            
            
            string[] nomes = new String[qtd];
            
            int cont = 0;

            while(cont < qtd)
            {
                Console.WriteLine($"{cont + 1}º nome: ");
                nomes[cont] = Console.ReadLine(); 

                Console.Clear();
                
                cont++;
            };

            cont = 0;

            while (cont < qtd)
            {
                Console.WriteLine($" O {cont + 1}º nome guardado foi {nomes[cont]}");
            }

        }
    }
}
