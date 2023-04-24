
using ControleMedicamentos.ConsoleApp.Compartilhado;

namespace ControleMedicamentos.ConsoleApp.ModuloRequisição
{
    public class TelaRequisicao : RepositorioMae
    {
        public RepositorioRequisicao repositorio = null;
        public void MenuRequisicao(RepositorioRequisicao requisicao)
        {
            bool menurequisicao = true;

            Console.WriteLine(" ==================================");
            Console.WriteLine(" Farmacia => Paciente => Requisição");
            Console.WriteLine(" ==================================");
            Console.ResetColor();
            Console.WriteLine();



            while (menurequisicao)
            {
                Console.WriteLine(" === Requisição ===");
                Console.WriteLine();
                Console.WriteLine(" 1 - Cadastro de Requisição");
                Console.WriteLine(" 2 - Verificar Requisições");
                Console.WriteLine(" 3 - --");
                Console.WriteLine(" 4 - --");
                Console.WriteLine(" 5 - Requisição Paciente");
                Console.WriteLine(" S - Voltar ao menu principal");
                Console.WriteLine(" --------------------");

                string escolha = Console.ReadLine().ToUpper();

                if (escolha == "1")
                {
                    requisicao.CadastrarRequisicao();
                }
                else if (escolha == "2")
                {
                    VerificarRequisições();
                }
                else if (escolha == "3")
                {
                    //requisicao.DevolverRevista();
                }
                else if (escolha == "4")
                {
                    VerificarRequisições();
                }
                else if (escolha == "S")
                {
                    menurequisicao = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida, tente novamente");
                    Console.ResetColor();
                }
            }
        }
        public void VerificarRequisições()
        {
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(" |{0,-5} | {1,-10} | {2, -10}| |", "Codigo Requisição", "Cartão SUS", "Nome Paciente");

            Console.WriteLine(" |-----------------------------------------------------------------|");

            foreach (Requisicao item in repositorio.listaRegistros)
            {
                Console.WriteLine(" |{0,-5} | {1,-10} | {2, -10}|", item.IdRequisicao, item.paciente.CartaoSUS, item.paciente.nomePaciente);
            }
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}