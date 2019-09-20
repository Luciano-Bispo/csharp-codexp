using System;

namespace CalcularMedia {
    class Program {
        static void Main (string[] args) {
            Operacoes operacao = new Operacoes();
           int n1;
           int n2;
           int n3;



            Console.WriteLine("Vamos brincar");
            Console.WriteLine();
            Console.WriteLine("Escolha uma operação");
            Console.WriteLine();
            Console.WriteLine("[1] - TIRAR MÉDIA");
            Console.WriteLine("[2] - SOMA");
            Console.WriteLine("[3] - SUBTRAÇÃO");
            Console.WriteLine("[4] - DIVISÃO");
            Console.WriteLine("[5] - MULTIPLICAÇÃO");

            int op = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine ("Digite o primeiro número");
            n1 = int.Parse (Console.ReadLine ());
            Console.WriteLine ();

            Console.WriteLine ("Digite o segundo número");
            n2 = int.Parse (Console.ReadLine ());
            Console.WriteLine ();

            Console.WriteLine ("Digite o terceiro número");
            n3 = int.Parse (Console.ReadLine ());     




            switch (op)
            {
                case 1:
                    Console.WriteLine ($"Sua média é {operacao.Media(n1,n2,n3)}");
                break;

                case 2:
                    Console.WriteLine ($"A soma dos números é {operacao.Soma(n1,n2,n3)}");
                break;

                case 3:
                    Console.WriteLine ($"A subtração dos números é {operacao.Subtracao(n1,n2,n3)}");
                break;

                case 4:
                    Console.WriteLine ($"A divisão dos números é {operacao.Divisao(n1,n2,n3)}");
                break;

                case 5:
                    Console.WriteLine ($"A multiplicaçõa dos números é {operacao.Multiplpicacao(n1,n2,n3)}");
                break;
                
            }
            
        }

    }

 class Operacoes{
    public float Media(int n1, int n2,int n3){
         return (float)(n1 + n2 + n3)/3;
    } 

    public float Soma(float n1, float n2, float n3){
         return (n1 + n2 + n3);         
    }

    public float Multiplpicacao(float n1, float n2, float n3){
         return (n1 * n2 * n3);
                 
    }
    public float Divisao(float n1, float n2, float n3){
        
        if(n2 == 0){   
            Console.WriteLine("Não é possivel dividir por zero");
            return 0;
        
        }else{
         return (n1 / n2 / n3);         
        }
     }

    public float Subtracao(float n1, float n2, float n3){
         return (n1 - n2 - n3);
     }

 }   
}