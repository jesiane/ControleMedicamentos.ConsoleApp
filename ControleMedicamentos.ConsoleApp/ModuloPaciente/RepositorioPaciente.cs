using ControleMedicamentos.ConsoleApp.Compartilhado;

namespace ControleMedicamentos.ConsoleApp.ModuloPaciente
{
    public class RepositorioPaciente : RepositorioMae
    {
            public void CadastrarAmigos()
            {
                Paciente paciente = new Paciente();

                Console.WriteLine(" Paciente");
                Console.WriteLine();
                Console.WriteLine($" Codigo do Paciente");
                paciente.codigoPaciente = int.Parse(Console.ReadLine());
                Console.WriteLine(" Nome Paciente: ");
                paciente.nomePaciente = Console.ReadLine();
                Console.WriteLine(" CPF Paciente: : ");
                paciente.docPaciente = Console.ReadLine();
                Console.WriteLine(" Cartão SUS");
                paciente.CartaoSUS = int.Parse(Console.ReadLine());
                Console.WriteLine(" Telefone Paciente: ");
                paciente.telephonePaciente = Console.ReadLine();
                Console.WriteLine(" Endereço Paciente");
                paciente.enderecoPaciente = Console.ReadLine();

                paciente.idPaciente = listaRegistros.Count;
                paciente.idPaciente++;

                listaRegistros.Add(paciente);

                Console.WriteLine("Cadastro feito com sucesso.");
                Console.WriteLine();
            }
            public void EditarAmigos()
            {
                Paciente paciente = new Paciente();

                Console.WriteLine($"Codigo do Paciente");
                paciente.remove = Convert.ToInt32(Console.ReadLine());

                paciente = SelecionarPorCodigo(paciente.remove);

                listaRegistros.Remove(paciente);

                Console.WriteLine(" Paciente");
                Console.WriteLine();
                Console.WriteLine(" Nome Paciente: ");
                paciente.nomePaciente = Console.ReadLine();
                Console.WriteLine(" CPF Paciente: : ");
                paciente.docPaciente = Console.ReadLine();
                Console.WriteLine(" Cartão SUS");
                paciente.CartaoSUS = int.Parse(Console.ReadLine());
                Console.WriteLine(" Telefone Paciente: ");
                paciente.telephonePaciente = Console.ReadLine();
                Console.WriteLine(" Endereço Paciente: ");
                paciente.enderecoPaciente = Console.ReadLine();

                paciente.idPaciente = listaRegistros.Count;

                paciente.idPaciente++;

                listaRegistros.Add(paciente);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Edição feita com sucesso.");
                Console.ResetColor();
                Console.WriteLine();
            }
            public void ExcluirAmigos()
            {
                Paciente amigos = new Paciente();


                Console.WriteLine($"Codigo do Paciente");
                amigos.remove = Convert.ToInt32(Console.ReadLine());

                amigos = SelecionarPorCodigo(amigos.remove);

                listaRegistros.Remove(amigos);

                amigos.idPaciente++;

                listaRegistros.Add(amigos);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Exclusão feita com sucesso. ");
                Console.ResetColor();
                Console.WriteLine();

            }
            public Paciente SelecionarPorCodigo(int id)
            {
                foreach (Paciente a in listaRegistros)
                {
                    if (a.codigoPaciente == id)
                    {
                        return a;
                    }
                }
                return null;
            }
        }
    }
