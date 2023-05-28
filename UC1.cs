using System;

public class SnakeAndLadderGame
{
    private int position;

    public SnakeAndLadderGame()
    {
        position = 0;
    }

    public void PlayGame()
    {
        Random random = new Random();

        while (position < 100)
        {
            int diceRoll = random.Next(1, 7);
            Console.WriteLine("Current Position: " + position);
            Console.WriteLine("Dice Roll: " + diceRoll);

            position += diceRoll;
            if (position > 100)
            {
                position -= diceRoll;
            }
            switch (position)
            {
                case 12:
                    position = 28;
                    Console.WriteLine("Climbed a ladder! Moved to position 28.");
                    break;
                case 25:
                    position = 35;
                    Console.WriteLine("Climbed a ladder! Moved to position 35.");
                    break;
                case 40:
                    position = 5;
                    Console.WriteLine("Oops! Got bitten by a snake. Moved back to position 5.");
                    break;
                case 56:
                    position = 72;
                    Console.WriteLine("Climbed a ladder! Moved to position 72.");
                    break;
                case 78:
                    position = 99;
                    Console.WriteLine("Climbed a ladder! Moved to position 99.");
                    break;
                case 90:
                    position = 48;
                    Console.WriteLine("Oops! Got bitten by a snake. Moved back to position 48.");
                    break;
            }

            Console.WriteLine();
        }

        Console.WriteLine("Congratulations! You reached position 100 and won the game!");
    }
}

public class Program
{
    public static void Main()
    {
        SnakeAndLadderGame game = new SnakeAndLadderGame();
        game.PlayGame();
    }
}
