using System;
using Cadastro_Series.Interfaces;

namespace Cadastro_Series.Factorys
{
    public class ControllerFactory
    {
        public static IController CreateController(ControllerType controllerType)
        {
            switch (controllerType)
            {
                case ControllerType.Serie:
                    return new SerieController();
                case ControllerType.Temporada:
                    return new TemporadaController();
                case ControllerType.Episodio:
                    return new EpisodioController();
                default:
                    throw new ArgumentOutOfRangeException();
            }

        }

    }
}