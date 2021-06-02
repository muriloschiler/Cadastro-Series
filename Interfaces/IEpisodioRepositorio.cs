namespace Cadastro_Series.Interfaces
{
    public interface IEpisodioRepositorio : IRepositorio<Episodio>
    {
        void Atualizar(Episodio entidade, string titulo, string descricao);
    }
}