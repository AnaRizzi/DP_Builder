using System;

namespace Builder
{
    public class NotaFiscalDAO : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("NF salva no banco de dados");
        }
    }
}
