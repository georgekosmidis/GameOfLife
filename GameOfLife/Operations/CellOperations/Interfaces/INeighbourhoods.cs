using System.Collections.Generic;
using GameOfLife.Models;

namespace GameOfLife.Operations.CellOperations.Interfaces
{
    public interface INeighbourhoods
    {
        void Set(Cell cell, List<Cell> neighbours);
    }
}