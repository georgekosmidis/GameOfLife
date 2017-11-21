using GameOfLife.Models;
using GameOfLife.Operations.UniverseOperations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Operations.UniverseOperations
{
    public class Randomizer : IRandomizer
    {
        private CellOperations.Randomizer _randomizer;

        public Randomizer(CellOperations.Randomizer randomizer)
        {
            _randomizer = randomizer;
        }
        public void FillWithAlive(Universe universe)
        {
            Parallel.ForEach(universe, cell =>
            {
                _randomizer.FillWithAlive(cell);
            });
        }
    }
}
