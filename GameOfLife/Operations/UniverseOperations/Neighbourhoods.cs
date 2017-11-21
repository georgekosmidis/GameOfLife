using GameOfLife.Models;
using GameOfLife.Operations.UniverseOperations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Operations.UniverseOperations
{
    public class Neighbourhoods : INeighbourhoods
    {
        private CellOperations.Neighbourhoods _neighbourhoods;
        private UniverseOperations.Locator _locator;

        public Neighbourhoods(CellOperations.Neighbourhoods neighbourhoods, UniverseOperations.Locator locator)
        {
            _neighbourhoods = neighbourhoods;
            _locator = locator;
        }

        public void FindSet(Universe universe)
        {
            Parallel.ForEach(universe, cell =>
            {
                var neighbours = _locator.FindRange(universe, cell.X, cell.Y).Where(o => o != cell).ToList();
                _neighbourhoods.Set(cell, neighbours);
            });
        }
    }
}
