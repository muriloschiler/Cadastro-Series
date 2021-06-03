namespace Cadastro_Series.Interfaces
{
    public interface IRepositorio<T>
    {
        void Listar();
        T RetornarPorId(int id);
        T RetornarPorTitulo(string titulo);
        void Excluir(T entidade);
    }
}