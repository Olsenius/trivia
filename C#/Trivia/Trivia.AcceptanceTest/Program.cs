using System;
using UglyTrivia;

namespace Trivia.AcceptanceTest
{
    class Program
    {
        private static readonly Helper _helper = new Helper();
        static void Main()
        {
            for (int i = 0; i < 50; i++)
            {
                PlayFakeGame();
            }
        }

        private static void PlayFakeGame()
        {

            var game = new Game();
            game.add("Andreas");
            game.add("Kjersti");
            game.add("Kim");

            bool gameIsrunning = true;

            while (gameIsrunning)
            {
                game.roll(_helper.Throw());

                if (_helper.Answer())
                    gameIsrunning = game.wasCorrectlyAnswered();
                else
                    gameIsrunning = game.wrongAnswer();
            }
            Console.WriteLine("-------------------");
        }
    }
}
