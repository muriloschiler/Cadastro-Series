using System;
using Cadastro_Series.Interfaces;
using Cadastro_Series.Factorys;
namespace Cadastro_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IController serieController = ControllerFactory.CreateController(ControllerType.Serie);
                Console.WriteLine($"{Environment.NewLine}");
                Console.WriteLine("Seja bem vindo a plataforma de Series");
                serieController.Run();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}