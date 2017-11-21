using System.Collections.Generic;
using GameOfLife.Models;

namespace GameOfLife.Operations.UniverseOperations.Interfaces
{
    public interface ILocator
    {
        Cell Find(Universe universe, int x, int y);
        List<Cell> FindRange(Universe universe, int x, int y);
    }
}