using System;
using System.Collections.Generic;
using Cadastro_Series.Interfaces;

namespace Cadastro_Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {

        private List<Serie> listaSerie = new List<Serie>();
        public void Atualizar(Serie serie, String titulo, string descricao, string ano, string genero)
        {
            serie.Atualizar(titulo, descricao, ano, genero);
        }

        public void Excluir(string titulo)
        {
            throw new System.NotImplementedException();
        }

        public void Inserir(Serie serie)
        {
            listaSerie.Add(serie);
        }

        public void Listar()
        {
            foreach (Serie serie in listaSerie)
            {
                Console.WriteLine(serie.toString());
            }
        }
        public Serie RetornarPorId(int id)
        {
            foreach (Serie serie in this.listaSerie)
            {
                if (serie.Id == id)
                {
                    return serie;
                }
            }
            Console.WriteLine("Id nao encontrado");
            return null;
        }
        public Serie RetornarPorTitulo(string titulo)
        {
            foreach (Serie serie in this.listaSerie)
            {
                if (serie.Titulo == titulo)
                {
                    return serie;
                }
            }
            Console.WriteLine("Titulo nao encontrado");
            return null;
        }
    }
}