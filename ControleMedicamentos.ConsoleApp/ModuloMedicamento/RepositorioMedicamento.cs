
using ControleMedicamentos.ConsoleApp.Compartilhado;

using ControleMedicamentos.ConsoleApp.ModuloFornecedor;



namespace ControleMedicamentos.ConsoleApp.ModuloMedicamento
{
    public class RepositorioMedicamento : RepositorioMae
    {
        public RepositorioFornecedor repositoriofornecedor = null;
        public TelaFornecedor telafornecedor = null;
        public void CadastrarMedicamento()
        {
            Medicamentos medicamento = new Medicamentos();

            Fornecedor fornecedor = null;
             
            Console.WriteLine(" Digite o codigo do remedio: ");
            medicamento.codigoRemedio = int.Parse(Console.ReadLine());

            Console.Write(" Digite o nome do remedio: ");
            medicamento.nomeRemedio = Console.ReadLine();

            Console.Write(" Digite a decrição do remedio: ");
            medicamento.descricaoRemedio = Console.ReadLine();

            Console.Write(" Digite a quantidade disponivel do remedio: ");
            medicamento.quantidadeDisponivel = int.Parse(Console.ReadLine());

            Console.Write(" Digite o limite disponivel do remedio no estoque: ");
            medicamento.quantidadeLimiteRemedio = int.Parse(Console.ReadLine());

            //  Console.Write("Digite a validade do remedio: ");
            medicamento.Validade = DateTime.Now;


            telafornecedor.VerificarFornecedor();

            Console.WriteLine();

            Console.Write("Codigo Fornecedor: ");
            int codigoescohido = Convert.ToInt32(Console.ReadLine());

                foreach (Fornecedor item in repositoriofornecedor.listaRegistros)
                {
                    if (item.codigoFornecedor == codigoescohido)
                    {
                        fornecedor = item;
                        medicamento.achou = true;
                    }
                    else
                    {
                        medicamento.achou = false;
                    }
                }

            if (medicamento.achou == true)
            {
                medicamento.IdRemedio = listaRegistros.Count;
                medicamento.codigoescolhido = fornecedor;
                medicamento.IdRemedio++;
                listaRegistros.Add(medicamento);
                Console.WriteLine("Cadastro feito com sucesso.");
            }
            else
            {
                Console.WriteLine("Fornecedor não existe, tente Cadastra-la");
            }
        }
        public void EditarMedicamento()
        {
            Medicamentos remedios = new Medicamentos();

            Fornecedor fornecedor = null;

            Console.Write("Qual o ID gostaria de Editar: ");
            remedios.remove = Convert.ToInt32(Console.ReadLine());

            SelecionarPorCodigo(remedios.remove);

            listaRegistros.RemoveAt(remedios.remove);

            Console.Write("Digite o nome do remedio: ");
            remedios.nomeRemedio = Console.ReadLine();

            Console.Write("Digite a decrição do remedio: ");
            remedios.descricaoRemedio = Console.ReadLine();

            Console.Write("Digite a quantidade disponivel do remedio: ");
            remedios.quantidadeDisponivel = int.Parse(Console.ReadLine());

            Console.Write("Digite o limite disponivel do remedio no estoque: ");
            remedios.quantidadeLimiteRemedio = int.Parse(Console.ReadLine());

            Console.Write("Digite a validade do remedio: ");
            remedios.Validade = DateTime.Now;


            Console.WriteLine("Codigo fornecedor");
            int codigoescolhido = Convert.ToInt32(Console.ReadLine());

            foreach (Fornecedor item in repositoriofornecedor.listaRegistros)
            {
                if (item.idFornecedor == codigoescolhido)
                {
                    fornecedor = item;
                    remedios.achou = true;
                }
                else
                {
                    remedios.achou = false;
                }
            }

            if (remedios.achou == true)
            {
                remedios.IdRemedio = listaRegistros.Count;
                remedios.codigoescolhido = fornecedor;
                remedios.IdRemedio++;
                listaRegistros.Add(remedios);
                Console.WriteLine("Edição feita com sucesso.");
            }
            else
            {
                Console.WriteLine("Fornecedor não existe, tente Cadastra-la");
            }
        }
        public void ExcluirMedicamento()
        {
            Medicamentos medicamento = new Medicamentos();
            Console.Write("Qual codigo do medicamento: ");
            medicamento.remove = Convert.ToInt32(Console.ReadLine());

            SelecionarPorCodigo(medicamento.remove);
            listaRegistros.RemoveAt(medicamento.remove);

            Console.WriteLine("Exclusão feita com sucesso.");
        }
        public Medicamentos SelecionarPorCodigo(int codigo)
        {
            foreach (Medicamentos r in listaRegistros)
            {
                if (r.codigoRemedio == codigo)
                {
                    return r;
                }
            }
            return null;
        }
    }
}
