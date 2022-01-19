namespace AssignmentA2
{
    using System;
    class SelectionAndIteration
    {
        public SelectionAndIteration()
        {

            // Initialize rest of methods.
            ShowIntroduction();

            ShowStringLength();

            MakeMyDay();
            Console.WriteLine();

            SumNumbers();
        }
        private void ShowIntroduction()
        {
            // Write introduction to screen.
            Console.WriteLine();
            Console.WriteLine("My name is Kim and I am a student of the VT22 semester!");
            Console.WriteLine();
        }
        private void ShowStringLength()
        {

            // Variables are partly used as condition.
            // Grouped for better overview.
            string input;
            int length;

            // Loop as long input is given.
            do
            {

                // Introduction text to user.
                Console.WriteLine();
                Console.WriteLine("Let me calculate the length of strings for you!");
                Console.WriteLine("Give me a text of any length, or press Enter to exit!");
                
                // Assign variables for output and condition check.
                input = Console.ReadLine().ToUpper();
                length = input.Length;

                // Give output if input was given.
                if( length > 0 ){ 
                    Console.WriteLine();
                    Console.WriteLine(input);
                    Console.WriteLine("Has " + length + " characters.");
                }
            } while (length > 0);
        }

        private void MakeMyDay()
        {
            // Introduction text
            Console.WriteLine("I can predict your day for you. Give me a number between 1 and 7:");

            // Parse input to integer for use in switch statement
            string stringInput = Console.ReadLine();
            int number = int.Parse(stringInput);

            // Show choosen number case.
            switch(number)
            {
                case 1:
                    Console.WriteLine("Monday: Keep calm! You can fall apart!");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("Tuesday and Wednesday break your heart!");
                    break;
                case 4:
                    Console.WriteLine("Thursday, Uuush, still one day to Friday!");
                    break;
                case 5:
                    Console.WriteLine("It's Friday! You are in love!");
                    break;
                case 6:
                    Console.WriteLine("Saturday, do nothing and do plenty of it!");
                    break;
                case 7:
                    Console.WriteLine("And Sunday always comes too soon!");
                    break;
                default:
                    Console.WriteLine("Not in a good mode? This is not a valid date!");
                    break;
            }
        }
        private void SumNumbers()
        {
            Console.WriteLine("Give a start number:");
            string stringStartNumberInput = Console.ReadLine();

            Console.WriteLine("Give an end number:");
            string stringEndNumberInput = Console.ReadLine();

            // Parsing numbers from strings from input

            int startNumberInput = int.Parse(stringStartNumberInput);
            int endNumberInput = int.Parse(stringEndNumberInput);

            // Declaring variables for better grouping and overview.
            int startNumber;
            int endNumber;

            // Check statement for switching numbers if necessary.
            // Smallest number must always be first.
            if (startNumberInput > endNumberInput)
            {
                endNumber = startNumberInput;
                startNumber = endNumberInput;
            }
            else
            {
                startNumber = startNumberInput;
                endNumber = endNumberInput;
            }

            // Loop to sum the numbers.

            int result = 0;

            for (int i = startNumber; i <= endNumber; i++)
            {
                result = result + i;
            }
            Console.WriteLine("The sum of the numbers " + startNumber + " and " + endNumber + " is: " + result);
        }
    }
}
