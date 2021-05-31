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
                        //EditarSerie()
                        break;
                    case "4":
                        //ExcluirSerie()
                        break;
                    case "5":
                        //RetornarSerieById()
                        break;
                    case "6":
                        //ProximoId()
                        break;
                    case "X":
                        //InserirSerie()
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
                Console.WriteLine("5 : Retornar uma Serie pelo seu ID ");
                Console.WriteLine("6 : Retornar o proximo ID válido ");
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
            try
            {
                Console.WriteLine("Informe o titulo da Serie");
                string titulo = Console.ReadLine();
                Console.WriteLine("Informe a descricao da Serie");
                string descricao = Console.ReadLine();
                Console.WriteLine("Informe o ano de lancamento da Serie");
                string ano = Console.ReadLine();
                Genero.ListarGenero();
                string genero = Console.ReadLine();
                Genero.ContemGenero(genero);

                Serie serie = new Serie(titulo, descricao, ano, genero);
                serieRepositorio.Inserir(serie);
                Console.WriteLine("Serie Inserida com sucesso!!!");

            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"{e.Message}");
            }


        }

        private static void ListarSerie()
        {
            serieRepositorio.Listar();
        }

    }
}
