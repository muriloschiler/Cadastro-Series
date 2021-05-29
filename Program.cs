using System;

namespace Cadastro_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Serie serie = new Serie(1, "TituloTeste", "DescricaoTeste", 2021, "Terro");
                Console.WriteLine(serie.toString());

                Console.WriteLine("Digite: ");
                if (Console.ReadLine() == "x")
                {
                    break;
                }
            }
        }
    }
}
