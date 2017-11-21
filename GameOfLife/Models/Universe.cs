using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Models
{
    public class Universe : List<Cell>
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
