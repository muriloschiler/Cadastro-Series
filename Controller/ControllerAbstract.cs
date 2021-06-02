using System;
using Cadastro_Series.Interfaces;
namespace Cadastro_Series
{
    public class ControllerAbstract : IController
    {
        public virtual void Run()
        {
            var opcaoUsuario = this.OpcaoUsuario();
            while (opcaoUsuario != "X")
            {
                switch (opcaoUsuario)
                {

                    case "1":
                        this.ListarSerie();
                        break;
                    case "2":
                        this.InserirSerie();
                        break;
                    case "3":
                        this.AtualizarSerie();
                        break;
                    case "4":
                        this.ExcluirSerie();
                        break;
                    case "5":
                        this.VisualizarSerie();
                        break;
                    case "6":
                        Console.Clear();
                        break;

                }
                opcaoUsuario = this.OpcaoUsuario();
            }
        }
        public virtual string OpcaoUsuario()
        {
            throw new NotImplementedException();
        }
        public virtual void InserirSerie()
        {
            throw new NotImplementedException();
        }
        public virtual void ListarSerie()
        {
            throw new NotImplementedException();
        }
        public virtual void VisualizarSerie()
        {
            throw new NotImplementedException();
        }
        public virtual void AtualizarSerie()
        {
            throw new NotImplementedException();
        }
        public virtual void ExcluirSerie()
        {
            throw new NotImplementedException();
        }
    }
}