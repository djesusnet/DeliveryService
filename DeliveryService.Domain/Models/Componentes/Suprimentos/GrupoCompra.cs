using PlataformaIHARA.Domain.Core.Models;

namespace Domain.Models.Componentes.Suprimentos
{
    public class GrupoCompra : Entity<int>
    {
        public GrupoCompra(int id) => Id = id;

        public GrupoCompra() { }

        public string Descricao { get; set; }
        public int Codigo { get; set; }
    }
}
