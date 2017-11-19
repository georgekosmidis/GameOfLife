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

        public static int RandomModular = 10;

        public static class Colors
        {
            public static Color GameForm = Color.Black;
            public static Color SetupForm = Color.Gray;

            public static Color AliveCell = Color.Black;
            public static Color DeadCell = Color.White;

            public static Color SetupAliveCell = Color.Black;
            public static Color SetupDeadCell = Color.White;
        }

    }
}
