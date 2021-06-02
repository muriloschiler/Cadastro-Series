using System;
using Cadastro_Series.Factorys;
namespace Cadastro_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var serieController = ControllerFactory.CreateController(ControllerType.Serie);

                Console.WriteLine("Seja bem vindo a plataforma de Series e Filmes");
                while (true)
                {
                    Console.WriteLine("Selecione o modo de navegacao:");
                    Console.WriteLine("Series: 1");
                    Console.WriteLine("Filmes: 2");
                    Console.WriteLine("Sair: x");
                    string escolha = Console.ReadLine();
                    if (escolha.ToUpper() == "X")
                        break;
                    if (int.TryParse(escolha, out int resultado) &&
                        int.Parse(escolha) <= 2 &&
                        int.Parse(escolha) >= 1)
                    {
                        if (resultado == 1)
                            serieController.Run();
                        continue;
                    }
                    Console.WriteLine("Por Favor selecione dentre as opcoes disponiveis ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}