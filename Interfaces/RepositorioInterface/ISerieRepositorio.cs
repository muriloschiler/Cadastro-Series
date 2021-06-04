namespace Cadastro_Series.Interfaces
{
    public interface ISerieRepositorio : IRepositorio<Serie>
    {
        void Inserir(Serie entidade);
        void Atualizar(Serie entidade, string titulo, string descricao, string ano, string genero);
        int RetornarTamanho();

    }
}