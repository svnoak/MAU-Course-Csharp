namespace AssignmentA2
{
    using System;
    class TemperatureConverter
    {
        int choice = -1;
        public TemperatureConverter()
        {

            // Initialize methods.
            // Repeat as long as no option is choosen.
            while (choice != 0)
            {
                DisplayMenu();
                SelectOption();
                
                switch (choice)
                {
                    case 0:
                        break;
                    case 1:
                        DisplayTableCelsiusToFahrenheit();
                        break;
                    case 2:
                        DisplayTableFahrenheitToCelsius();
                        break;
                }
            }
        }
        private void DisplayMenu()
        {

            // Displays user choice possibilities for SelectOption.
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("             MAIN MENU              ");
            Console.WriteLine();
            Console.WriteLine("------------------------------------");

            Console.WriteLine();
            Console.WriteLine("   Celsius to Fahrenheit      :1 ");
            Console.WriteLine("   Fahrenheit to Celsius      :2 ");
            Console.WriteLine("   Exit the program           :0 ");
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
        }
        private void SelectOption()
        {

            // Checking if any input is given and assign it to choice variable.
            Console.WriteLine("   Your choice:");
            string stringChoice = Console.ReadLine();
            
            // Only assign choice if input is given.
            // Used for checking if menu should be shown again
            // see constructor for how choice is used.
            if( stringChoice.Length > 0 )
            {
                choice = int.Parse(stringChoice);
            }
        }
        private void DisplayTableCelsiusToFahrenheit()
        {
            const int max = 100;
            for (int celsius = 0; celsius <= max; celsius += 4)
            {
                double fahrenheit = CelsiusToFahrenHeit(celsius);

                // Creating columns for better readability.
                Console.WriteLine("{0,15} {1,15}", celsius.ToString("0.00") + " C = ", fahrenheit.ToString("0.00") + " F" );
            }
        }
        private void DisplayTableFahrenheitToCelsius()
        {
            const int max = 212;
            for (int fahrenheit = 0; fahrenheit <= max; fahrenheit += 10)
            {
                double celsius = FahrenheitToCelsius(fahrenheit);

                // Creating columns for better readability.
                Console.WriteLine("{0,15} {1,15}", fahrenheit.ToString("0.00") + " F = ", celsius.ToString("0.00") + " C");
            }
        }
        private double CelsiusToFahrenHeit(double celsius)
        {
            return 9 / 5.0 * celsius + 32;
        }
        private double FahrenheitToCelsius(double fahrenheit)
        {
            return 5 / 9.0 * (fahrenheit - 32);
        }
    }
}
