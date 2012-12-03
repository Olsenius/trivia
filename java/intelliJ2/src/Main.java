import com.adaptionsoft.games.uglytrivia.Game;

import java.io.*;

public class Main {

    private static Helper _helper = new Helper();
    public static void main(String[] args) {

        PrintStream out = System.out;

        try
        {
            File file  = new File("game.txt");
            PrintStream printStream = new PrintStream(new FileOutputStream(file));
            System.setOut(printStream);
        }
        catch (Exception e)
        {
            System.out.println("Cannot open game.txt for writing");
            return;
        }

        for (int i = 0; i < 100; i++)
        {
            PlayFakeGame();
        }

        System.setOut(out);

        System.out.println("Wrote output of 100 games to game.txt");
        File expectedFile = new File("expected.txt");
        if (expectedFile.exists())
        {
            String expected = readFile("expected.txt");
            String actual = readFile("game.txt");

            System.out.println();
            System.out.println("Diff with expected.txt: " + (actual.equals(expected) ? "OK!" : "Failure!!!"));
        }
        else
        {
            System.out.println("expected.txt missing. Rename game.txt to expected.txt and try again");
        }

    }

    private static String readFile(String fileName){
        BufferedReader br = null;
        try {
            br = new BufferedReader(new FileReader(fileName));
        } catch (FileNotFoundException e) {
            throw new RuntimeException(e); //I hate your checked exceptions Java
        }
        try {
            StringBuilder sb = new StringBuilder();
            String line = br.readLine();

            while (line != null) {
                sb.append(line);
                sb.append("\n");
                line = br.readLine();
            }
            return sb.toString();
        }
        catch (Exception e){
            throw new RuntimeException(e); //I hate your checked exceptions Java
        }
        finally {
            try{
                br.close();
            }
            catch (Exception e){
                throw new RuntimeException(e); //I hate your checked exceptions Java
            }
        }
    }

    private static void PlayFakeGame()
    {
        Game game = new Game();
        game.add("Andreas");
        game.add("Kjersti");
        game.add("Kim");

        boolean gameIsRunning = true;

        while (gameIsRunning)
        {
            game.roll(_helper.throwDice());

            if (_helper.answer())
                gameIsRunning = game.wasCorrectlyAnswered();
            else
                gameIsRunning = game.wrongAnswer();
        }
        System.out.println("-------------------");
    }
}
