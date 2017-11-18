using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public static class Extensions
    {
        public static bool IsBetween(this int i, int f, int t)
        {
            return f <= i && t >= i;
        }
    }
}
