using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        int[] integers = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
        int sum = 0;
        int count = 0;
        double average = 0;
        Console.WriteLine("Quelle est la valeur maximale de la liste à prendre en compte pour la moyenne ?");
        int limit = Convert.ToInt32(Console.ReadLine());
        IEnumerable<int> querySelected = integers.Where(figure => figure < limit);
        foreach (int figure in querySelected)
        {
            sum = sum + figure;
            count++;
            if (count > 0)
            {
                average = sum / count;
            }
        }

        Console.WriteLine("La moyenne est de {0} ",average);
    }
}