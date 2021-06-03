using System;
using Cadastro_Series.Interfaces;
namespace Cadastro_Series
{
    public class Episodio : Entidade, IEpisodio
    {
        static int autoIncrementId = 1;
        private Temporada temporada;
        public Episodio(string titulo, string descricao, Temporada temporada)
        {
            this.id = autoIncrementId;
            this.titulo = titulo;
            this.descricao = descricao;
            this.temporada = temporada;
            ++autoIncrementId;
        }

        public void Atualizar(string titulo, string descricao, Temporada temporada)
        {
            this.titulo = titulo;
            this.descricao = descricao;
            this.temporada = temporada;
        }

        public override string toString()
        {
            base.toString();
            string texto = "";
            texto += $"{this.temporada}";
            texto += $"{Environment.NewLine}";
            return texto;
        }

    }
}