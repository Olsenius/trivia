using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UglyTrivia;

namespace Trivia
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            game.add("Player 1");
            game.add("Player 2");
            game.add("Player 3");
            bool notAWinner;
            Random rand = new Random(1);

            do
            {

                game.roll(rand.Next(5) + 1);

                if (rand.Next(9) == 7)
                {
                    notAWinner = game.wrongAnswer();
                }
                else
                {
                    notAWinner = game.wasCorrectlyAnswered();
                }



            } while (notAWinner);
            Console.Read();
        }
    }
}
