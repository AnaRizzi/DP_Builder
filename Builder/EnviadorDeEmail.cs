using System;

namespace Builder
{
    public class EnviadorDeEmail : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("NF enviada por email");
        }
    }
}
