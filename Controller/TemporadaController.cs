using System;
namespace Cadastro_Series
{
    public class TemporadaController : ControllerAbstract
    {
        private TemporadaRepositorio temporadaRepositorio = new TemporadaRepositorio();
        public TemporadaController() { }
        public override void Run()
        {
            base.Run();
        }

        public override string OpcaoUsuario()
        {
            while (true)
            {

                Console.WriteLine("MENU Temporadas ");
                Console.WriteLine("1 : Listar temporadas cadastradas ");
                Console.WriteLine("2 : Inserir uma nova temporada ");
                Console.WriteLine("3 : Editar uma temporada cadastrada ");
                Console.WriteLine("4 : Exluir uma temporada cadastrada ");
                Console.WriteLine("5 : Selecionar uma temporada especifica");
                Console.WriteLine("6 : Limpar tela");
                Console.WriteLine("X : Sair de temporada ");
                string valor = Console.ReadLine().ToUpper();

                if (valor == "X")
                {
                    return valor;
                }
                //verifico se o valor e numerico e se esta no intervalo determinado
                if (int.TryParse(valor, out int result) &&
                    int.Parse(valor) <= 6 && int.Parse(valor) >= 1)
                {
                    return valor;
                }
                Console.WriteLine("Por favor Digite um valor valido");
            }


        }

        public override void InserirEntidade()
        {
            Console.WriteLine("Informe o titulo da temporada");
            string titulo = Console.ReadLine();
            Console.WriteLine("Informe a descricao da temporada");
            string descricao = Console.ReadLine();
            Temporada temporada = new Temporada(titulo, descricao, 0);
            temporadaRepositorio.Inserir(temporada);
            Console.WriteLine($"{Environment.NewLine}");
            Console.WriteLine("Temporada inserida com sucesso!!!");
        }


        public override void ListarEntidade()
        {
            Console.WriteLine("SERIES CADASTRADAS:");
            temporadaRepositorio.Listar();
        }

        public override void SelecionarEntidade()
        {
            Console.WriteLine("Selecione o metodo de busca: ");
            while (true)
            {
                Console.WriteLine("Pesquisar por Id: 1 ");
                Console.WriteLine("Pesquisar por Titulo: 2 ");
                Console.WriteLine("Voltar: 3");
                string escolha = Console.ReadLine();

                //Verificando a entrada do usuario
                if (!int.TryParse(escolha, out int resultado)
                    | int.Parse(escolha) > 3
                    | int.Parse(escolha) < 1)
                {
                    Console.WriteLine("Por favor digite uma opcoes abaixo: ");
                    continue;
                }

                //Decidindo qual metodo de busca sera utilizado
                int escolhaInt = int.Parse(escolha);
                if (escolhaInt == 1)
                {
                    Console.WriteLine("Informe o Id da temporada: ");
                    int id = int.Parse(Console.ReadLine());
                    Temporada temporada = temporadaRepositorio.RetornarPorId(id);
                    if (temporada != null)
                    {
                        Console.WriteLine("Temporada:");
                        Console.WriteLine(temporada.toString());
                        break;
                    }
                }
                if (escolhaInt == 2)
                {
                    Console.WriteLine("Informe o titulo da temporada: ");
                    Temporada temporada = temporadaRepositorio.RetornarPorTitulo(Console.ReadLine());
                    if (temporada != null)
                    {
                        Console.WriteLine("Temporada:");
                        Console.WriteLine(temporada.toString());
                        break;
                    }
                }
                break;
            }

        }

        public override void AtualizarEntidade()
        {
            Console.WriteLine("Metodos de busca: ");
            Console.WriteLine($"{Environment.NewLine}");
            Temporada temporada = null;
            while (true)
            {
                Console.WriteLine("Selecionar temporada por Id: 1 ");
                Console.WriteLine("Selecionar temporada por Titulo: 2 ");
                Console.WriteLine("Voltar: 3");
                string escolha = Console.ReadLine();

                //Verificando a entrada do usuario
                if (!int.TryParse(escolha, out int resultado)
                    | int.Parse(escolha) > 3
                    | int.Parse(escolha) < 1)
                {
                    Console.WriteLine("Por favor digite uma opcoes abaixo: ");
                    continue;
                }

                //Decidindo qual metodo de busca sera utilizado
                int escolhaInt = int.Parse(escolha);
                if (escolhaInt == 1)
                {
                    Console.WriteLine("Digite o Id da Temporada: ");
                    int buscaId = int.Parse(Console.ReadLine());
                    temporada = temporadaRepositorio.RetornarPorId(buscaId);
                }
                if (escolhaInt == 2)
                {
                    Console.WriteLine("Digite o Titulo da Temporada: ");
                    string buscaTitulo = Console.ReadLine();
                    temporada = temporadaRepositorio.RetornarPorTitulo(buscaTitulo);
                }
                break;
            }

            if (temporada != null)
            {

                string titulo = temporada.Titulo;
                string descricao = temporada.Descricao;
                //MODIFICAR O TITULO
                while (true)
                {
                    Console.WriteLine("Deseja atualizar o titulo? Y/N: ");
                    string decisao = Console.ReadLine();
                    if (decisao.ToUpper() == "Y")
                    {
                        Console.WriteLine("Digite o novo titulo: ");
                        titulo = Console.ReadLine();
                        break;
                    }
                    if (decisao.ToUpper() == "N")
                    {
                        break;
                    }
                    Console.WriteLine("Por favor digite Y/N");
                }
                //MODIFICAR A DESCRICAO
                while (true)
                {
                    Console.WriteLine("Deseja atualizar a descricao? Y/N: ");
                    string decisao = Console.ReadLine();
                    if (decisao.ToUpper() == "Y")
                    {
                        Console.WriteLine("Digite a nova descricao: ");
                        descricao = Console.ReadLine();
                        break;
                    }
                    if (decisao.ToUpper() == "N")
                    {
                        break;
                    }
                    Console.WriteLine("Por favor digite Y/N");
                }

                temporadaRepositorio.Atualizar(temporada, titulo, descricao);
            }

        }

        public override void ExcluirEntidade()
        {
            Console.WriteLine("Metodos de busca: ");
            Console.WriteLine($"{Environment.NewLine}");
            Temporada temporada = null;
            while (true)
            {
                Console.WriteLine("Selecionar temporada por Id: 1 ");
                Console.WriteLine("Selecionar temporada por Titulo: 2 ");
                Console.WriteLine("Voltar: 3");
                string escolha = Console.ReadLine();

                //Verificando a entrada do usuario
                if (!int.TryParse(escolha, out int resultado)
                    | int.Parse(escolha) > 3
                    | int.Parse(escolha) < 1)
                {
                    Console.WriteLine("Por favor digite uma opcoes abaixo: ");
                    continue;
                }

                //Decidindo qual metodo de busca sera utilizado
                int escolhaInt = int.Parse(escolha);
                if (escolhaInt == 1)
                {
                    Console.WriteLine("Digite o Id da Temporada que sera excluida: ");
                    int buscaId = int.Parse(Console.ReadLine());
                    temporada = temporadaRepositorio.RetornarPorId(buscaId);
                    if (temporada != null)
                    {
                        temporadaRepositorio.Excluir(temporada);
                        Console.WriteLine("Temporada excluida!!");
                    }
                }
                if (escolhaInt == 2)
                {
                    Console.WriteLine("Digite o Titulo da Temporada que sera excluida: ");
                    string buscaTitulo = Console.ReadLine();
                    temporada = temporadaRepositorio.RetornarPorTitulo(buscaTitulo);
                    if (temporada != null)
                    {
                        temporadaRepositorio.Excluir(temporada);
                        Console.WriteLine("Temporada excluida!!");
                    }
                }
                break;
            }
        }


    }
}