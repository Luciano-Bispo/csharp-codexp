using System;

namespace MediaPessoas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.WriteLine("Hello World!");
            Console.WriteLine("");
            Console.WriteLine("");

            int[] n1 = new int[10];
            int[] n2 = new int[10];
            int iterator = 0;
            float mediaTotal = 0;

            while (iterator < 10)
            {
                Console.WriteLine($"Digite as duas notas do {iterator + 1}º aluno");
                Console.WriteLine("");

                Console.WriteLine($"1ª nota");
                n1[iterator] = int.Parse(Console.ReadLine()); 
                Console.WriteLine("");

                Console.WriteLine("2ª nota");
                n2[iterator] = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                iterator++;

                Console.Clear();
            }


            Console.WriteLine();
            Console.WriteLine();

            iterator = 0;

            while (iterator < 10)
            {
                 var media = 0;

               
                    media = (n1[iterator] + n2[iterator]) / 2;
                    
                    Console.WriteLine();
                    Console.WriteLine($"media: {media}");
                    Console.WriteLine();

                    
                    if (media >= 7)
                    {
                        Console.WriteLine($"{iterator + 1}° aluno APROVADO. Média: {media}");
                    }else{
                        Console.WriteLine($"{iterator + 1}° aluno REPROVADO. Média: {media}");
                    }  
                

                mediaTotal =+ media;
                iterator++;
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"A média total da sala é: {mediaTotal / n1.Length }");




        }
    }
}
