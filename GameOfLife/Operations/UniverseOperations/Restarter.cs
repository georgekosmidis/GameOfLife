using GameOfLife.Models;
using GameOfLife.Operations.UniverseOperations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Operations.UniverseOperations
{
    public class Restarter : IRestarter
    {
        private CellOperations.Restarter _restarter;

        public Restarter(CellOperations.Restarter restarter)
        {
            _restarter = restarter;
        }


        public void Reset(Universe universe)
        {
            Parallel.ForEach(universe, cell =>
            {
                _restarter.Reset(cell);
            });

        }
    }
}
