using GameOfLife.Models;

namespace GameOfLife.Operations.CellOperations.Interfaces
{
    public interface ITomorrow
    {
        void Calculate(Cell cell);
        void TomorrowIsToday(Cell cell);
    }
}