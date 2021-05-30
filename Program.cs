using System;
using System.Collections.Generic;
namespace Cadastro_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Serie> listaSerie = new List<Serie>();

            var opcaoUsuario = OpcaoUsuario();
            while (opcaoUsuario != "X")
            {
                switch (opcaoUsuario)
                {

                    case "1":
                        //ListarSerie()
                        break;
                    case "2":
                        //InserirSerie()
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
                Console.WriteLine("Selecione uma opcao: ");
                Console.WriteLine("1 : Listar Series cadastradas ");
                Console.WriteLine("2 : Inserir uma nova Serie ");
                Console.WriteLine("3 : Editar uma Serie cadastrada ");
                Console.WriteLine("4 : Exluir uma Serie cadastrada ");
                Console.WriteLine("5 : Retornar uma Serie pelo seu ID ");
                Console.WriteLine("6 : Retornar o proximo ID válido ");
                Console.WriteLine("X : Retornar o proximo ID válido ");
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


    }
}
