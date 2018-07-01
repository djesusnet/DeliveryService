using System;
using PlataformaIHARA.Domain.Core.Models;

namespace Domain.Models.Componentes.Fornecedores.Especificacoes
{
    public class EspecificacaoItem : Entity<int>
    {
        public string Descricao { get; private set; }
        public AnaliseItem AnaliseItem { get; private set; }
        public AnaliseTipo AnaliseTipo { get; private set; }
        public bool TeorAtivo { get; private set; }
        public bool TeorNaCl { get; private set; }
        public decimal AnaliseInicialIhara { get; private set; }
        public decimal AnaliseFinalIhara { get; private set; }
        public decimal AnaliseInicialAbnt { get; private set; }
        public decimal AnaliseFinalAbnt { get; private set; }
        public Especificacao Especificacao { get; private set; }

        protected EspecificacaoItem() { }

        public EspecificacaoItem(string descricao, AnaliseItem analiseItem, AnaliseTipo analiseTipo,
            bool teorAtivo, bool teorNaCl, decimal analiseInicialIhara, decimal analiseFinalIhara,
            decimal analiseInicialAbnt, decimal analiseFinalAbnt, Especificacao especificacao)
        {
            Descricao = descricao;
            AnaliseItem = analiseItem;
            AnaliseTipo = analiseTipo;
            TeorAtivo = teorAtivo;
            TeorNaCl = teorNaCl;
            AnaliseInicialIhara = analiseInicialIhara;
            AnaliseFinalIhara = analiseFinalIhara;
            AnaliseInicialAbnt = analiseInicialAbnt;
            AnaliseFinalAbnt = analiseFinalAbnt;
            Especificacao = especificacao;
        }

        public virtual void AtualizarEspecificacaoItem(int especificacaoItemId, string descricao, AnaliseItem analiseItem,
            AnaliseTipo analiseTipo, bool teorAtivo, bool teorNaCl, decimal analiseInicialIhara, decimal analiseFinalIhara,
            decimal analiseInicialAbnt, decimal analiseFinalAbnt)
        {
            Descricao = descricao;
            AnaliseItem = analiseItem;
            AnaliseTipo = analiseTipo;
            TeorAtivo = teorAtivo;
            TeorNaCl = teorNaCl;
            AnaliseInicialIhara = analiseInicialIhara;
            AnaliseFinalIhara = analiseFinalIhara;
            AnaliseInicialAbnt = analiseInicialAbnt;
            AnaliseFinalAbnt = analiseFinalAbnt;
        }
    }
}
