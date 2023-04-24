using ControleMedicamentos.ConsoleApp.Compartilhado;

namespace ControleMedicamentos.ConsoleApp.ModuloFornecedor
{
    public class RepositorioFornecedor : RepositorioMae
    {
        public void CadastrarFornecedor()
        {
            Fornecedor fornecedor = new Fornecedor();

            Console.WriteLine("Codigo Fornecedor");
            fornecedor.codigoFornecedor = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome Fornecedor: ");
            fornecedor.nomeFornecedor = Console.ReadLine();
            Console.WriteLine(" Telefone Fornecedor: ");
            fornecedor.telephoneFornecedor = Console.ReadLine();
            Console.WriteLine(" email fornecedor: ");
            fornecedor.email = Console.ReadLine();
            Console.WriteLine(" endereço fornecedor");
            fornecedor.endereco = Console.ReadLine();

            fornecedor.idFornecedor = listaRegistros.Count;

            fornecedor.idFornecedor++;

            listaRegistros.Add(fornecedor);

            Console.WriteLine("Cadastro feito com sucesso.");
        }
        public void EditarFornecedor()
        {
            Fornecedor fornecedor = new Fornecedor();
            
            Console.WriteLine("Codigo Fornecedor");
            fornecedor.remove = Convert.ToInt32(Console.ReadLine());

            fornecedor = SelecionarPorCodigo(fornecedor.remove);

            listaRegistros.Remove(fornecedor);

            Console.WriteLine("Nome Fornecedor: ");
            fornecedor.nomeFornecedor = Console.ReadLine();
            Console.WriteLine(" Telefone Fornecedor: ");
            fornecedor.telephoneFornecedor = Console.ReadLine();
            Console.WriteLine(" email fornecedor: ");
            fornecedor.email = Console.ReadLine();
            Console.WriteLine(" endereço fornecedor");
            fornecedor.endereco = Console.ReadLine();
            fornecedor.idFornecedor = listaRegistros.Count;

            fornecedor.idFornecedor++;

            listaRegistros.Add(fornecedor);

            Console.WriteLine("Edição feita com sucesso.");
        }
        public void ExcluirFornecedor()
        {
            Fornecedor fornecedor = new Fornecedor();

            Console.WriteLine("Codigo Fornecedor");
            fornecedor.remove = Convert.ToInt32(Console.ReadLine());

            fornecedor = SelecionarPorCodigo(fornecedor.remove);

            listaRegistros.Remove(fornecedor);

            Console.WriteLine("Exclusão feita com sucesso.");
        }
        public Fornecedor SelecionarPorCodigo(int id)
        {
            foreach (Fornecedor c in listaRegistros)
            {
                if (c.codigoFornecedor == id)
                {
                    return c;
                }
            }
            return null;
        }
    }
}