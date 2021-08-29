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
            Score tm1 = new Score(2, 3);
            Score tm2 = new Score(4, 2);

            Score finalScores = tm1 + tm2;


            Console.WriteLine("Round 1: " + finalScores.Round1Score);
            Console.WriteLine("Round 2: " + finalScores.Round2Score);
        }
    }
    class Score
    {
        public int Round1Score { get; set; }
        public int Round2Score { get; set; }
        public Score(int r1, int r2)
        {
            Round1Score = r1;
            Round2Score = r2;
        }

        public static Score operator + (Score player1, Score player2)
        {
            int r1TeamPoints = player1.Round1Score + player2.Round1Score;
            int r2TeamPoints = player1.Round2Score + player2.Round2Score;
            Score res = new Score(r1TeamPoints, r2TeamPoints);
            return res;
        }
    }
}
        /*You and your friend are playing a game as one team. Each player must pass 2 rounds and gets points for each round passed.
        The program you are given creates two Score objects where each round scores are stored (they are passed to a constructor).
        Overload the + operator for the Score class to calculate the team score for every round.*/