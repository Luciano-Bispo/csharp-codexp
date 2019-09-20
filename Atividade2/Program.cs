using System;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Digite sua idade champs");
            Console.WriteLine("");

            int idade, meses, dias, horas, minutos;
            
            idade = int.Parse(Console.ReadLine());

            meses = idade * 12;
            dias = idade  * 365;
            horas = dias  * 24;
            minutos = horas * 60;

            Console.WriteLine($"Você tem {idade} de idade, viveu {meses} meses, {dias} dias, {horas} horas, {minutos} minutos");
        }
    }
}
