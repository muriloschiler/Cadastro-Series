using System;
using Cadastro_Series.Interfaces;
namespace Cadastro_Series
{
    public abstract class Entidade : IEntidade
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



        public virtual string toString()
        {
            string texto = "";
            texto += $"{Environment.NewLine}";
            texto += $"Id:{this.Id} {Environment.NewLine}";
            texto += $"Titulo:{this.Titulo} {Environment.NewLine}";
            texto += $"Descricao:{this.Descricao} {Environment.NewLine}";
            Console.Write(texto);
            return null;
        }
    }
}