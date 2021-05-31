using System.Collections.Generic;
using System;

namespace Cadastro_Series
{
    public class Genero
    {
        static private List<string> listaGenero = new List<string>(){
            "Terror",
            "Aventura",
            "Romance",
            "Acao",
            "Comedia"
        };

        public static void ListarGenero()
        {
            int i = 0;
            Console.Write($"Selecione dentre os generos disponiveis:{Environment.NewLine}");
            while (i < listaGenero.Count)
            {

                Console.Write($"{i} {listaGenero[i]} {Environment.NewLine}");
                i++;

            }
        }
        public static string InserirGenero(string genero)
        {
            if (Genero.listaGenero.Contains(genero))
            {
                return $"Genero ja cadastrado{Environment.NewLine}";
            }

            Genero.listaGenero.Add(genero);
            return $"Genero adcionado com sucesso{Environment.NewLine}";

        }
        public static bool ContemGenero(string indice)
        {
            if (int.TryParse(indice, out int resultado))
            {
                if (resultado >= 0
                    && resultado < listaGenero.Count)
                {
                    return true;
                }
                throw new ArgumentException($"O Indice:{resultado} nao contem na lista disponivel");
            }
            throw new ArgumentException($"Escreva um indice valido");
        }

        public static string DeletarGenero(string genero)
        {
            if (Genero.listaGenero.Contains(genero))
            {
                Genero.listaGenero.Remove(genero);
                return $"Genero removido com sucesso{Environment.NewLine}";
            }

            return $"O genero{genero} nao esta presente na lista disponivel";
        }

        public static string RetornarGenero(string genero)
        {

            return Genero.listaGenero[int.Parse(genero)];
        }
    }
}
