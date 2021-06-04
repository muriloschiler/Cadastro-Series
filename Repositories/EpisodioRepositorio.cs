using System;
using System.Collections.Generic;
using Cadastro_Series.Interfaces;
namespace Cadastro_Series
{
    class EpisodioRepositorio : IEpisodioRepositorio
    {
        private List<Episodio> listaEpisodio = new List<Episodio>();
        public void Atualizar(Episodio episodio, string titulo, string descricao)
        {
            episodio.Atualizar(titulo, descricao);
        }

        public void Excluir(Episodio episodio)
        {
            listaEpisodio.Remove(episodio);
        }

        public void Inserir(Episodio episodio)
        {
            listaEpisodio.Add(episodio);
        }

        public void Listar()
        {
            foreach (Episodio episodio in listaEpisodio)
            {
                Console.WriteLine(episodio.toString());
            }
        }

        public Episodio RetornarPorId(int id)
        {
            foreach (Episodio episodio in this.listaEpisodio)
            {
                if (episodio.Id == id)
                {
                    return episodio;
                }
            }
            Console.WriteLine("Id nao encontrado");
            return null;
        }

        public Episodio RetornarPorTitulo(string titulo)
        {
            foreach (Episodio episodio in this.listaEpisodio)
            {
                if (episodio.Titulo == titulo)
                {
                    return episodio;
                }
            }
            Console.WriteLine("Titulo nao encontrado");
            return null;
        }


        public int RetornarTamanho()
        {
            return this.listaEpisodio.Count;
        }
    }

}