using System;

namespace AtividadeAumentoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("");
            
            Console.WriteLine("Qual é o seu nome");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Qual é o seu salário");
            float salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira seu código");            
            int cod = int.Parse(Console.ReadLine());

            switch (cod)
            {
                case 1:
                Console.WriteLine($"O funcionário {nome}, com salário de {salario} reais, código {cod}, cargo escrituário teve um reajuste percentual de 50%. Salário atual de {(salario * 0.5) + salario}");
                break;
                
                case 2:
                Console.WriteLine($"O funcionário {nome}, com salário de {salario} reais, código {cod}, cargo secretário teve um reajuste percentual de 35%. Salário atual de {(salario * 0.35) + salario}");
                break;

                case 3:
                Console.WriteLine($"O funcionário {nome}, com salário de {salario} reais, código {cod}, cargo Escrituário teve um reajuste percentual de 20%. Salário atual de {(salario * 0.2) + salario}");
                break;

                case 4:
                Console.WriteLine($"O funcionário {nome}, com salário de {salario} reais, código {cod}, cargo Escrituário teve um reajuste percentual de 10%. Salário atual de {(salario * 0.1) + salario}");
                break;

                case 5:
                Console.WriteLine($"O funcionário {nome}, com salário de {salario} reais, código {cod}, cargo Diretor não teve um reajuste salárial. Salário atual de {salario}");
                break;

            }

        }
    }
}
