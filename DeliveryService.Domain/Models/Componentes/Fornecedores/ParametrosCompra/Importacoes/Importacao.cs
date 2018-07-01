using PlataformaIHARA.Domain.Core.Models;

namespace Domain.Models.Componentes.Fornecedores.ParametrosCompra.Importacoes
{
    public class Importacao : Entity<int>
    {
        public ComponenteFornecedor ComponenteFornecedor { get; private set; }
        public int TempoMaritimo { get; private set; }
        public int TempoAereo { get; private set; }
        public int TempoRodoviario { get; private set; }
        public string ShippingMark { get; private set; }
        public string SpecialInstruction { get; private set; }
        public string GeneralInstruction { get; private set; }

        protected Importacao() { }

        public Importacao(ComponenteFornecedor componenteFornecedor, int tempoMaritimo, int tempoAereo, int tempoRodoviario,
            string shippingMark, string specialInstruction, string generalInstruction)
        {
            ComponenteFornecedor = componenteFornecedor;
            TempoMaritimo = tempoMaritimo;
            TempoAereo = tempoAereo;
            TempoRodoviario = tempoRodoviario;
            ShippingMark = shippingMark;
            SpecialInstruction = specialInstruction;
            GeneralInstruction = generalInstruction;
        }

        public void AtualizarInformacoes(int tempoMaritimo, int tempoAereo, int tempoRodoviario, string shippingMark, string specialInstruction, string generalInstruction)
        {
            TempoMaritimo = tempoMaritimo;
            TempoAereo = tempoAereo;
            TempoRodoviario = tempoRodoviario;
            ShippingMark = shippingMark;
            SpecialInstruction = specialInstruction;
            GeneralInstruction = generalInstruction;
        }
    }
}
