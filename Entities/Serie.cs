using System;

namespace Cadastro_Series
{
    public class Serie : Midia
    {
        static int autoIncrementId = 1;
        public Serie(string titulo, string descricao, int ano, string genero)
        {
            if (Genero.ContemGenero(genero))
            {
                this.genero = genero;
            }
            this.id = autoIncrementId;
            this.titulo = titulo;
            this.descricao = descricao;
            this.ano = ano;

            ++autoIncrementId;
        }
    }
}