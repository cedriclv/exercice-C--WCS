
    // Récupère dans une variable une entrée utilisateur en indiquant que tu demandes un nombre;
    // Récupère dans une autre variable une entrée utilisateur en indiquant que tu demandes un nombre ;
    // Demande à l’utilisateur une chaîne de caractères qui fera office de message de succès ;
    // Additionne les deux nombres récupérés ;
    // Affiche l’opération à l’écran ([valeur variable 1] + [valeur variable 2] = [résultat addition]).
    //  Remplace ce qu’il y a entre les crochets par les valeurs concernées ;
    // Affiche le message de succès entré précédemment par l’utilisateur.


using System;

public class Calculator
{
    public static void Main(string[] args){
        Console.WriteLine("Enter a first number :");
        int numberOne = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter a first number :");
        int numberTwo = Convert.ToInt32(Console.ReadLine());

        int numberTotal = numberOne + numberTwo;
        Console.WriteLine("Below the operation and the result :");
        Console.WriteLine("[" +Convert.ToString(numberOne) + "]  +  [" + Convert.ToString(numberTwo) + "] + = " + Convert.ToString(numberTotal));

    } 
}