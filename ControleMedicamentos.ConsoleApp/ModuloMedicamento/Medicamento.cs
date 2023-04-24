using ControleMedicamentos.ConsoleApp.ModuloFornecedor;

namespace ControleMedicamentos.ConsoleApp.ModuloMedicamento
{
    public class Medicamentos
    {
        public int IdRemedio { get; set; }

        public int codigoRemedio { get; set; }
        public string nomeRemedio { get; set; }
        public string descricaoRemedio { get; set; }
        public int quantidadeDisponivel { get; set; }
        public int quantidadeLimiteRemedio { get; set; }
        public DateTime Validade { get; set; }
        public int remove { get; set; }
        public bool achou { get; set; }

        public Fornecedor codigoescolhido { get; set; }
        //    public List<Requisicao> Requisicoes { get; set; }
        public Fornecedor fornecedor { get; set; }
        // public int QuantidadeRequisicoes { get { return Requisicoes.Count; } }
    
    }
}
