using System;
using System.Collections.Generic;

namespace Builder
{
    public class NotaFiscalBuilderFluentInterface
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataEmissao { get; set; }

        public double ValorBruto { get; set; }
        public double Impostos { get; set; }
        public IList<ItemDaNota> Itens = new List<ItemDaNota>();

        public string Observacoes { get; set; }

        //Os métodos retornam o próprio objeto criador, para facilitar a chamada na sequência
        public NotaFiscalBuilderFluentInterface ParaEmpresa(string nome)
        {
            this.RazaoSocial = nome;
            return this;
        }

        public NotaFiscalBuilderFluentInterface ComCnpj(string cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilderFluentInterface ComObservacoes(string obs)
        {
            this.Observacoes = obs;
            return this;
        }

        public NotaFiscalBuilderFluentInterface NaDataAtual()
        {
            this.DataEmissao = DateTime.Now;
            return this;
        }

        public NotaFiscalBuilderFluentInterface ComItem(ItemDaNota item)
        {
            this.Itens.Add(item);
            this.ValorBruto += item.Valor;
            this.Impostos += item.Valor * 0.05;
            return this;
        }

        public NotaFiscal CriarNota()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, DataEmissao, ValorBruto, Impostos, Itens, Observacoes);
        }
    }
}
