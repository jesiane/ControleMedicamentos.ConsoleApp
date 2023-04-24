using ControleMedicamentos.ConsoleApp.ModuloMedicamento;

namespace ControleMedicamentos.ConsoleApp.ModuloFornecedor

{
    public class Fornecedor
    {
        public int idFornecedor { get; set; }
        public int codigoFornecedor { get; set; }
        public string nomeFornecedor { get; set; }
        public string telephoneFornecedor { get; set; }
        public string email { get; set; }
        public string endereco { get; set; }

        public int remove { get; set; }
        public bool achou { get; set; }

        public Medicamentos medicamento { get; set; }

    }
}
