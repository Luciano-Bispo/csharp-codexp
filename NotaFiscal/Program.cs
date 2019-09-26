using System;
using Spire.Doc;
using Spire.Doc.Documents;
using System.Drawing;

namespace NotaFiscal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            string nome, endereco; 
            double valor;
            DateTime data;

            Console.WriteLine("------------IMPRESSÃO DA NOTA FISCAL------------");

           Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();

            Console.WriteLine("Digite seu endereço");
            endereco = Console.ReadLine();

            Console.WriteLine("Digite o valor da sua compra");
            valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a data de hoje");
            data = DateTime.Parse(Console.ReadLine());

          // Pagina/Document
          Document doc = new Document();

          Section pagina = doc.AddSection();

          //paragrafo
          Paragraph pageTitle = pagina.AddParagraph();
          Paragraph nameTitle = pagina.AddParagraph();
          Paragraph addressTitle = pagina.AddParagraph();
          Paragraph valueTitle = pagina.AddParagraph();
          Paragraph dataTitle = pagina.AddParagraph();

          pageTitle.AppendText("Nota fiscal\n");
          nameTitle.AppendText($"Nome: {nome} \n");
          addressTitle.AppendText($"Endereço:{endereco} \n");
          valueTitle.AppendText($"Valor da compra: {valor}\n");
          dataTitle.AppendText($"Data de emissão: {data}\n");

            //Style
            ParagraphStyle style01 = new ParagraphStyle(doc);
            style01.Name = "paragraphBold";
            style01.CharacterFormat.Bold = true;

            doc.Styles.Add(style01);

            pageTitle.ApplyStyle(style01.Name);
            addressTitle.ApplyStyle(style01.Name);
            valueTitle.ApplyStyle(style01.Name);
            dataTitle.ApplyStyle(style01.Name);



            doc.SaveToFile(@"saida\exemploPdf.pdf", FileFormat.PDF);
        }
    }

}

