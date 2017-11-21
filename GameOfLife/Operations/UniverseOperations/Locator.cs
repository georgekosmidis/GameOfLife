using GameOfLife.Models;
using GameOfLife.Operations.UniverseOperations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Operations.UniverseOperations
{
    public class Locator : ILocator
    {
        public Locator()
        {

        }

        public Cell Find(Universe universe, int x, int y)
        {
            return universe.Where(o => x == o.X && y == o.Y).First();
        }

        public List<Cell> FindRange(Universe universe, int x, int y)
        {
            return universe.Where(o => x.IsBetween(o.X - 1, o.X + 1) && y.IsBetween(o.Y - 1, o.Y + 1)).ToList();
        }
    }
}
