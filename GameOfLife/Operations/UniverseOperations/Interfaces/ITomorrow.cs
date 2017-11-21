using GameOfLife.Models;

namespace GameOfLife.Operations.UniverseOperations.Interfaces
{
    public interface ITomorrow
    {
        void Calculate(Universe universe);
        void TomorrowIsToday(Universe universe);
    }
}