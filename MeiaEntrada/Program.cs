using System;

namespace MeiaEntrada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            
            Console.WriteLine("Digite sua idade pra consultar se tem direito a meia entrada");
            Console.WriteLine();
            
            int idade = int.Parse(Console.ReadLine());
            
            Console.Clear();


            if (idade < 0 || idade > 130)
            {
                Console.WriteLine("Não trolla meu chapa");
            }else{

                if (idade < 18 && idade >= 60)
                {
                    Console.WriteLine("Você tem direito a meia entrada!");
                }else{
                    Console.WriteLine("Você não tem direito!");
                }
            
            }



            

        }
    }
}
