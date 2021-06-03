namespace Cadastro_Series.Interfaces
{
    public interface IEpisodio : IEntidade
    {
        void Atualizar(string titulo, string descricao, Temporada temporada);
    }
}