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

        public static int CellSize = 9;

        public static int RandomModular = 10;

        public static class Colors
        {
            public static Color GameForm = Color.FromArgb(236, 240, 241);
            public static Color SetupForm = Color.FromArgb(170, 170, 170);

            public static Color AliveCell = Color.FromArgb(41, 128, 185);
            public static Color DeadCell = Color.White;

            public static Color SetupAliveCell = Color.FromArgb(46, 204, 113);
            public static Color SetupDeadCell = Color.White;
        }

    }
}
