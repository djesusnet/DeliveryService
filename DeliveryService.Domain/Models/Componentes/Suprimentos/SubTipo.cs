using PlataformaIHARA.Domain.Core.Models;

namespace Domain.Models.Componentes.Suprimentos
{
    public class SubTipo : Entity<int>
    {
        public SubTipo(int id) => Id = id;

        public SubTipo() { }

        public string Descricao { get; set; }
        public int Codigo { get; set; }
    }
}
