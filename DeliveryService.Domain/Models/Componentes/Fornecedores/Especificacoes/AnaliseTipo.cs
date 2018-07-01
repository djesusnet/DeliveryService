using PlataformaIHARA.Domain.Core.Models;

namespace Domain.Models.Componentes.Fornecedores.Especificacoes
{
    public class AnaliseTipo : Entity<int>
    {
        public string Descricao { get; private set; }

        protected AnaliseTipo() { }

        public AnaliseTipo(string descricao) => Descricao = descricao;
    }
}