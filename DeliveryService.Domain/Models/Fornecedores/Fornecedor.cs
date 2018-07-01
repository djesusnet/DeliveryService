using Domain.Cotacao.Models;
using Domain.Models.Componentes.Fornecedores;
using PlataformaIHARA.Domain.Core.Models;
using System;
using System.Collections.Generic;

namespace Domain.Models.Fornecedores
{
    public class Fornecedor : Entity<Guid>
    {
        public Fornecedor(Guid id, string descricao, int codigo)
        {
            Id = id;
            Descricao = descricao;
            Codigo = codigo;
            ListComponenteFornecedor = new List<ComponenteFornecedor>();
        }

        protected Fornecedor() { }

        public string Descricao { get; private set; }
        public int Codigo { get; private set; }
        public IEnumerable<ComponenteCotacaoFornecedor> ComponenteCotacaoFornecedor { get; private set; }

        public List<ComponenteFornecedor> ListComponenteFornecedor
        {
            get; protected set;
        }
    }
}
