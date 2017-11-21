using GameOfLife.Models;

namespace GameOfLife.Operations.CellOperations.Interfaces
{
    public interface IRestarter
    {
        void Reset(Cell cell);
    }
}