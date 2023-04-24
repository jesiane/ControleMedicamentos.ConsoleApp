using ControleMedicamentos.ConsoleApp.ModuloRequisição;

namespace ControleMedicamentos.ConsoleApp.ModuloPaciente
{
    
        public class Paciente
        {
            public int idPaciente { get; set; } = 1;
            public int codigoPaciente { get; set; }
            public string nomePaciente { get; set; }
            public string docPaciente { get; set; }
            public int CartaoSUS { get; set; }
            public string telephonePaciente { get; set; }

            public string enderecoPaciente { get; set; }
            public int remove { get; set; }
            public bool achou { get; set; }
            //     public Requisicao requisicao { get; set; }

        }
    }
