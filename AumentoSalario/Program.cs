using System;

namespace AumentoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Juca Ltda.");
            Console.WriteLine("");
            Console.WriteLine("Reajuste de salário");
            Console.WriteLine("");
            Console.WriteLine("");
            
            Console.WriteLine("Digite o valor do seu salário");
            double salario = double.Parse(Console.ReadLine());
            
            Console.WriteLine("");

            if (salario < 990)
            {
                double aumento = salario * 0.3; 
                double reajuste = aumento + salario;
                
                Console.WriteLine($"Valor do salario atual {salario}, aumento {aumento}, salário com reajuste {reajuste}");                
            }else
            {
                Console.WriteLine("Você não tem direito ao reajuste");                
            }

        }
    }
}
