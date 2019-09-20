using System;

namespace CategoriaNadador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos descobrir em qual categoria você se encaixa");
            Console.WriteLine();

        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("Digite sua idade");
            Console.WriteLine("Apenas números");
                int idade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (idade < 0){
                Console.WriteLine("Impossivel ter uma idade negativa");                
            }else if(idade <= 7){
                Console.WriteLine("Você se encaixa na categoria Infantil A");
            }else if(idade <= 10){
                Console.WriteLine("Você se encaixa na categoria Infantil B");
            }else if(idade <= 13){
                Console.WriteLine("Você se encaixa na categoria Juvenil A");
            }else if(idade <= 17){
                Console.WriteLine("Você se encaixa na categoria Juvenil B");
            }else if (idade > 150){
                Console.WriteLine("Não trola, difícil você estar vivo com essa idade");                
            }else if (idade >= 18)
            {
                Console.WriteLine("Você se encaixa na categoria Adulto");
            }

                Console.WriteLine();

                Console.WriteLine("Quer continuar ? (s/n)");
                var cont = Console.ReadLine();

                 Console.Clear();
                
                if (cont != "s")
                {
                    continuar = false;
                }

        
        }

        }
    }
}
