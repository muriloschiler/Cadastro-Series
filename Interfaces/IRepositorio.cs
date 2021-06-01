using System.Collections.Generic;
namespace Cadastro_Series.Interfaces
{
    public interface IRepositorio<T>
    {
        void Listar();
        T RetornarPorId(int id);
        T RetornarPorTitulo(string titulo);
        void Inserir(T entidade);
        void Excluir(T entidade);
        void Atualizar(T entidade, string titulo, string descricao, string ano, string genero);
    }
}