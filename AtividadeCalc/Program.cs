using System;

namespace AtividadeSala
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            

             Operacoes operacao = new Operacoes();
           int n1;
           int n2;


            Console.WriteLine("Vamos brincar");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("-----------------MENU--------------");
            Console.WriteLine();
            Console.WriteLine("--------Escolha uma operação-------");
            Console.WriteLine();
            Console.WriteLine("[1] - SOMA");
            Console.WriteLine("[2] - SUBTRAÇÃO ");
            Console.WriteLine("[3] - SUBTRAÇÃO invertida");
            Console.WriteLine("[4] - MULTIPLICAÇÃO");
            Console.WriteLine("[5] - DIVISÃO");
            Console.WriteLine("[6] - DIVISÃO invertida");

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

            switch (op)
            {
                case 1:
                    Console.WriteLine ($"A soma dos números é {operacao.Soma(n1,n2)}");
                break;

                case 2:
                    Console.WriteLine ($"A subtração dos números é {operacao.Subtracao(n1,n2)}");
                break;

                case 3:
                    Console.WriteLine ($"A subtração invertida dos números é {operacao.SubtracaoRevert(n1,n2)}");
                break;

                case 4:
                    Console.WriteLine ($"A multiplicaçõa dos números é {operacao.Multiplpicacao(n1,n2)}");
                break;

                case 5:
                    Console.WriteLine ($"A divisão é {operacao.Divisao(n1,n2)}");
                break;

                 case 6:
                    Console.WriteLine ($"A divisão invertida é {operacao.DivisaoRevert(n1,n2)}");
                break;
                
            }

        }
    }

    
 class Operacoes{
    public float Soma(float n1, float n2){
         return (n1 + n2);         
    }
    public float Subtracao(float n1, float n2){
         return (n1 - n2);
     }

     public float SubtracaoRevert(float n1, float n2){
         return (n2 - n1);
     }
    public float Multiplpicacao(float n1, float n2){
         return (n1 * n2);
                 
    }
    public float Media(int n1, int n2){
         return (float)(n1 + n2 )/3;
    } 

    public float Divisao(float n1, float n2){
        
        if(n2 == 0){   
            Console.WriteLine("Não é possivel dividir por zero");
            return 0;
        }else{
         return (n1 / n2);         
        }
     }

    public float DivisaoRevert(float n1, float n2){
        
        if(n2 == 0){   
            Console.WriteLine("Não é possivel dividir por zero");
            return 0;
        }else{
         return (n2 / n1);         
        }
     }
 
    }
}
