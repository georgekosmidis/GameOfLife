using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfLife.Models;
using GameOfLife.Operations.CellOperations.Interfaces;

namespace GameOfLife.Operations.CellOperations
{
    public class Randomizer : IRandomizer
    {
        private Random random;
        private static readonly object _lock = new object();

        public Randomizer()
        {
            random = new Random();
        }

        public void FillWithAlive(Cell cell)
        {
            lock (_lock)
            {
                cell.IsAlive = random.Next(0, Consts.RandomModular) == 1;
            }
        }
    }
}
