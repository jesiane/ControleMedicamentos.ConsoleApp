using ControleMedicamentos.ConsoleApp.Compartilhado;

namespace ControleMedicamentos.ConsoleApp.ModuloFuncionario
{
    public class TelaFuncionario : RepositorioMae
    {
        public RepositorioFuncionario repositorio = null;
        public void MenuFuncionario(RepositorioFuncionario funcionario)
        {
            bool menufuncionario = true;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" =======================");
            Console.WriteLine(" Farmacia -> Funcionario");
            Console.WriteLine(" =======================");
            Console.ResetColor();
            Console.WriteLine();

            while (menufuncionario)
            {
                Console.WriteLine(" === Funcionario ===");
                Console.WriteLine();
                Console.WriteLine(" 1 - Cadastro Funcionario");
                Console.WriteLine(" 2 - Editar Funcionario");
                Console.WriteLine(" 3 - Excluir Funcionario");
                Console.WriteLine(" 4 - Visualizar Funcionario");
                Console.WriteLine(" S - Voltar ao menu principal");
                Console.WriteLine(" --------------------");
                string escolha = Console.ReadLine().ToUpper();

                if (escolha == "1")
                {
                    funcionario.CadastrarFuncionario();
                }
                else if (escolha == "2")
                {
                    funcionario.EditarFuncionario();
                }
                else if (escolha == "3")
                {
                    funcionario.ExcluirFuncionario();
                }
                else if (escolha == "4")
                {
                    funcionario.VerificarFuncionario();
                }
                else if (escolha == "S")
                {
                    menufuncionario = false;
                    Console.Clear();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida, tente novamente");
                    Console.ResetColor();
                }
            }
        }

    }
}
