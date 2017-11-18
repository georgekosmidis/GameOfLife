using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Universe : List<Cell>
    {
        public bool IsReady { get; set; }
        private int _w;
        private int _h;
        public Universe(int w, int h)
        {
            _w = w;
            _h = h;
            Create();
        }

        public void Create()
        {
            for (var i = 0; i < _w; i++)
                for (var j = 0; j < _h; j++)
                    this.Add(new Cell() { X = i, Y = j, IsAlive = false });

            if (this.First().Neighbours.Count() == 0)
                Parallel.ForEach(this, cell =>
                {
                    cell.Neighbours.AddRange(
                        this.Where(o => cell.X.IsBetween(o.X - 1, o.X + 1) && cell.Y.IsBetween(o.Y - 1, o.Y + 1) && o != cell)
                    );
                });
        }

        public void Reset()
        {
            Parallel.ForEach(this, cell =>
            {
                cell.IsAlive = false;
                cell.IsAliveTomorrow = false;
            });
        }

        public void FillRandom()
        {
            var rnd = new Random();
            Parallel.ForEach(this, cell =>
            {
                cell.IsAlive = rnd.Next(0, 13) == 1;
            });
        }
        public Cell Find(int x, int y)
        {
            return this.Where(o => x == o.X && y == o.Y).First();
        }
    }
}
