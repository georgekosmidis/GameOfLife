using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfLife.Models;
using GameOfLife.Operations.UniverseOperations.Interfaces;

namespace GameOfLife.Operations.UniverseOperations
{
    public class Creator : ICreator
    {
        public Creator()
        {

        }

        public Universe Create(int w, int h)
        {
            var universe = new Universe();
            universe.Width = w;
            universe.Height = h;
            for (var i = 0; i < w; i++)
                for (var j = 0; j < h; j++)
                    universe.Add(new Cell() { X = i, Y = j, IsAlive = false, IsAliveTomorrow = false });
            return universe;
        }
    }
}
