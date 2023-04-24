using ControleMedicamentos.ConsoleApp.Compartilhado;
using ControleMedicamentos.ConsoleApp.ModuloRequisição;

namespace ControleMedicamentos.ConsoleApp.ModuloPaciente
{
    public class TelaPaciente : RepositorioMae
    {
        public RepositorioPaciente repositorio = null;



        public void MenuPaciente(RepositorioPaciente paciente)
        {
            RepositorioRequisicao repositoriorequisicao = new RepositorioRequisicao();
            TelaRequisicao aquisicao = new TelaRequisicao();

            bool menupaciente = true;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" =====================");
            Console.WriteLine(" Farmacia => Pacientes");
            Console.WriteLine(" =====================");
            Console.ResetColor();
            Console.WriteLine();


            while (menupaciente)
            {
                Console.WriteLine(" === Paciente ===");
                Console.WriteLine();
                Console.WriteLine(" 1 - Cadastro Paciente");
                Console.WriteLine(" 2 - Editar Paciente");
                Console.WriteLine(" 3 - Excluir Paciente");
                Console.WriteLine(" 4 - Visualizar Paciente");
                Console.WriteLine(" 5 - Requisição Paciente");
                Console.WriteLine(" S - Voltar ao menu principal");
                Console.WriteLine(" --------------------");

                string escolha = Console.ReadLine().ToUpper();

                if (escolha == "1")
                {
                    paciente.CadastrarAmigos();
                }
                else if (escolha == "2")
                {
                    paciente.EditarAmigos();
                }
                else if (escolha == "3")
                {
                    paciente.ExcluirAmigos();
                }
                else if (escolha == "4")
                {
                    VerificarPaciente();
                }
                else if (escolha == "5")
                {
                    aquisicao.MenuRequisicao(repositoriorequisicao);
                }
                else if (escolha == "S")
                {
                    menupaciente = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida, tente novamente");
                    Console.ResetColor();
                }
            }

        }
        public void VerificarPaciente()
        {
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(" |{0,-5} | {1,-10} | {2, -10}| {3, -10}|{4, -10}|", "Codigo Paciente", "CartaoSUS", "Nome Paciente", "CPF Paciente", "Telefone Paciente", "Endereço Paciente");


            Console.WriteLine(" |----------------------------------------------------------------------------|");

            foreach (Paciente item in repositorio.listaRegistros)
            {
                Console.WriteLine(" |{0,-5} | {1,-10} | {2, -10}| {3, -10}|{4, -10}|", item.codigoPaciente, item.CartaoSUS, item.nomePaciente, item.docPaciente, item.telephonePaciente, item.enderecoPaciente);
            }
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }

    }
}