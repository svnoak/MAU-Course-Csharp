using System;

class Program
{
    static void Main(string[] args)
    {
        DoStatement obj = new DoStatement();
        obj.Start();

        Console.WriteLine("Press Enter to exit.");
        Console.ReadLine();

    }
}

public class DoStatement {

    private double number;
    private double squareRoot;
    private string userInput;

    public void Start()
    {
        do
        {
            ReadNumber();
            SquareRootOf();
        } while (ContinueProgram());
    }

    private void ReadNumber()
    {
        Console.WriteLine("Please writa a valid number");
        string strNumber = Console.ReadLine();
        number = double.Parse(strNumber);
    }
    private void SquareRootOf()
    {
        if (number < 0)
        {
            Console.WriteLine("Negative numbers do not have a real square root!");
        }
        else
        {
            squareRoot = Math.Sqrt(number);
            Console.WriteLine("The square root of " + number + " is " + squareRoot.ToString("0.00"));
        }
    }

    private bool ContinueProgram()
    {
        Console.WriteLine("Do you want to continue?");
        userInput = Console.ReadLine();
        userInput = userInput.ToLower();

        switch (userInput)
        {
            case "y":
                   return true;

            case "n":
                return false;

            default:
                Console.WriteLine("Please use Y/N or y/n!");
                return ContinueProgram();
        }
    }
}