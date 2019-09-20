using System;

namespace ValidacaoEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("");
            Console.WriteLine("Insira seus dados para validação");

            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("");

            while(!email.Contains("@") || !email.Contains(".com"))
            {
                Console.WriteLine("Insira corretamente seu email");
                email = Console.ReadLine();
                Console.Clear();
            }
            

            Console.WriteLine("Senha: ");
            string senha = Console.ReadLine();
            Console.WriteLine("");

            while (senha.Length < 7)
            {
                Console.WriteLine("Quantidade minima de caracteres da senha não atingida (6 caracteres)");
                senha = Console.ReadLine();
            }
            
            Console.WriteLine("Quantidade minima de caracteres da senha não atingida ");





        }
    }
}
