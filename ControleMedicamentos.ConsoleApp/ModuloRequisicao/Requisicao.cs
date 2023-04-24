
using ControleMedicamentos.ConsoleApp.ModuloMedicamento;
using ControleMedicamentos.ConsoleApp.ModuloPaciente;

namespace ControleMedicamentos.ConsoleApp.ModuloRequisição
{
    public class Requisicao
    {

        public int IdRequisicao { get; set; }
        public int codigoRequisicao { get; set; }
        public int remove { get; set; }
        public bool achou { get; set; }

        public string pedido { get; set; }
        public Paciente paciente { get; set; }

        public Medicamentos remedio { get; set; }
    }
}
