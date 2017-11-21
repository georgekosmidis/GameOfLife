using GameOfLife.Models;
using GameOfLife.Operations.CellOperations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Operations.CellOperations
{
    public class Restarter : IRestarter
    {
        public Restarter()
        {

        }

        public void Reset(Cell cell)
        {
            cell.IsAlive = false;
            cell.IsAliveTomorrow = false;
        }
    }
}
