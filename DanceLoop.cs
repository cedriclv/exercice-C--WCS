using System;

public class DanceLoop
{
    public static void Main(string[] args)
    {

        String[] moves = { "one", "two", "three" };
        Console.WriteLine("Combien de tour de pas ?");
        int steps = int.Parse(Console.ReadLine());
        for (int i = 0; i < steps; i++)
        {
            Console.WriteLine("Tour " + i);
            foreach (String move in moves)
            {
                Console.WriteLine(move);
            }

        }
    }
}