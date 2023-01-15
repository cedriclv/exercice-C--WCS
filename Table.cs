using System;

public class Table
{

    public static void Main(String[] args)
    {
        int[] firstArray = { 1, 2, 3, 4 };
        int[] secondArray = { 5, 6, 7, 8, 9 };

        int[] thirdArray = new int[9];

        for (int i = 0; i < firstArray.Length; i++)
        {
            thirdArray[i] = firstArray[i];

        }
        for (int i = (firstArray.Length); i < thirdArray.Length; i++)
        {
            thirdArray[i] = secondArray[i - ((firstArray.Length))];
        }
        for (int i = 0; i < thirdArray.Length; i++)
        {
            Console.WriteLine(thirdArray[i]);
        }
    }
}