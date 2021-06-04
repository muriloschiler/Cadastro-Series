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
                        this.ListarEntidade();
                        break;
                    case "2":
                        this.InserirEntidade();
                        break;
                    case "3":
                        this.AtualizarEntidade();
                        break;
                    case "4":
                        this.ExcluirEntidade();
                        break;
                    case "5":
                        this.SelecionarEntidade();
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
        public virtual void InserirEntidade()
        {
            throw new NotImplementedException();
        }
        public virtual void ListarEntidade()
        {
            throw new NotImplementedException();
        }
        public virtual void SelecionarEntidade()
        {
            throw new NotImplementedException();
        }
        public virtual void AtualizarEntidade()
        {
            throw new NotImplementedException();
        }
        public virtual void ExcluirEntidade()
        {
            throw new NotImplementedException();
        }

        public virtual int RetornarTamanho()
        {
            throw new NotImplementedException();
        }
    }
}