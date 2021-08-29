using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            int games = Convert.ToInt32(Console.ReadLine());
            int wins = Convert.ToInt32(Console.ReadLine());

            //creating the player object
            Player player1 = new Player();
            player1.games = games;
            player1.wins = wins;

            //output
            player1.GetWinRate();
        }
    }

    class Player
    {
        public int games;
        public int wins;
        //winrate is private
        private int winrate;

        //complete the method
        public void GetWinRate()
        {
            winrate = wins * 100 / games;
            Console.WriteLine(winrate);
        }
    }
}
    /*We are developing a profile system for player of our online game.
    The program takes the number of games and wins as input and creates a player object.
    Complete the GetWinRate() method inside the given Player class to calculate and output the win rate.

    Sample Input
    130
    70

    Sample Output
    53*/
