using System;
namespace Cadastro_Series
{
    public abstract class Midia
    {
        protected int id { get; set; }
        public int Id
        {
            get { return this.id; }
        }
        protected string titulo { get; set; }
        public string Titulo
        {
            get { return this.titulo; }
        }
        protected string descricao { get; set; }
        public string Descricao
        {
            get { return this.descricao; }
        }
        protected string genero { get; set; }
        public string GENERO
        {
            get { return this.genero; }
        }
        protected string ano { get; set; }
        public string Ano
        {
            get { return this.ano; }
        }

        public virtual string toString()
        {
            string texto = "";
            texto += $"{Environment.NewLine}";
            texto += $"Id:{this.id} {Environment.NewLine}";
            texto += $"Titulo:{this.titulo} {Environment.NewLine}";
            texto += $"Descricao:{this.descricao} {Environment.NewLine}";
            texto += $"Ano:{this.ano} {Environment.NewLine}";
            texto += $"Genero:{this.genero} {Environment.NewLine}";
            texto += $"{Environment.NewLine}";
            return texto;
        }
    }
}