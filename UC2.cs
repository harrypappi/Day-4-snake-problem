using System;

public class Die
{
    private Random random;

    public Die()
    {
        random = new Random();
    }

    public int Roll()
    {
        return random.Next(1, 7);
    }
}

public class Player
{
    public void RollDie()
    {
        Die die = new Die();
        int rollResult = die.Roll();

        Console.WriteLine("The player rolled: " + rollResult);
    }
}

public class Program
{
    public static void Main()
    {
        Player player = new Player();
        player.RollDie();
    }
}
