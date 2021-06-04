using System;
namespace Cadastro_Series
{
    public class SerieController : ControllerAbstract
    {

        private SerieRepositorio serieRepositorio = new SerieRepositorio();

        public SerieController() { }

        public override void Run()
        {
            base.Run();
        }
        public override string OpcaoUsuario()
        {
            while (true)
            {
                Console.WriteLine("MENU Series ");
                Console.WriteLine("1 : Listar Series cadastradas ");
                Console.WriteLine("2 : Inserir uma nova Serie ");
                Console.WriteLine("3 : Editar uma Serie cadastrada ");
                Console.WriteLine("4 : Exluir uma Serie cadastrada ");
                Console.WriteLine("5 : Selecionar uma serie especifica");
                Console.WriteLine("6 : Limpar tela");
                Console.WriteLine("X : Sair de Series ");
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
            Console.WriteLine("Informe o titulo da Serie");
            string titulo = Console.ReadLine();
            Console.WriteLine("Informe a descricao da Serie");
            string descricao = Console.ReadLine();
            Console.WriteLine("Informe o ano de lancamento da Serie");
            string ano = Console.ReadLine();
            string genero = "";
            while (true)
            {
                Genero.ListarGenero();
                genero = Console.ReadLine();
                if (Genero.ContemGenero(genero))
                {
                    break;
                }
            }
            Serie serie = new Serie(titulo, descricao, ano, genero);
            Console.WriteLine("Agora defina as informacoes da primeria temporada:");
            //Definindo a primeria temporada
            serie.temporadaController.InserirEntidade();
            serieRepositorio.Inserir(serie);
            Console.WriteLine("Serie inserida com sucesso!!!");
            Console.WriteLine($"{Environment.NewLine}");
        }

        public override void ListarEntidade()
        {
            Console.WriteLine("SERIES CADASTRADAS:");
            serieRepositorio.Listar();
        }
        public override void SelecionarEntidade()
        {
            Console.WriteLine("Selecione o metodo de busca: ");
            string escolha = "";
            while (true)

            {
                Console.WriteLine("Pesquisar por Id: 1 ");
                Console.WriteLine("Pesquisar por Titulo: 2 ");
                Console.WriteLine("Voltar: 3");
                escolha = Console.ReadLine();

                //Verificando a entrada do usuario
                if (!int.TryParse(escolha, out int resultado))
                {
                    Console.WriteLine("Por favor digite uma opcoes abaixo: ");
                    continue;
                }
                if (int.Parse(escolha) > 3
                    | int.Parse(escolha) < 1)
                {
                    Console.WriteLine("Por favor digite uma opcoes abaixo: ");
                    continue;
                }
                break;
            }
            //Decidindo qual metodo de busca sera utilizado
            int escolhaInt = int.Parse(escolha);
            if (escolhaInt == 1)
            {
                Serie serie = null;
                while (true)
                {
                    Console.WriteLine("Informe o Id da serie: ");
                    if (!int.TryParse(Console.ReadLine(), out int id))
                    {
                        Console.WriteLine("Por favor digite um id valido");
                        continue;
                    }
                    serie = serieRepositorio.RetornarPorId(id);
                    break;
                }

                if (serie != null)
                {
                    Console.Clear();
                    Console.WriteLine("Serie:");
                    Console.WriteLine(serie.toString());
                    Console.WriteLine("Deseja acessar suas temporadas ?");
                    Console.WriteLine("S/N");
                    if (Console.ReadLine().ToUpper() == "S")
                    {
                        serie.temporadaController.Run();
                    }
                }


            }
            if (escolhaInt == 2)
            {
                Console.WriteLine("Informe o titulo da serie: ");
                Serie serie = serieRepositorio.RetornarPorTitulo(Console.ReadLine());
                if (serie != null)
                {
                    Console.Clear();
                    Console.WriteLine("Serie:");
                    Console.WriteLine(serie.toString());
                    Console.WriteLine("Deseja acessar suas temporadas ?");
                    Console.WriteLine("S/N");
                    if (Console.ReadLine().ToUpper() == "S")
                    {
                        serie.temporadaController.Run();
                    }
                }
            }
        }

        public override void AtualizarEntidade()
        {
            Console.WriteLine("Metodos de busca: ");
            Console.WriteLine($"{Environment.NewLine}");
            Serie serie = null;
            while (true)
            {
                Console.WriteLine("Selecionar serie por Id: 1 ");
                Console.WriteLine("Selecionar serie por Titulo: 2 ");
                Console.WriteLine("Voltar: 3");
                string escolha = Console.ReadLine();

                //Verificando a entrada do usuario
                if (!int.TryParse(escolha, out int resultado))
                {
                    Console.WriteLine("Por favor digite uma opcoes abaixo: ");
                    continue;
                }
                if (int.Parse(escolha) > 3
                    | int.Parse(escolha) < 1)
                {
                    Console.WriteLine("Por favor digite uma opcoes abaixo: ");
                    continue;
                }

                //Decidindo qual metodo de busca sera utilizado
                Console.Clear();
                int escolhaInt = int.Parse(escolha);
                if (escolhaInt == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("Digite o Id da Serie: ");
                        if (!int.TryParse(Console.ReadLine(), out int id))
                        {
                            Console.WriteLine("Por favor digite um id valido");
                            continue;
                        }
                        serie = serieRepositorio.RetornarPorId(id);
                        break;
                    }
                }
                if (escolhaInt == 2)
                {
                    Console.WriteLine("Digite o Titulo da Serie: ");
                    string buscaTitulo = Console.ReadLine();
                    serie = serieRepositorio.RetornarPorTitulo(buscaTitulo);
                }

                break;
            }

            if (serie != null)
            {

                string titulo = serie.Titulo;
                string descricao = serie.Descricao;
                string ano = serie.Ano;
                string genero = serie.GENERO;
                //MODIFICAR O TITULO
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Deseja atualizar o titulo?: ");
                    Console.WriteLine("S/N");
                    string decisao = Console.ReadLine();
                    if (decisao.ToUpper() == "S")
                    {
                        Console.WriteLine("Digite o novo titulo: ");
                        titulo = Console.ReadLine();
                        break;
                    }
                    if (decisao.ToUpper() == "N")
                    {
                        break;
                    }
                    Console.WriteLine("Por favor digite S/N");
                }
                //MODIFICAR A DESCRICAO
                while (true)
                {
                    Console.WriteLine("Deseja atualizar a descricao?: ");
                    Console.WriteLine("S/N");
                    string decisao = Console.ReadLine();
                    if (decisao.ToUpper() == "S")
                    {
                        Console.WriteLine("Digite a nova descricao: ");
                        descricao = Console.ReadLine();
                        break;
                    }
                    if (decisao.ToUpper() == "N")
                    {
                        break;
                    }
                    Console.WriteLine("Por favor digite S/N");
                }
                //MODIFICAR O ANO
                while (true)
                {
                    Console.WriteLine("Deseja atualizar o ano?: ");
                    Console.WriteLine("S/N");
                    string decisao = Console.ReadLine();
                    if (decisao.ToUpper() == "S")
                    {
                        Console.WriteLine("Digite o novo ano: ");
                        descricao = Console.ReadLine();
                        break;
                    }
                    if (decisao.ToUpper() == "N")
                    {
                        break;
                    }
                    Console.WriteLine("Por favor digite S/N");
                }
                //MODIFICAR O GENERO    
                string generoTemp = "";
                while (true)
                {
                    Console.WriteLine("Deseja atualizar o genero?: ");
                    Console.WriteLine("S/N");
                    string decisao = Console.ReadLine();
                    if (decisao.ToUpper() == "S")
                    {
                        Genero.ListarGenero();
                        generoTemp = Console.ReadLine();
                        if (!Genero.ContemGenero(generoTemp))
                        {
                            continue;
                        }
                        genero = generoTemp;
                        break;
                    }
                    if (decisao.ToUpper() == "N")
                    {
                        break;
                    }
                    Console.WriteLine("Por favor digite S/N");
                }
                Console.Clear();
                Console.WriteLine("Serie atualizada com sucesso!");
                serieRepositorio.Atualizar(serie, titulo, descricao, ano, genero);
            }

        }

        public override void ExcluirEntidade()
        {
            Console.WriteLine("Metodos de busca: ");
            Console.WriteLine($"{Environment.NewLine}");
            Serie serie = null;
            while (true)
            {
                Console.WriteLine("Selecionar Serie por Id: 1 ");
                Console.WriteLine("Selecionar Serie por Titulo: 2 ");
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
                    Console.WriteLine("Digite o Id da Serie que sera excluida: ");
                    int buscaId = int.Parse(Console.ReadLine());
                    serie = serieRepositorio.RetornarPorId(buscaId);
                    if (serie != null)
                    {
                        serieRepositorio.Excluir(serie);
                        Console.WriteLine("Serie excluida!!");
                    }
                }
                if (escolhaInt == 2)
                {
                    Console.WriteLine("Digite o Titulo da Serie que sera excluida: ");
                    string buscaTitulo = Console.ReadLine();
                    serie = serieRepositorio.RetornarPorTitulo(buscaTitulo);
                    if (serie != null)
                    {
                        serieRepositorio.Excluir(serie);
                        Console.WriteLine("Serie excluida!!");
                    }
                }
                break;
            }
        }

        public override int RetornarTamanho()
        {
            return this.serieRepositorio.RetornarTamanho();
        }
    }

}