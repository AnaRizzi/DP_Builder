using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criar uma nota fiscal com vários parâmetros");

            ItemDaNota item1 = new ItemDaNota("Item 1", 100);
            ItemDaNota item2 = new ItemDaNota("Item 2", 50);

            NotaFiscalBuilder criadorNF = new NotaFiscalBuilder();
            criadorNF.ParaEmpresa("Nome da Empresa");
            criadorNF.ComCnpj("12.234.345/0001-10");
            criadorNF.ComItem(item1);
            criadorNF.ComItem(item2);
            criadorNF.NaDataAtual();
            criadorNF.ComObservacoes("minhas observações");

            NotaFiscal nf = criadorNF.CriarNota();

            Console.WriteLine(nf.RazaoSocial);
            Console.WriteLine(nf.Cnpj);
            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);

            //criar a mesma nota usando Fluent Interface, para chamar os métodos na sequência
            //sem precisar repetir o nome do objeto:
            NotaFiscalBuilderFluentInterface criadorNF2 = new NotaFiscalBuilderFluentInterface();
            criadorNF2.ParaEmpresa("Nome da Empresa")
                .ComCnpj("12.234.345/0001-10")
                .ComItem(item1)
                .ComItem(item2)
                .NaDataAtual()
                .ComObservacoes("minhas observações");

            NotaFiscal nf2 = criadorNF2.CriarNota();

            Console.WriteLine(nf2.RazaoSocial);
            Console.WriteLine(nf2.Cnpj);
            Console.WriteLine(nf2.ValorBruto);
            Console.WriteLine(nf2.Impostos);

            Console.ReadKey();
        }
    }
}
