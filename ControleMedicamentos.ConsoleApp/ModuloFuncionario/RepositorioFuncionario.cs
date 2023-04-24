using ControleMedicamentos.ConsoleApp.Compartilhado;

namespace ControleMedicamentos.ConsoleApp.ModuloFuncionario
{
    public class RepositorioFuncionario : RepositorioMae
    {
        public void CadastrarFuncionario()
        {
            Funcionario funcionario = new Funcionario();
            Console.WriteLine(" == Funcionario ==");
            Console.WriteLine();
            Console.WriteLine("Matricula do Funcionario");
            funcionario.numMatricula = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Nome Funcionario");
            funcionario.nomeFuncionario = Console.ReadLine();
            Console.WriteLine(" CPF Funcionario");
            funcionario.docFuncionario = Console.ReadLine();
            Console.WriteLine(" Telefone Funcionario");
            funcionario.telefoneFuncionario = Console.ReadLine();
            Console.WriteLine(" Endereço Funcionario");
            funcionario.EnderecoFuncionario = Console.ReadLine();

            funcionario.idFuncionario = listaRegistros.Count;

            listaRegistros.Add(funcionario);

            Console.WriteLine("Cadastro feito com sucesso.");
        }

        public void EditarFuncionario()
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Matricula do Funcionario");
            funcionario.remove = Convert.ToInt32(Console.ReadLine());

            funcionario = SelecionarPorID(funcionario.remove);

            listaRegistros.Remove(funcionario);

            Console.WriteLine(" Nome Funcionario");
            funcionario.nomeFuncionario = Console.ReadLine();
            Console.WriteLine(" CPF Funcionario");
            funcionario.docFuncionario = Console.ReadLine();
            Console.WriteLine(" Telefone Funcionario");
            funcionario.telefoneFuncionario = Console.ReadLine();
            Console.WriteLine(" Endereço Funcionario");
            funcionario.EnderecoFuncionario = Console.ReadLine();

            funcionario.idFuncionario = listaRegistros.Count;

            funcionario.idFuncionario--;

            listaRegistros.Add(funcionario);

            Console.WriteLine("Edição feita com sucesso.");

        }

        public void ExcluirFuncionario()
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Qual ID gostaria de Excluir: ");
            funcionario.remove = Convert.ToInt32(Console.ReadLine());

            funcionario = SelecionarPorID(funcionario.remove);

            listaRegistros.Remove(funcionario);

            funcionario.idFuncionario++;

            listaRegistros.Add(funcionario);
            
            Console.WriteLine("Exclusão feita com sucesso.");
        }
        public Funcionario SelecionarPorID(int id)
        {
            foreach (Funcionario a in listaRegistros)
            {
                if (a.numMatricula == id)
                {
                    return a;
                }
            }
            return null;
        }
        public void VerificarFuncionario()
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(" |{0,-5} | {1,-10} | {2, -10}| {3, -10}|{4, -10}|", "Id", "Nome Funcionario", "CPF funcionario", "Telefone", "Endereço");

            Console.WriteLine(" |-----------------------------------------------------------------|");

            foreach (Funcionario item in listaRegistros)
            {
                Console.WriteLine(" |{0,-5} | {1,-10} | {2, -10}| {3, -10}|{4, -10}|", item.numMatricula, item.nomeFuncionario, item.docFuncionario, item.telefoneFuncionario, item.EnderecoFuncionario);
            }
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}