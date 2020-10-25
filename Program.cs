using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam2510
{
    class Program
    {
        static void Main(string[] args)
        {
            WordGame game = new WordGame();

            while (true)
            {
                game.Turn();
            }
        }
    }
}
