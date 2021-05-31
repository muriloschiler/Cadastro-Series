using System.Collections.Generic;
namespace Cadastro_Series.Interfaces
{
    public interface IRepositorio<T>
    {
        void Listar();
        T RetornarPorId(int id);
        void Inserir(T entidade);
        void Excluir(string titulo);
        void Atualizar(string titulo, T entidade);
        int ProximoId();

    }
}