using System;

namespace AtividadeImpaPar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("");
            
            Console.WriteLine("Digite dois números");
            Console.WriteLine("");
            
            Console.WriteLine("Primeiro:");
            int n1 = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Segundo:");
            int n2 = int.Parse(Console.ReadLine()); 


            if (n1 > n2){
                Console.WriteLine($"O número {n1} é maior que {n2}");
            }else{
                Console.WriteLine($"O número {n2} é maior que {n1}");
            }

                if(n1 % 2 == 0){
                    Console.WriteLine($"O número {n1} é PAR");
                } else{
                    Console.WriteLine($"O número {n1} é IMPAR");
                }

                 if(n2 % 2 == 0){
                Console.WriteLine($"O número {n2} é PAR");
                } else{
                    Console.WriteLine($"O número {n2} é IMPAR");
                }
                
        }
    }
}
