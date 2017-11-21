using GameOfLife.Models;
using GameOfLife.Operations.UniverseOperations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Operations.UniverseOperations
{
    public class Tomorrow : ITomorrow
    {
        private CellOperations.Tomorrow _tomorrow;

        public Tomorrow(CellOperations.Tomorrow tomorrow)
        {
            _tomorrow = tomorrow;
        }

        public void Calculate(Universe universe)
        {
            Parallel.ForEach(universe, cell =>
            {
                _tomorrow.Calculate(cell);
            });
        }

        public void TomorrowIsToday(Universe universe)
        {
            Parallel.ForEach(universe, cell =>
            {
                _tomorrow.TomorrowIsToday(cell);
            });
        }
    }
}
