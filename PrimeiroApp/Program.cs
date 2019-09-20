using System;

namespace PrimeiroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {     
                Console.WriteLine();
                Console.WriteLine("Vamos somar dois números");
                Console.WriteLine();
                
                Console.WriteLine("Digite um número");
                int n1 = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Digite outro número");
                var n2 = int.Parse(Console.ReadLine());
                    
                int resultado = n1 + n2; 
                    
                Console.WriteLine();
                Console.WriteLine($"A soma dos valores é: {resultado}");


                Console.WriteLine();
                Console.WriteLine("Quer continuar (sim/nao)");

                var cont = Console.ReadLine();
                
                if(cont.Equals("sim")){
                    continuar = true;
                    Console.Clear();
                }else{
                    Console.WriteLine("É pra escrever sim ou não");
                    continuar = false;
                }

            }


            
        }



    }

}
