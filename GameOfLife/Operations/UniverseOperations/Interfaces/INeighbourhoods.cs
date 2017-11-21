using GameOfLife.Models;

namespace GameOfLife.Operations.UniverseOperations.Interfaces
{
    public interface INeighbourhoods
    {
        void FindSet(Universe universe);
    }
}