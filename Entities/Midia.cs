using System;
namespace Cadastro_Series
{
    public abstract class Midia
    {
        protected int id { get; set; }
        protected string titulo { get; set; }
        protected string descricao;
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        protected string genero { get; set; }
        protected int ano { get; set; }

        public virtual string toString()
        {
            string texto = "";
            texto += $"Id:{this.id} {Environment.NewLine}";
            texto += $"Titulo:{this.titulo} {Environment.NewLine}";
            texto += $"Descricao:{this.descricao} {Environment.NewLine}";
            texto += $"Ano:{this.ano} {Environment.NewLine}";
            texto += $"Genero:{this.genero} {Environment.NewLine}";
            return texto;
        }
    }
}