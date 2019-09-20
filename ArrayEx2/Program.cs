using System;

namespace ArrayEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] allnomes = new String[5];
            string[] alltelefones = new String[5];
            string[] allemails = new String[5];

            int i = 0;
            
            while (i < 5)
            {
                Console.WriteLine("----------------Cadastro----------------");
                Console.WriteLine();

                Console.WriteLine($"Insira as informações da {i + 1} pessoa");
                Console.WriteLine();
                
                Console.WriteLine("Insira o nome");
                allnomes[i] = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine("Insira o e-mail");
                allemails[i] = Console.ReadLine();

                Console.WriteLine();
                
                Console.WriteLine("Insira o telefone");
                alltelefones[i] = Console.ReadLine();

                Console.Clear();
                
                i++;
            }
            
            i = 0;

             while (i < 5)
            {
                Console.WriteLine("----------------Lista de cadastros----------------");
                Console.WriteLine();

                Console.WriteLine($"Nome: {allnomes[i]}, Telefone: {alltelefones[i]}, E-mail: {allemails}");
                Console.WriteLine();
                                
                i++;
            }


        }
    }
}
