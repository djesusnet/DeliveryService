using PlataformaIHARA.Domain.Core.Models;

namespace Domain.Models.Componentes.Fornecedores.ParametrosCompra.Armazenagens
{
    public class GrupoEmail : Entity<int>
    {
        public string Descricao { get; private set; }
        public string Emails { get; private set; }

        public GrupoEmail(string descricao, string emails)
        {
            Descricao = descricao;
            Emails = emails;
        }

        protected GrupoEmail() { }
    }
}
