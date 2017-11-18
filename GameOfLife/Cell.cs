using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }

        public bool IsAlive { get; set; }
        public bool IsAliveTomorrow { get; set; }


        public List<Cell> Neighbours { get; set; } = new List<Cell>();
        //{
        //    get
        //    {
        //        if (_neighbours == null)
        //            _neighbours = Parent.Where(o => this.X.IsBetween(o.X - 1, o.X + 1) && this.Y.IsBetween(o.Y - 1, o.Y + 1) && o != this).ToList();
        //        return _neighbours;
        //    }
        //}

        public void SetTomorrow()
        {

            var i = this.Neighbours.Where(o => o.IsAlive).Count();
            if (i < 2)
            {
                IsAliveTomorrow = false;
                return;
            }
            if (i >= 4)
            {
                IsAliveTomorrow = false;
                return;
            }
            if (!IsAlive && i == 3)
            {
                IsAliveTomorrow = true;
                return;
            }
            if (IsAlive && (i == 3 || i == 2))
            {
                IsAliveTomorrow = true;
                return;
            }
        }

        public void TomorrowIsToday()
        {
            IsAlive = IsAliveTomorrow;
        }
    }
}
