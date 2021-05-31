using System;

namespace Cadastro_Series
{
    public class Serie : Midia
    {
        static int autoIncrementId = 1;
        public Serie(string titulo, string descricao, string ano, string genero)
        {
            this.id = autoIncrementId;
            this.titulo = titulo;
            this.descricao = descricao;
            this.ano = ano;
            this.genero = Genero.RetornarGenero(genero);

            ++autoIncrementId;
        }
    }
}