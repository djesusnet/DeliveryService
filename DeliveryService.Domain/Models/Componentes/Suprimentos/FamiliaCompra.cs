using PlataformaIHARA.Domain.Core.Models;

namespace Domain.Models.Componentes.Suprimentos
{
    public class FamiliaCompra : Entity<int>
    {
        public FamiliaCompra(int id) => Id = id;

        public FamiliaCompra() { }

        public string Descricao { get; set; }
        public int Codigo { get; set; }
    }
}
