using GameOfLife.Models;

namespace GameOfLife.Operations.UniverseOperations.Interfaces
{
    public interface IRestarter
    {
        void Reset(Universe universe);
    }
}