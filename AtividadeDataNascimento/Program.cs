using System;

namespace AtividadeDataNascimento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o ano de nascimento champs, pelase!");

            int anoNascimeto = int.Parse(Console.ReadLine());

            int idade = (DateTime.Now.Year - anoNascimeto);

            Console.WriteLine($"A sua idade atual é: {idade}.");

            int semanas = idade * (12 * 4);

            Console.WriteLine($"Você viveu : {semanas} semanas.");

        }
    }
}
