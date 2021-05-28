using System;

namespace Cadastro_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            Serie serie = new Serie(1, "TituloTeste", "DescricaoTeste");
            Console.WriteLine(serie.toString());
        }
    }
}
