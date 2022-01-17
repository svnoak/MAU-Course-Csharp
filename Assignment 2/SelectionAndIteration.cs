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
            Console.WriteLine();

            /*MakeMyDay();
            Console.WriteLine();

            SumNumbers();*/
        }
        private void ShowStringLength()
        {
            string input;
            int length;
            do
            {
                Console.WriteLine("Let me calculate the length of strings for you!");
                Console.WriteLine("Give me a text of any length, or press Enter to exit!");
                input = Console.ReadLine().ToUpper();
                length = input.Length;
            } while (length > 0);
            Console.WriteLine(input + " is " + length + " letters long.");
        }
    }
}