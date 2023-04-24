using ControleMedicamentos.ConsoleApp.ModuloFornecedor;
using ControleMedicamentos.ConsoleApp.ModuloFuncionario;
using ControleMedicamentos.ConsoleApp.ModuloMedicamento;
using ControleMedicamentos.ConsoleApp.ModuloPaciente;
using ControleMedicamentos.ConsoleApp.ModuloRequisição;


namespace ControleMedicamentos.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            TelaPaciente paciente = new TelaPaciente();

            TelaRequisicao requisicao = new TelaRequisicao();

            TelaMedicamento medicamento = new TelaMedicamento();

            TelaFuncionario funcionario = new TelaFuncionario();

            TelaFornecedor fornecedor = new TelaFornecedor();
            //
            RepositorioPaciente repositoriopaciente = new RepositorioPaciente();

            RepositorioRequisicao repositoriorequisicao = new RepositorioRequisicao();

            RepositorioMedicamento repositoriomedicamento = new RepositorioMedicamento();

            RepositorioFornecedor repositoriofornecedor = new RepositorioFornecedor();

            RepositorioFuncionario repositoriofuncionario = new RepositorioFuncionario();
            //
            repositoriomedicamento.repositoriofornecedor = repositoriofornecedor;

            repositoriomedicamento.telafornecedor = fornecedor;
            //
            fornecedor.repositorio = repositoriofornecedor;

            medicamento.repositorio = repositoriomedicamento;

            paciente.repositorio = repositoriopaciente;


            repositoriorequisicao.repositoriomedicamento = repositoriomedicamento;

            repositoriorequisicao.repositoriopaciente = repositoriopaciente;



            requisicao.repositorio = repositoriorequisicao;

            bool menuservico = true;
            while (menuservico == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" =====================");
                Console.WriteLine("       Farmacia");
                Console.WriteLine(" =====================");
                Console.ResetColor();
                Console.WriteLine();

                Console.WriteLine(" 1 - Paciente");
                //Console.WriteLine(" 2 - Requisicao");
                Console.WriteLine(" 2 - Medicamento");
                Console.WriteLine(" 3 - Fornecedor");
                Console.WriteLine(" 4 - Funcionario");
                Console.WriteLine(" S - Fechar Programa");
                Console.WriteLine(" --------------------");

                string escolha = Console.ReadLine().ToUpper();

                if (escolha == "1")
                {
                    paciente.MenuPaciente(repositoriopaciente);
                }
                //else if (escolha == "2")
                //{
                //    requisicao.MenuRequisicao(repositoriorequisicao);
                //}
                else if (escolha == "2")
                {
                    medicamento.MenuMedicamento(repositoriomedicamento);
                }
                else if (escolha == "3")
                {
                    fornecedor.MenuFornecedor(repositoriofornecedor);
                }
                else if (escolha == "4")
                {
                    funcionario.MenuFuncionario(repositoriofuncionario);
                }

                else if (escolha == "S")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Obrigado pelo acesso ao Sistema!");
                    menuservico = false;
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Opção indisponivel, tente de novo");
                    Console.ResetColor();

                }
                Console.ReadKey();
            }
        }
    }
}