namespace AssignmentA2
{
    using System;
    class SelectionAndIteration
    {
        public SelectionAndIteration()
        {
            Console.WriteLine();
            Console.WriteLine("My name i: Kim I am a student of the VT22 semester!");
            Console.WriteLine();

            ShowStringLength();

            MakeMyDay();
            Console.WriteLine();

            SumNumbers();
        }
        private void ShowStringLength()
        {
            string input;
            int length;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Let me calculate the length of strings for you!");
                Console.WriteLine("Give me a text of any length, or press Enter to exit!");
                input = Console.ReadLine().ToUpper();
                length = input.Length;
                if( length > 0 ){
                    Console.WriteLine();
                    Console.WriteLine(input);
                    Console.WriteLine("Has " + length + " characters.");
                }
            } while (length > 0);
        }
        private void MakeMyDay()
        {
            Console.WriteLine("I can predict your day for you. Give me a number between 1 and 7:");
            string stringInput = Console.ReadLine();
            int number = int.Parse(stringInput);
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

            int startNumberInput = int.Parse(stringStartNumberInput);
            int endNumberInput = int.Parse(stringEndNumberInput);

            int startNumber;
            int endNumber;

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

            int result = 0;

            for (int i = startNumber; i <= endNumber; i++)
            {
                result = result + i;
            }
            Console.WriteLine("The sum of the numbers " + startNumber + " and " + endNumber + " is: " + result);
        }
    }
}
