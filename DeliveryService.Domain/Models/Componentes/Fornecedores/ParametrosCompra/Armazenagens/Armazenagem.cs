using PlataformaIHARA.Domain.Core.Models;

namespace Domain.Models.Componentes.Fornecedores.ParametrosCompra.Armazenagens
{
    public class Armazenagem : Entity<int>
    {
        public string Descricao { get; private set; }
        public bool Padrao { get; private set; }
        public decimal Capacidade { get; private set; }
        public decimal Pallet { get; private set; }
        public int Empilhamento { get; private set; }
        public int EmpilhamentoMaximo { get; private set; }
        public decimal Quantidade { get; private set; }
        public decimal Altura { get; private set; }
        public decimal Largura { get; private set; }
        public decimal Comprimento { get; private set; }
        public decimal PesoBruto { get; private set; }
        public decimal PesoLiquido { get; private set; }
        public ComponenteFornecedor ComponenteFornecedor { get; private set; }
        public ArmazenagemTipo ArmazenagemTipo { get; private set; }
        public UnidadeMedida UnidadeMedida { get; private set; }
        public GrupoEmail GrupoEmail { get; private set; }

        public Armazenagem(string descricao, bool padrao, decimal capacidade, decimal pallet,
            int empilhamento, int empilhamentoMaximo, decimal quantidade, decimal altura, decimal largura,
            decimal comprimento, decimal pesoBruto, decimal pesoLiquido, ComponenteFornecedor componenteFornecedor,
            ArmazenagemTipo armazenagemTipo, UnidadeMedida unidadeMedida, GrupoEmail grupoEmail)
        {
            Descricao = descricao;
            Padrao = padrao;
            Capacidade = capacidade;
            Pallet = pallet;
            Empilhamento = empilhamento;
            EmpilhamentoMaximo = empilhamentoMaximo;
            Quantidade = quantidade;
            Altura = altura;
            Largura = largura;
            Comprimento = comprimento;
            PesoBruto = pesoBruto;
            PesoLiquido = pesoLiquido;
            ComponenteFornecedor = componenteFornecedor;
            ArmazenagemTipo = armazenagemTipo;
            UnidadeMedida = unidadeMedida;
            GrupoEmail = grupoEmail;
        }

        public Armazenagem(int id, string descricao, bool padrao, decimal capacidade, decimal pallet,
            int empilhamento, int empilhamentoMaximo, decimal quantidade, decimal altura, decimal largura,
            decimal comprimento, decimal pesoBruto, decimal pesoLiquido, ComponenteFornecedor componenteFornecedor,
            ArmazenagemTipo armazenagemTipo, UnidadeMedida unidadeMedida, GrupoEmail grupoEmail)
        {
            Id = id;
            Descricao = descricao;
            Padrao = padrao;
            Capacidade = capacidade;
            Pallet = pallet;
            Empilhamento = empilhamento;
            EmpilhamentoMaximo = empilhamentoMaximo;
            Quantidade = quantidade;
            Altura = altura;
            Largura = largura;
            Comprimento = comprimento;
            PesoBruto = pesoBruto;
            PesoLiquido = pesoLiquido;
            ComponenteFornecedor = componenteFornecedor;
            ArmazenagemTipo = armazenagemTipo;
            UnidadeMedida = unidadeMedida;
            GrupoEmail = grupoEmail;
        }

        protected Armazenagem() { }

        public void TornarPadrao() => Padrao = true;
        public void RemoverPadrao() => Padrao = false;

        public virtual void AtualizarInformacoes(string descricao, bool padrao, decimal capacidade, decimal pallet,
            int empilhamento, int empilhamentoMaximo, decimal quantidade, decimal altura, decimal largura,
            decimal comprimento, decimal pesoBruto, decimal pesoLiquido, ComponenteFornecedor componenteFornecedor,
            ArmazenagemTipo armazenagemTipo, UnidadeMedida unidadeMedida, GrupoEmail grupoEmail)
        {
            Descricao = descricao;
            Padrao = padrao;
            Capacidade = capacidade;
            Pallet = pallet;
            Empilhamento = empilhamento;
            EmpilhamentoMaximo = empilhamentoMaximo;
            Quantidade = quantidade;
            Altura = altura;
            Largura = largura;
            Comprimento = comprimento;
            PesoBruto = pesoBruto;
            PesoLiquido = pesoLiquido;
            ComponenteFornecedor = componenteFornecedor;
            ArmazenagemTipo = armazenagemTipo;
            UnidadeMedida = unidadeMedida;
            GrupoEmail = grupoEmail;
        }
    }
}

