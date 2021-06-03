using System;
using Cadastro_Series.Factorys;
using Cadastro_Series.Interfaces;

namespace Cadastro_Series
{
    public class Serie : Entidade, ISerie
    {
        public IController temporadaController = ControllerFactory.CreateController(ControllerType.Temporada);
        static int autoIncrementId = 1;
        public static int numeroTemporadas = 0;
        private string genero { get; set; }
        public string GENERO
        {
            get { return this.genero; }
        }

        private string ano { get; set; }
        public string Ano
        {
            get { return this.ano; }
        }
        public Serie(string titulo, string descricao, string ano, string genero)
        {
            this.id = autoIncrementId;
            this.titulo = titulo;
            this.descricao = descricao;
            this.ano = ano;
            this.genero = Genero.RetornarGenero(genero);

            ++autoIncrementId;
        }

        public void Atualizar(string titulo, string descricao, string ano, string genero)
        {
            this.titulo = titulo;
            this.descricao = descricao;
            this.ano = ano;
            this.genero = genero;
        }

        public override string toString()
        {
            base.toString();
            string texto = "";
            texto += $"Genero:{this.genero} {Environment.NewLine}";
            texto += $"Ano:{this.Ano} {Environment.NewLine}";
            texto += $"Temporadas:{Serie.numeroTemporadas} {Environment.NewLine}";
            texto += $"{Environment.NewLine}";
            return texto;
        }
    }
}