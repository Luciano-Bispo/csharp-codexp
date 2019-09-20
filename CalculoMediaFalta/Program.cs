using System;

namespace CalculoMediaFalta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Hello World!");
            Console.WriteLine();
            
            Console.WriteLine("Digite a primeira nota ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Digite a segunda nota ");
            int n2 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Digite a terceira nota ");
            // int n3 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Digite a quarta nota ");
            // int n4 = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Vamos continuar");
            Console.WriteLine();
            
            Console.WriteLine("Digite suas faltas");
            int faltas = int.Parse(Console.ReadLine());

            float media = (n1+n2) / 2;

            Console.Clear();

            if (media > 100 || media < 0)
            {
                Console.WriteLine("Confira as notas e tente novamente");
            }else{

                if(media >= 50 && faltas <= 25){
                    Console.WriteLine("Parabéns! Você foi aprovado");
                }else{
                    Console.WriteLine("Não foi dessa vez que você conseguiu, mas não desista ligue somente durante o programa, valeu!");
                }
            }


        }
    }
}
