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

        public string RetornarGenero(string genero)
        {

            if (Genero.listaGenero.Contains(genero))
            {
                return genero;
            }
            return $"Genero nao identificado{Environment.NewLine}";
        }

        public string InserirGenero(string genero)
        {
            if (Genero.listaGenero.Contains(genero))
            {
                return $"Genero ja cadastrado{Environment.NewLine}";
            }

            Genero.listaGenero.Add(genero);
            return $"Genero adcionado com sucesso{Environment.NewLine}";

        }

        public string DeletarGenero(string genero)
        {
            if (Genero.listaGenero.Contains(genero))
            {
                Genero.listaGenero.Remove(genero);
                return $"Genero removido com sucesso{Environment.NewLine}";
            }

            Genero.listaGenero.Add(genero);
            return $"Genero adcionado com sucesso{Environment.NewLine}"; ;

        }

    }
}
