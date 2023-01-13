using System;

class Borne
{
    public Borne()
    {

    }
}

class Program
{
    public static void Main(String[] args)
    {

        int limitLow = 12;
        int limitHigh = 18;
        bool gameOnGoing = true;

        while (gameOnGoing)
        {
            Console.WriteLine("Enter a value between" + limitLow + " and " + limitHigh);
            String userInput = Console.ReadLine();
            int figureInput = int.Parse(userInput);
            if (figureInput > limitHigh)
            {
                Console.WriteLine("Too high, the max is " + limitHigh);
            }
            else if (figureInput < limitLow)
            {
                Console.WriteLine("Too low, the min is " + limitLow);
            }
            else
            {
                Console.WriteLine("Well done, your guess is right");
                gameOnGoing = false;
            }

        }

    }
}