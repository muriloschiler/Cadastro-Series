using System;
using System.Collections.Generic;
namespace Cadastro_Series
{
    class Program
    {
        static SerieRepositorio serieRepositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            var opcaoUsuario = OpcaoUsuario();
            while (opcaoUsuario != "X")
            {
                switch (opcaoUsuario)
                {

                    case "1":
                        ListarSerie();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "6":
                        Console.Clear();
                        break;

                }
                opcaoUsuario = OpcaoUsuario();
            }
            Console.WriteLine("Sistema desligando ...");
        }


        private static string OpcaoUsuario()
        {
            while (true)
            {
                Console.WriteLine("##############################");
                Console.WriteLine("MENU ");
                Console.WriteLine("1 : Listar Series cadastradas ");
                Console.WriteLine("2 : Inserir uma nova Serie ");
                Console.WriteLine("3 : Editar uma Serie cadastrada ");
                Console.WriteLine("4 : Exluir uma Serie cadastrada ");
                Console.WriteLine("5 : Visualizar uma serie especifica");
                Console.WriteLine("6 : Limpar tela");
                Console.WriteLine("X : Sair do programa ");
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

        private static void InserirSerie()
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
            serieRepositorio.Inserir(serie);
            Console.WriteLine("Serie Inserida com sucesso!!!");

        }


        private static void ListarSerie()
        {
            Console.WriteLine("SERIES CADASTRADAS:");
            serieRepositorio.Listar();
        }

        private static void VisualizarSerie()
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
                    Console.WriteLine("Informe o Id da serie: ");
                    int id = int.Parse(Console.ReadLine());
                    Serie serie = serieRepositorio.RetornarPorId(id);
                    if (serie != null)
                    {
                        Console.WriteLine("Serie:");
                        Console.WriteLine(serie.toString());
                        break;
                    }
                }
                if (escolhaInt == 2)
                {
                    Console.WriteLine("Informe o titulo da serie: ");
                    Serie serie = serieRepositorio.RetornarPorTitulo(Console.ReadLine());
                    if (serie != null)
                    {
                        Console.WriteLine("Serie:");
                        Console.WriteLine(serie.toString());
                        break;
                    }
                }
                break;
            }
        }

        private static void AtualizarSerie()
        {

            Console.WriteLine("Metodos de busca: ");
            Console.WriteLine($"{Environment.NewLine}");
            Serie serie = null;
            while (true)
            {
                Console.WriteLine("Selecionar por Id: 1 ");
                Console.WriteLine("Selecionar por Titulo: 2 ");
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
                    Console.WriteLine("Digite o Id da Serie: ");
                    int buscaId = int.Parse(Console.ReadLine());
                    serie = serieRepositorio.RetornarPorId(buscaId);
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
                //MODIFICAR O ANO
                while (true)
                {
                    Console.WriteLine("Deseja atualizar o ano? Y/N: ");
                    string decisao = Console.ReadLine();
                    if (decisao.ToUpper() == "Y")
                    {
                        Console.WriteLine("Digite o novo ano: ");
                        descricao = Console.ReadLine();
                        break;
                    }
                    if (decisao.ToUpper() == "N")
                    {
                        break;
                    }
                    Console.WriteLine("Por favor digite Y/N");
                }
                //MODIFICAR O GENERO    
                string generoTemp = "";
                while (true)
                {
                    Console.WriteLine("Deseja atualizar o genero? Y/N: ");
                    string decisao = Console.ReadLine();
                    if (decisao.ToUpper() == "Y")
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
                    Console.WriteLine("Por favor digite Y/N");
                }
                serieRepositorio.Atualizar(serie, titulo, descricao, ano, genero);
            }
        }

        private static void ExcluirSerie()
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

    }
}

