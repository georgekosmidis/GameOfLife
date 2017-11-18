using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public static class Consts
    {
        //form

        public static int FPS = 24;//frames per second

        public static int CellSize = 7;
        public static class Colors
        {
            public static SolidBrush AliveCell = new SolidBrush(Color.Black);
            public static SolidBrush DeadCell = new SolidBrush(Color.White);

            public static Color Form = Color.White;
            public static SolidBrush SetupAliveCell = new SolidBrush(Color.Black);
            public static Pen SetupDeadCell = new Pen(Color.Black);
        }

    }
}
