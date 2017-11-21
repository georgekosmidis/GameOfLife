using GameOfLife.Models;

namespace GameOfLife.Operations.CellOperations.Interfaces
{
    public interface IRandomizer
    {
        void FillWithAlive(Cell cell);
    }
}