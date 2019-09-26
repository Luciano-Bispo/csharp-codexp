using System;

namespace CalcIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("");
            Console.WriteLine("");

            var q = 3;

            string[] nome = new string[q];
            int[] idade = new int[q]; 
            double[] altura = new double[q]; 
            double[] peso = new double[q]; 
            string[] sexo = new string[q];
            double[] imc = new double[q];
            int h = 0;
            int m = 0;
            int totalIdadeH = 0 ;
            int totalIdadeM = 0;

            for (int i = 0; i < q; i++)
            {
                
                Console.WriteLine($"Digite os dados da {i + 1}° pessoa");
                Console.WriteLine();
                Console.WriteLine("Nome");
                nome[i] =  Console.ReadLine();   

                Console.WriteLine();

                Console.WriteLine("Idade");
                idade[i] = int.Parse(Console.ReadLine());

                Console.WriteLine();
               
                Console.WriteLine("Peso");
                peso[i] = double.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("altura");
                altura[i] = double.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("sexo");
                sexo[i] = Console.ReadLine().ToUpper();

                Console.Clear();

                Console.WriteLine("fora if");
                 if (sexo[i].Equals("M") || sexo[i].Equals("MASCULINO") )
                {
                Console.WriteLine("dentro if");

                    h++;

                     totalIdadeH = idade[i];
                } else if(sexo[i].Equals("F") || sexo[i].Equals("FEMININO")){
                Console.WriteLine("dentro else");
                    
                    m++;
                Console.WriteLine($"MULHERES{m}");

                     totalIdadeM = idade[i];
                }else{
                Console.WriteLine($"SAI DAQUI, TROLLA NÃO");
;
                }

                imc[i] = (altura[i] * altura[i])/peso[i];

            };
            
            Console.Clear();

            for (int i = 0; i < q; i++)
            {
                Console.WriteLine($"DADOS DA {i + 1}° PESSOA. Nome: {nome[i]}, imc: {imc[i]} ");                
            };

            Console.WriteLine();
            Console.WriteLine($"Total de homens { h }, total de mulheres { m }, média idade homens { totalIdadeH / h }, média idade mulheres { totalIdadeM / m } ");                


        }
    }
}
