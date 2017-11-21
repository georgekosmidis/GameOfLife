using GameOfLife.Calculations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Factories
{
    public class GameFactory
    {
        public GameFactory()
        {

        }

        public Game Get()
        {
            return new Game(
                      new Operations.UniverseOperations.Creator(),
                      new Operations.UniverseOperations.Restarter(
                          new Operations.CellOperations.Restarter()
                      ),
                      new Operations.UniverseOperations.Locator(),
                      new Operations.UniverseOperations.Neighbourhoods(
                          new Operations.CellOperations.Neighbourhoods(),
                          new Operations.UniverseOperations.Locator()
                      ),
                      new Operations.UniverseOperations.Randomizer(
                          new Operations.CellOperations.Randomizer()
                      ),
                      new Operations.UniverseOperations.Tomorrow(
                          new Operations.CellOperations.Tomorrow()
                     )
                  );
        }
    }
}
