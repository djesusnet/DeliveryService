using PlataformaIHARA.Domain.Core.Models;

namespace Domain.Models.Componentes.RestricoesCompra
{
    public class RestricaoCompra : Entity<int>
    {
        public string Descricao { get; set; }
        public int Codigo { get; set; }
    }
}
