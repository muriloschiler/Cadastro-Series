using Cadastro_Series.Interfaces;
using System;
namespace Cadastro_Series
{
    public class Temporada : Entidade, ITemporada
    {
        static int autoIncrementId = 1;
        private int numeroEpisodios;
        public int NumeroEpisodios
        {
            get { return this.numeroEpisodios; }
            set { this.numeroEpisodios = value; }
        }

        public Temporada(string titulo, string descricao, int numeroEpisodios)
        {
            this.id = autoIncrementId;
            this.titulo = titulo;
            this.descricao = descricao;
            this.numeroEpisodios = numeroEpisodios;
            ++Serie.numeroTemporadas;
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
            texto += $"Numero de episodios:{this.numeroEpisodios}";
            texto += $"{Environment.NewLine}";
            return texto;
        }
    }
}