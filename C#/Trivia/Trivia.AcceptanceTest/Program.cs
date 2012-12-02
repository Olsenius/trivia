using System;
using System.IO;
using UglyTrivia;

namespace Trivia.AcceptanceTest
{
    class Program
    {
        private static readonly Helper _helper = new Helper();
        static void Main()
        {
            var console = Console.Out;
            FileStream ostrm;
            StreamWriter writer;
            try
            {
                ostrm = new FileStream("./game.txt", FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot open game.txt for writing");
                Console.WriteLine(e.Message);
                return;
            }
            Console.SetOut(writer);

            for (int i = 0; i < 100; i++)
            {
                PlayFakeGame();
            }
            writer.Close();
            ostrm.Close();

            Console.SetOut(console);
            Console.WriteLine("Wrote output of 100 games to game.txt");
            if (File.Exists("./expected.txt"))
            {
                var expected = File.ReadAllText("expected.txt");
                var actual = File.ReadAllText("game.txt");

                Console.WriteLine();
                Console.WriteLine("Diff with expected.txt: " + (actual == expected ? "OK!" : "Failure!!!"));
            }
            else
            {
                Console.WriteLine("expected.txt missing. Rename game.txt to expected.txt and try again");
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
