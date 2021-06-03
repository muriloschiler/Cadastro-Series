using System;
namespace Cadastro_Series
{
    public class EpisodioController : ControllerAbstract
    {
        private EpisodioRepositorio episodioRepositorio = new EpisodioRepositorio();
        public EpisodioController() { }
        public override void Run()
        {
            base.Run();
        }

        public override string OpcaoUsuario()
        {
            while (true)
            {
                Console.WriteLine("##############################");
                Console.WriteLine("MENU Episodios ");
                Console.WriteLine("1 : Listar Episodios cadastrados ");
                Console.WriteLine("2 : Inserir um novo Episodio ");
                Console.WriteLine("3 : Editar um Episodio cadastrado ");
                Console.WriteLine("4 : Exluir um Episodio cadastrado ");
                Console.WriteLine("5 : Selecionar um Episodio especifico");
                Console.WriteLine("6 : Limpar tela");
                Console.WriteLine("X : Sair de Episodios ");
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
            Console.WriteLine("Informe o titulo do Episodio");
            string titulo = Console.ReadLine();
            Console.WriteLine("Informe a descricao do Episodio");
            string descricao = Console.ReadLine();
            Episodio episodio = new Episodio(titulo, descricao);
            episodioRepositorio.Inserir(episodio);
            Console.WriteLine("Episodio inserido com sucesso!!!");
            Console.WriteLine($"{Environment.NewLine}");

        }

        public override void ListarEntidade()
        {
            Console.WriteLine("EPISODIOS CADASTRADOS:");
            episodioRepositorio.Listar();
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
                    Console.WriteLine("Informe o Id do episodio: ");
                    int id = int.Parse(Console.ReadLine());
                    Episodio episodio = episodioRepositorio.RetornarPorId(id);
                    if (episodio != null)
                    {
                        Console.WriteLine("Episodio:");
                        Console.WriteLine(episodio.toString());
                        break;
                    }
                }
                if (escolhaInt == 2)
                {
                    Console.WriteLine("Informe o titulo do episodio: ");
                    Episodio episodio = episodioRepositorio.RetornarPorTitulo(Console.ReadLine());
                    if (episodio != null)
                    {
                        Console.WriteLine("Serie:");
                        Console.WriteLine(episodio.toString());
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
            Episodio episodio = null;
            while (true)
            {
                Console.WriteLine("Selecionar episodio por Id: 1 ");
                Console.WriteLine("Selecionar episodio por Titulo: 2 ");
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
                    Console.WriteLine("Digite o Id do episodio: ");
                    int buscaId = int.Parse(Console.ReadLine());
                    episodio = episodioRepositorio.RetornarPorId(buscaId);
                }
                if (escolhaInt == 2)
                {
                    Console.WriteLine("Digite o Titulo do episodio: ");
                    string buscaTitulo = Console.ReadLine();
                    episodio = episodioRepositorio.RetornarPorTitulo(buscaTitulo);
                }
                break;
            }

            if (episodio != null)
            {

                string titulo = episodio.Titulo;
                string descricao = episodio.Descricao;
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
                episodioRepositorio.Atualizar(episodio, titulo, descricao);
            }

        }

        public override void ExcluirEntidade()
        {
            Console.WriteLine("Metodos de busca: ");
            Console.WriteLine($"{Environment.NewLine}");
            Episodio episodio = null;
            while (true)
            {
                Console.WriteLine("Selecionar episodio por Id: 1 ");
                Console.WriteLine("Selecionar episodio por Titulo: 2 ");
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
                    Console.WriteLine("Digite o Id do episodio que sera excluido: ");
                    int buscaId = int.Parse(Console.ReadLine());
                    episodio = episodioRepositorio.RetornarPorId(buscaId);
                    if (episodio != null)
                    {
                        episodioRepositorio.Excluir(episodio);
                        Console.WriteLine("Episodio excluido!!");
                    }
                }
                if (escolhaInt == 2)
                {
                    Console.WriteLine("Digite o Titulo do episodio que sera excluido: ");
                    string buscaTitulo = Console.ReadLine();
                    episodio = episodioRepositorio.RetornarPorTitulo(buscaTitulo);
                    if (episodio != null)
                    {
                        episodioRepositorio.Excluir(episodio);
                        Console.WriteLine("Episodio excluida!!");
                    }
                }
                break;
            }
        }


    }
}