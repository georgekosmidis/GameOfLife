using GameOfLife.Models;

namespace GameOfLife.Operations.UniverseOperations.Interfaces
{
    public interface IRandomizer
    {
        void FillWithAlive(Universe universe);
    }
}