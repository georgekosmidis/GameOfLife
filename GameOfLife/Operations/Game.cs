using GameOfLife.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Calculations
{
    public class Game
    {
        private Universe universe;
        public Universe Universe
        {
            get
            {
                if (universe == null)
                    throw new InvalidCastException("Universe has not been created yet!");
                return universe;
            }
        }

        private Operations.UniverseOperations.Creator _creator;
        private Operations.UniverseOperations.Locator _locator;
        private Operations.UniverseOperations.Neighbourhoods _neighbourhoods;
        private Operations.UniverseOperations.Randomizer _randomizer;
        private Operations.UniverseOperations.Restarter _restarter;
        private Operations.UniverseOperations.Tomorrow _tomorrow;

        public Game(Operations.UniverseOperations.Creator creator,
                    Operations.UniverseOperations.Restarter restarter,
                    Operations.UniverseOperations.Locator locator,
                    Operations.UniverseOperations.Neighbourhoods neighbourhoods,
                    Operations.UniverseOperations.Randomizer randomizer,
                    Operations.UniverseOperations.Tomorrow tomorrow)
        {
            _creator = creator;
            _restarter = restarter;
            _locator = locator;
            _neighbourhoods = neighbourhoods;
            _randomizer = randomizer;
            _tomorrow = tomorrow;
        }

        public void CreateUniverse(int w, int h)
        {
            universe = _creator.Create(w, h);
            _neighbourhoods.FindSet(universe);

        }
        public Cell LocateCell(int x, int y)
        {
           return _locator.Find(universe, x, y);
        }

        public void SetRandomAlive()
        {
            _randomizer.FillWithAlive(universe);
        }

        public void ResetUniverse()
        {
            _restarter.Reset(universe);
        }
        public void CalculateTomorrow()
        {
            _tomorrow.Calculate(universe);
            _tomorrow.TomorrowIsToday(universe);
        }
    }
}
