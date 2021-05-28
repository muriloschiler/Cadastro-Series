using System;

namespace Cadastro_Series
{
    public class Serie : Midia
    {

        public Serie(int id, string titulo, string descricao)
        {
            this.id = id;
            this.titulo = titulo;
            this.descricao = descricao;
        }
    }
}