namespace Cadastro_Series.Interfaces
{
    public interface ISerieRepositorio : IRepositorio<Serie>
    {
        void Atualizar(Serie entidade, string titulo, string descricao, string ano, string genero);
    }
}