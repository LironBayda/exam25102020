using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam2510
{
    interface Game
    {
        void Initi();
        void Turn();
        void EndGame();
        bool IsWinning();
        
        
    }
}
