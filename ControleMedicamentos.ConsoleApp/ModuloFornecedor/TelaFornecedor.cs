using ControleMedicamentos.ConsoleApp.Compartilhado;


namespace ControleMedicamentos.ConsoleApp.ModuloFornecedor
{
    public class TelaFornecedor : RepositorioMae
    {
        public RepositorioFornecedor repositorio = null;
        public void MenuFornecedor(RepositorioFornecedor fornecedor)
        {           
            bool menufornecedor = true;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" =======================");
            Console.WriteLine(" Farmacia -> Fornecedor ");
            Console.WriteLine(" =======================");
            Console.ResetColor();
            Console.WriteLine();

            while (menufornecedor)
            {
                Console.WriteLine(" === Fornecedor ===");
                Console.WriteLine();
                Console.WriteLine(" 1 - Cadastro Fornecedor");
                Console.WriteLine(" 2 - Editar Fornecedor");
                Console.WriteLine(" 3 - Excluir Fornecedor");
                Console.WriteLine(" 4 - Visualizar Fornecedores");
                Console.WriteLine(" S - Voltar ao menu principal");
                Console.WriteLine(" --------------------");

                string escolha = Console.ReadLine().ToUpper();
                Console.WriteLine();

                if (escolha == "1")
                {
                    fornecedor.CadastrarFornecedor();
                }
                else if (escolha == "2")
                {
                    fornecedor.EditarFornecedor();
                }
                else if (escolha == "3")
                {
                    fornecedor.ExcluirFornecedor();
                }
                else if (escolha == "4")
                {
                    VerificarFornecedor();
                }
                else if (escolha == "S")
                {
                    menufornecedor = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida, tente novamente");
                    Console.ResetColor();
                }
            }
        }
        public void VerificarFornecedor()
        {
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(" |{0,-5} | {1,-10} | {2, -10}| {3, -10}|{4, -10}|", "Codigo Fornecedor", "Nome Fornecedor", "Telefone fornecedor", "Email Fornecedor", "Endereço Fornecedor");

            Console.WriteLine(" |-----------------------------------------------------------------|");

            foreach (Fornecedor item in repositorio.listaRegistros)
            {
                Console.WriteLine(" |{0,-5} | {1,-10} | {2, -10}| {3, -10}|{4, -10}|", item.codigoFornecedor, item.nomeFornecedor, item.telephoneFornecedor, item.email, item.endereco);
            }
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
