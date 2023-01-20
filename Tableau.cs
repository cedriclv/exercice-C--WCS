using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Déclare un tableau uniforme de dimension 3x3.
        int[,] uniformArray = new int[3, 3] { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } };
        int tata = uniformArray[1, 1];
        String titi = tata.ToString();
        // Déclare ensuite un tableau irrégulier de dimension 3xn.
        int[][] jaggedArray = new int[3][];
        //Tu vas devoir utiliser ton tableau uniforme pour remplir le tableau irrég

        //Ecriture dans le tableau multidimensionnel
        for (int i = 0; i < 3; i++)
        {
            jaggedArray[i] = new int[uniformArray.GetLength(0) - i];
            int indexJaggedArray = 0;
            for (int j = i; j < 3; j++)
            {
                jaggedArray[i][indexJaggedArray] = uniformArray[i, j];
                indexJaggedArray++;
            }
        }

        //Lecture dans le tableau multidimensionnel
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("///");
            int indexJaggedArray = 0;
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.WriteLine(jaggedArray[i][j]);
                indexJaggedArray++;
            }
        }
    }
}
