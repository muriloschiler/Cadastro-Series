using System;
namespace Cadastro_Series
{
    public class Episodio : Etidade
    {
        static int autoIncrementId = 1;

        public Episodio(string titulo, string descricao)
        {
            this.id = autoIncrementId;
            this.titulo = titulo;
            this.descricao = descricao;
            ++autoIncrementId;
        }

        public void Atualizar(string titulo, string descricao)
        {
            this.titulo = titulo;
            this.descricao = descricao;
        }

        public override string toString()
        {
            base.toString();
            string texto = "";
            return texto;
        }

    }
}