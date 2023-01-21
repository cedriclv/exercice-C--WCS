using System;

public class Program
{
    public static void Main(string[] args)
    {
        string appOnGoing = "Y";
        while (appOnGoing == "Y")
        {
            Console.WriteLine("Do you want to make a calculation ? Y/N");
            string userOnGoingChoice = Console.ReadLine();
            if (userOnGoingChoice == "Y")
            {
                double result = 0;

                Console.WriteLine("Enter a first number :");
                double numberOne = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter a second number :");
                double numberTwo = Convert.ToDouble(Console.ReadLine());

                int operationId = -1;
                while (operationId < 1 || operationId > 5)
                {
                    operationId = AskOperator();
                    result = CallOperator(operationId, numberOne, numberTwo);
                }

                Console.WriteLine("The result is : " + result);
            }
            else
            {
                appOnGoing = "N";
                Console.WriteLine("The game is over");
            }
        }
    }

    public static int AskOperator()
    {
        Console.WriteLine("Enter the chosen operation :");
        Console.WriteLine("1: Addition");
        Console.WriteLine("2: Substraction");
        Console.WriteLine("3: Multplication");
        Console.WriteLine("4: Division");
        Console.WriteLine("5: Modulo");
        int operationId = Convert.ToInt32(Console.ReadLine());
        return operationId;
    }

    public static double CallOperator(int operationId, double numberOne, double numberTwo)
    {
        double result = 0;

        switch (operationId)
        {
            case 1:
                result = Add(numberOne, numberTwo);
                break;
            case 2:
                result = Substract(numberOne, numberTwo);
                break;
            case 3:
                result = Multiply(numberOne, numberTwo);
                break;
            case 4:
                result = Divide(numberOne, numberTwo);
                break;
            case 5:
                result = Modulo(numberOne, numberTwo);
                break;
            default:
                Console.WriteLine("Wrong input");
                break;
        }
        return result;
    }

    public static double Add(double firstFigure, double secondFigure)
    {
        return firstFigure + secondFigure;
    }
    public static double Substract(double firstFigure, double secondFigure)
    {
        return firstFigure - secondFigure;
    }
    public static double Multiply(double firstFigure, double secondFigure)
    {
        return firstFigure * secondFigure;
    }
    public static double Divide(double firstFigure, double secondFigure)
    {
        return firstFigure / secondFigure;
    }
    public static double Modulo(double firstFigure, double secondFigure)
    {
        return firstFigure % secondFigure;
    }
}