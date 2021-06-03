namespace Cadastro_Series.Interfaces
{
    public interface IEpisodioRepositorio : IRepositorio<Episodio>
    {
        void Inserir(Episodio episodio, Temporada temporada);
        void Atualizar(Episodio entidade, string titulo, string descricao, Temporada temporada);
    }
}