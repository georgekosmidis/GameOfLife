using GameOfLife.Models;
using GameOfLife.Operations.CellOperations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Operations.CellOperations
{
    public class Tomorrow : ITomorrow
    {
        public Tomorrow()
        {

        }
        public void TomorrowIsToday(Cell cell)
        {
            cell.IsAlive = cell.IsAliveTomorrow;
        }

        public void Calculate(Cell cell)
        {
            var i = cell.Neighbours.Where(o => o.IsAlive).Count();
            if (cell.IsAlive)
            {
                if (i < 2)
                {
                    cell.IsAliveTomorrow = false;
                    return;
                }
                if (i >= 4)
                {
                    cell.IsAliveTomorrow = false;
                    return;
                }
                if (i == 2 || i == 3)
                {
                    cell.IsAliveTomorrow = true;
                    return;
                }
            }
            else
            {
                if (i == 3)
                {
                    cell.IsAliveTomorrow = true;
                    return;
                }
            }
        }
    }
}
