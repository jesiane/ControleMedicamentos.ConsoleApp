using ControleMedicamentos.ConsoleApp.Compartilhado;

namespace ControleMedicamentos.ConsoleApp.ModuloMedicamento
{
    public class TelaMedicamento : RepositorioMae
    {
        public RepositorioMedicamento repositorio = null;
        public void MenuMedicamento(RepositorioMedicamento medicamento)
        { 
            bool menumedicamento = true;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ========================");
            Console.WriteLine(" Farmacia -> Medicamentos");
            Console.WriteLine(" ========================");
            Console.ResetColor();
            Console.WriteLine();


            while (menumedicamento)
            {
                Console.WriteLine(" === Medicamentos ===");
                Console.WriteLine();
                Console.WriteLine(" 1 - Cadastro Medicamento");
                Console.WriteLine(" 2 - Editar Medicamento");
                Console.WriteLine(" 3 - Excluir Medicamento");
                Console.WriteLine(" 4 - Visualizar Medicamentos");
                Console.WriteLine(" S - Voltar ao menu principal");
                Console.WriteLine(" --------------------");

                string escolha = Console.ReadLine().ToUpper();

                if (escolha == "1")
                {
                    medicamento.CadastrarMedicamento();
                }
                else if (escolha == "2")
                {
                    medicamento.EditarMedicamento();
                }
                else if (escolha == "3")
                {
                    medicamento.ExcluirMedicamento();
                }
                else if (escolha == "4")
                {
                    VerificarMedicamento();
                }
                else if (escolha == "S")
                {
                    menumedicamento = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida, tente novamente");
                    Console.ResetColor();
                }
            }
        }
        public void VerificarMedicamento()
        {
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(" |{0,-5} | {1,-10} | {2, -10}| {3, -10}|{4, -10}|","id", "Codigo Remedio", "Nome Remedio", "Descrição Remedio", "Fornecedor", "Quantidade Disponivel");

            Console.WriteLine(" |-----------------------------------------------------------------|");

            foreach (Medicamentos item in repositorio.listaRegistros)
            {
                Console.WriteLine(" |{0,-5}|{0,-5} | {1,-10} | {2, -10}| {3, -10}|{4, -10}|",item.IdRemedio, item.codigoRemedio, item.nomeRemedio, item.descricaoRemedio, item.fornecedor, item.quantidadeDisponivel);
            }
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}