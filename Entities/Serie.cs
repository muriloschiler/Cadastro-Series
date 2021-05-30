using System;

namespace Cadastro_Series
{
    public class Serie : Midia
    {

        public Serie(int id, string titulo, string descricao, int ano, string genero)
        {
            if (Genero.ContemGenero(genero))
            {
                this.genero = genero;
            }
            this.id = id;
            this.titulo = titulo;
            this.descricao = descricao;
            this.ano = ano;
        }
    }
}