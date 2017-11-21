using GameOfLife.Models;

namespace GameOfLife.Operations.UniverseOperations.Interfaces
{
    public interface ICreator
    {
        Universe Create(int w, int h);
    }
}