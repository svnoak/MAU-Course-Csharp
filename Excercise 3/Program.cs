using System;

class Program
{
    static void Main(string[] args)
    {
        Calculation calculation = new Calculation();
        calculation.Start();
    }
}

class Calculation
{
    public void Start()
    {
        int iterations;
        PrintInstructions();
        int userInput = ReadUserInput();
        int result = CalculateSumSquareOfNum(userInput, out iterations);
        DisplayResult(iterations, result, userInput);
    }

    private void PrintInstructions()
    {
        Console.WriteLine("Give a whole positive number (ex 500) to return the number of iterations that it takes for the sum of the squares, 1*1 + 2*2 + 3*3 ...");
        Console.WriteLine("to equal or exceed that number: ");
    }
    private int ReadUserInput()
    {
        string strInput = Console.ReadLine();
        int input = int.Parse(strInput);
        return input;
    }
    private int CalculateSumSquareOfNum(int userInput, out int iterations)
    {
        int result = 0;
        int i = 0;

        while(result < userInput) {
            result = result + (i * i);
            i++;
        }
        iterations = i;
        return result;
    }

    private void DisplayResult(int iterations, int result, int userInput)
    {
        Console.WriteLine("It took " + iterations + " iterations for the sum get to or exceeds " + userInput + "(sum = " + result + ")");
    }

}