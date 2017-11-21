using GameOfLife.Models;
using GameOfLife.Operations.CellOperations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Operations.CellOperations
{
    public class Neighbourhoods : INeighbourhoods
    {
        public Neighbourhoods()
        {

        }
        public void Set(Cell cell, List<Cell> neighbours)
        {
            cell.Neighbours.AddRange(neighbours);
        }
    }
}
