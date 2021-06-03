namespace Cadastro_Series.Interfaces
{
    public interface ISerie : IEntidade
    {
        void Atualizar(string titulo, string descricao, string ano, string genero);
    }
}