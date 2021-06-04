namespace Cadastro_Series.Interfaces
{
    public interface IEpisodioRepositorio : IRepositorio<Episodio>
    {
        void Inserir(Episodio episodio);
        void Atualizar(Episodio entidade, string titulo, string descricao);
        int RetornarTamanho();
    }
}