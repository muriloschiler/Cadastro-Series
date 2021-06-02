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