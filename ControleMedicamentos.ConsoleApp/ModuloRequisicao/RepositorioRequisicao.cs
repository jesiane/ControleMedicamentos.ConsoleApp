using ControleMedicamentos.ConsoleApp.Compartilhado;
using ControleMedicamentos.ConsoleApp.ModuloFornecedor;
using ControleMedicamentos.ConsoleApp.ModuloFuncionario;
using ControleMedicamentos.ConsoleApp.ModuloMedicamento;
using ControleMedicamentos.ConsoleApp.ModuloPaciente;
using ControleMedicamentos.ConsoleApp.ModuloRequisição;

namespace ControleMedicamentos.ConsoleApp.ModuloRequisição
{
    public class RepositorioRequisicao : RepositorioMae
    {
        public RepositorioMedicamento repositoriomedicamento = null;
        public TelaMedicamento telamedicamento = null;
        public RepositorioPaciente repositoriopaciente = null;
        public TelaPaciente telapaciente = null;
        public void CadastrarRequisicao()
        {
            Requisicao requisicao = new Requisicao();

            Medicamentos medicamentos = null;

            Paciente pacientes = null;

            bool remedioachou = false;
            bool revistaachou = false;

            Console.WriteLine(" === Requisição do Paciente ===");
            Console.WriteLine();

            SelecionarPorCodigo(requisicao.remove);

            Console.WriteLine(" Cartão SUS do Paciente");
            int cartaosus = int.Parse(Console.ReadLine());


            foreach (Paciente item in repositoriopaciente.listaRegistros)
            {
                if (item.CartaoSUS == cartaosus)
                {
                    pacientes = item;
                    remedioachou = true;
                }
                else
                {
                    remedioachou = false;
                }
            }

            if (remedioachou == true)
            {
                requisicao.IdRequisicao = listaRegistros.Count;
                requisicao.paciente = pacientes;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Paciente não existe, tente Cadastra-lo");
                Console.ResetColor();
                return;
            }


            Console.Write("Qual o codigo do remedio: ");
            int codigoescolhido = Convert.ToInt32(Console.ReadLine());

            foreach (Medicamentos item in repositoriomedicamento.listaRegistros)
            {
                if (item.IdRemedio == codigoescolhido)
                {
                    medicamentos = item;
                    revistaachou = true;
                }
                else
                {
                    revistaachou = false;
                }
            }

            if (revistaachou == true)
            {
                requisicao.IdRequisicao = listaRegistros.Count;
                requisicao.remedio = medicamentos;
                requisicao.IdRequisicao++;
                listaRegistros.Add(requisicao);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Cadastro feito com sucesso.");
                Console.ResetColor();
                Console.WriteLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Remedio não disponivel, Entre en contato com o fornecedor");
                Console.ResetColor();   
            }
        }


        public Requisicao SelecionarPorCodigo(int id)
        {
            foreach (Requisicao e in listaRegistros)
            {
                if (e.codigoRequisicao == id)
                {
                    return e;
                }
            }
            return null;
        }
    }
}
