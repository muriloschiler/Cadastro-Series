namespace Cadastro_Series.Interfaces
{
    public interface IController
    {
        void Run();
        string OpcaoUsuario();
        void InserirEntidade();

        void ListarEntidade();
        void VisualizarEntidade();
        void AtualizarEntidade();
        void ExcluirEntidade();
    }
}