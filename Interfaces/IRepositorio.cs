namespace Cadastro_Series.Interfaces
{
    public interface IRepositorio<T>
    {
        void Listar();
        T RetornarPorId(int id);
        T RetornarPorTitulo(string titulo);
        void Inserir(T entidade);
        void Excluir(T entidade);
    }
}