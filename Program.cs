using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new ABCplayer();
            Player p2 = new HumanPlayer();
            Player p3 = new BruteForcePlayer();
            Player p4 = new SmartyPlayer();
            Player p5 = new RandomPlayer();

            HangmanGame hg1 = new HangmanGame(p1);
            HangmanGame hg2 = new HangmanGame(p2);
            HangmanGame hg3 = new HangmanGame(p3);
            HangmanGame hg4 = new HangmanGame(p4);
            HangmanGame hg5 = new HangmanGame(p5);

        }
    }
}
