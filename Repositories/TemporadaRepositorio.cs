using System;
using System.Collections.Generic;
using Cadastro_Series.Interfaces;
namespace Cadastro_Series
{
    class TemporadaRepositorio : ITemporadaRepositorio
    {
        private List<Temporada> listaTemporada = new List<Temporada>();

        public void Atualizar(Temporada temporada, string titulo, string descricao)
        {
            temporada.Atualizar(titulo, descricao);
        }

        public void Excluir(Temporada temporada)
        {
            listaTemporada.Remove(temporada);
        }

        public void Inserir(Temporada temporada)
        {
            listaTemporada.Add(temporada);
        }

        public void Listar()
        {
            foreach (Temporada temporada in listaTemporada)
            {
                Console.WriteLine(temporada.toString());
            }
        }

        public Temporada RetornarPorId(int id)
        {
            foreach (Temporada temporada in this.listaTemporada)
            {
                if (temporada.Id == id)
                {
                    return temporada;
                }
            }
            Console.WriteLine("Id nao encontrado");
            return null;
        }


        public Temporada RetornarPorTitulo(string titulo)
        {
            foreach (Temporada temporada in this.listaTemporada)
            {
                if (temporada.Titulo == titulo)
                {
                    return temporada;
                }
            }
            Console.WriteLine("Titulo nao encontrado");
            return null;
        }
    }
}