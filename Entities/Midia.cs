using System;
namespace Cadastro_Series
{
    public abstract class Midia
    {
        protected int id { get; set; }
        protected string titulo { get; set; }
        protected string descricao { get; set; }
        protected string genero { get; set; }

        public virtual string toString()
        {
            string texto = "";
            texto += $"Id:{this.id} {Environment.NewLine}";
            texto += $"Titulo:{this.titulo} {Environment.NewLine}";
            texto += $":{this.descricao} {Environment.NewLine}";
            return texto;
        }
    }
}