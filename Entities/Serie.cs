using System;

namespace Cadastro_Series
{
    public class Serie : Midia
    {

        static int autoIncrementId = 1;
        private string genero { get; set; }
        public string GENERO
        {
            get { return this.genero; }
        }

        protected string ano { get; set; }
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
            texto += $"{Environment.NewLine}";
            return texto;
        }
    }
}