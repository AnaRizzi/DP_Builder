using System;
using System.Collections.Generic;

namespace Builder
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataEmissao { get; set; }

        public double ValorBruto { get; set; }
        public double Impostos { get; set; }
        public IList<ItemDaNota> Itens = new List<ItemDaNota>();

        public string Observacoes { get; set; }

        public void ParaEmpresa(string nome)
        {
            this.RazaoSocial = nome;
        }

        public void ComCnpj(string cnpj)
        {
            this.Cnpj = cnpj;
        }

        public void ComObservacoes(string obs)
        {
            this.Observacoes = obs;
        }

        public void NaDataAtual()
        {
            this.DataEmissao = DateTime.Now;
        }

        public void ComItem(ItemDaNota item)
        {
            this.Itens.Add(item);
            this.ValorBruto += item.Valor;
            this.Impostos += item.Valor * 0.05;
        }

        public NotaFiscal CriarNota()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, DataEmissao, ValorBruto, Impostos, Itens, Observacoes);
        }
    }
}
