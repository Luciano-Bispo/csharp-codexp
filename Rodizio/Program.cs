using System;

namespace Rodizio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            
            Console.WriteLine("Informe sua placa!");
            
            string placa = Console.ReadLine();

            int caracteres = placa.Length;

            int digitofinal = int.Parse(placa.Substring(caracteres - 1)); 

            Console.Clear();

            if (digitofinal == 0 || digitofinal == 1)
            {
                Console.WriteLine(" O dia do seu rodizio é segunda-feira");
            }

            if (digitofinal == 2 || digitofinal == 3)
            {
                Console.WriteLine("O dia do seu rodizio é terça-feira");
            }

            if (digitofinal == 4 || digitofinal == 5)
            {
                Console.WriteLine("O dia do seu rodizio é quarta-feira");
            }

            if (digitofinal == 6 || digitofinal == 7)
            {
                Console.WriteLine("O dia do seu rodizio é quinta-feira"); 
            }

            if (digitofinal == 8 || digitofinal == 9)
            {
                Console.WriteLine("O dia do seu rodizio é sexta-feira"); 
            }

        }
    }
}
