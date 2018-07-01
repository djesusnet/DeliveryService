using PlataformaIHARA.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models.Componentes.Fornecedores.Especificacoes
{
    public class Especificacao : Entity<int>
    {
        public ComponenteFornecedor ComponenteFornecedor { get; private set; }
        public virtual int Revisao { get; private set; }
        public DateTime DataRevisao { get; private set; }
        public virtual IList<EspecificacaoItem> EspecificacaoItens { get; private set; }

        protected Especificacao() { }

        public Especificacao(ComponenteFornecedor componenteFornecedor, int revisao, DateTime dataRevisao)
        {
            ComponenteFornecedor = componenteFornecedor;
            Revisao = revisao;
            DataRevisao = dataRevisao;
            EspecificacaoItens = new List<EspecificacaoItem>();
        }

        public virtual void AdicionarEspecificacaoItem(int especificacaoItemId, string descricao, AnaliseItem analiseItem,
            AnaliseTipo analiseTipo, bool teorAtivo, bool teorNaCl, decimal analiseInicialIhara, decimal analiseFinalIhara,
            decimal analiseInicialAbnt, decimal analiseFinalAbnt, Especificacao especificacao)
        {
            if (PossuiEspecificacaoItem(especificacaoItemId))
                throw new InvalidOperationException("O item de especificação informado já encontra-se na lista de Itens de Especificação");

            var especificacaoItem = new EspecificacaoItem(descricao, analiseItem, analiseTipo, teorAtivo, teorNaCl,
                analiseInicialIhara, analiseFinalIhara, analiseInicialAbnt, analiseFinalAbnt, especificacao);

            EspecificacaoItens.Add(especificacaoItem);
        }

        public virtual void RemoverEspecificacaoItem(EspecificacaoItem especificacaoItem)
        {
            if (!PossuiEspecificacaoItem(especificacaoItem.Id))
                throw new InvalidOperationException("O item de especificação informado não encontra-se na lista de Itens de Especificação");

            EspecificacaoItens.Remove(especificacaoItem);
        }

        public virtual bool PossuiEspecificacaoItem(int especificacaoItemId) =>
            especificacaoItemId != 0 && EspecificacaoItens.Any(x => x.Id == especificacaoItemId);
    }
}
