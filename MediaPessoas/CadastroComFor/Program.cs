using System;

namespace CadastroComFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] produtoNome = new string[3];
            double[] produtoPreco = new double[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite o nome do produto");
                produtoNome[i]= Console.ReadLine();
                    
                Console.WriteLine("Digite o preço do produto");
                produtoPreco[i]= double.Parse(Console.ReadLine());
            }

            foreach (var item in produtoNome)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    Console.WriteLine($"Nome do produto: {item}");
                }
            }

        }
    }
}
