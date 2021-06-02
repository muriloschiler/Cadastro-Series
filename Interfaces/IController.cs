namespace Cadastro_Series.Interfaces
{
    public interface IController
    {
        void Run();
        string OpcaoUsuario();
        void InserirSerie();

        void ListarSerie();
        void VisualizarSerie();
        void AtualizarSerie();
        void ExcluirSerie();
    }
}