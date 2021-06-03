namespace Cadastro_Series.Interfaces
{
    public interface ITemporadaRepositorio : IRepositorio<Temporada>
    {
        void Inserir(Temporada temporada);
        void Atualizar(Temporada temporada, string titulo, string descricao);
    }
}