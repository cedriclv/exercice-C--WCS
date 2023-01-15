using System;

public class Concat
{
    public static void Main(String[] args)
    {
        bool gameOnGoing = true;
        while (gameOnGoing)
        {
            Console.WriteLine("Entrez la premiere phrase :");
            String firtSentence = Console.ReadLine();

            Console.WriteLine("Entrez la deuxieme phrase :");
            String secondSentence = Console.ReadLine();

            Console.WriteLine("Et voici le resultat :");
            String fullSentence = firtSentence + " " + secondSentence;

            Console.WriteLine(fullSentence);

            Console.WriteLine("Taper Y pour rejouer ou une autre touche pour arreter !");
            String input = Console.ReadLine();
            if (!(input.Equals("Y")))
            {
                gameOnGoing = false;
            }
        }

    }
}