using Domain.Cotacao.Models;
using PlataformaIHARA.Domain.Core.Models;
using System;
using System.Collections.Generic;

namespace Domain.Models.Componentes.Suprimentos
{
    public class Moeda : Entity<Guid>
    {
        public Moeda(Guid id) => Id = id;

        public Moeda() { }

        public string Descricao { get; set; }

        /// <summary>
        /// Ex: D, R
        /// </summary>
        public string Codigo { get; set; }
        public IEnumerable<ComponenteCotacaoFornecedor> ComponenteCotacaoFornecedor { get; set; }
    }
}
