using Cadastro_Series.Interfaces;
using Cadastro_Series.Factorys;
using System;
namespace Cadastro_Series
{
    public class Temporada : Entidade, ITemporada
    {
        public IController episodioController = ControllerFactory.CreateController(ControllerType.Episodio);
        static int autoIncrementId = 1;
        private int numeroEpisodios;
        public int NumeroEpisodios
        {
            get { return this.numeroEpisodios; }
            set { this.numeroEpisodios = value; }
        }

        public Temporada(string titulo, string descricao)
        {
            this.id = autoIncrementId;
            this.titulo = titulo;
            this.descricao = descricao;
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