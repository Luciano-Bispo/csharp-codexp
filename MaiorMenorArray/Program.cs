using System;

namespace MaiorMenorArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            int pessoas = 0;
            int[] idades = new int[10];

            while (pessoas < 10)
            {
                Console.WriteLine($"[{pessoas + 1}°] Digite sua idade");
                idades[pessoas] = int.Parse(Console.ReadLine());

                pessoas++;
            }


            pessoas = 0;
            

            while (pessoas < 10)
            {
                if(idades[pessoas] < 18){
                    Console.WriteLine($"Menor de idade. {idades[pessoas]} anos.");
                }else{
                    Console.WriteLine($"Maior de idade. {idades[pessoas]} anos.");
                }  
                pessoas++;  
            }
        }
    }
}
