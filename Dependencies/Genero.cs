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

        public static string RetornarGenero(string genero)
        {

            if (Genero.listaGenero.Contains(genero))
            {
                return genero;
            }
            return $"Genero nao identificado{Environment.NewLine}";
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
        public static bool ContemGenero(string genero)
        {
            if (Genero.listaGenero.Contains(genero))
            {
                return true;
            }
            throw new ArgumentException($"O Genero:{genero} nao contem na lista disponivel");
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

    }
}
