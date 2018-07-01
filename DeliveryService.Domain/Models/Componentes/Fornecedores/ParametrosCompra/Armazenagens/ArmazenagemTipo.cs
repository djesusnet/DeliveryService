using PlataformaIHARA.Domain.Core.Models;
using System;

namespace Domain.Models.Componentes.Fornecedores.ParametrosCompra.Armazenagens
{
    public class ArmazenagemTipo : Entity<Guid>
    {
        public string Descricao { get; private set; }
        public int Codigo { get; private set; }

        public ArmazenagemTipo(string descricao, int codigo)
        {
            Descricao = descricao;
            Codigo = codigo;
        }

        protected ArmazenagemTipo() { }
    }
}
