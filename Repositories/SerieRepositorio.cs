using System.Collections.Generic;
using Cadastro_Series.Interfaces;

namespace Cadastro_Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {

        private List<Serie> listaSerie = new List<Serie>();
        public void Atualizar(string titulo, Serie entidade)
        {
            throw new System.NotImplementedException();
        }

        public void Excluir(string titulo)
        {
            throw new System.NotImplementedException();
        }

        public void Inserir(Serie entidade)
        {

        }

        public List<Serie> Listar()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            throw new System.NotImplementedException();
        }

        public Serie RetornarPorId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}