using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Models
{
    public class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }

        public bool IsAlive { get; set; }
        public bool IsAliveTomorrow { get; set; }

        public List<Cell> Neighbours { get; set; } = new List<Cell>();
    }
}
