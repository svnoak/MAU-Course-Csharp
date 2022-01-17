using System;

class Program
{
    static void Main(string[] args)
    {
        ConsoleInput consoleInput = new ConsoleInput();
        string type = "integer";
        bool isType = consoleInput.IsType(type);
        if( isType)
        {
            Console.WriteLine("Input is of type " + type);
        }
    }
}

public class ConsoleInput
{
    public bool IsType(string type)
    {
        bool isType = true;
        do
        {
            string userInput = GetInput();

            switch (type)
            {
                case "boolean":
                    isType = IsBoolean(userInput);
                    break;
                case "integer":
                    isType = IsInteger(userInput);
                    break;
                case "double":
                    isType = IsDouble(userInput);
                    break;
                case "float":
                    isType = IsFloat(userInput);
                    break;
            }

            if( !isType) { 
                Console.WriteLine("Input must be of type " + type + ". Try again.");
            }

        } while (!isType);
        return isType;
    }

    private string GetInput()
    {
        return Console.ReadLine();
    }
    private bool IsInteger(string input)
    {
        int result;
        bool success =  int.TryParse(input, out result);
        return success;
    }
    private bool IsBoolean(string input)
    {
        bool result;
        bool success = bool.TryParse(input, out result);
        return success;
    }
    private bool IsDouble(string input)
    {
        double result;
        bool success = double.TryParse(input, out result);
        return success;
    }
    private bool IsFloat(string input)
    {
        float result;
        bool success = float.TryParse(input, out result);
        return success;
    }
}