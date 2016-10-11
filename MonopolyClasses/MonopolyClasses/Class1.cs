using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MonopolyClasses
{
    class Player { }
    class GameCell { }

    class Game
    {
        public Player Player { get; set; }
        public GameCell[] GameCells { get; }
        private Timer waitPlayerConnectionTimer;
        private Timer waitPlayerMoveTimer;
        //public int GameIteration { get; set; } // ???
    }
}
