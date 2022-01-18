namespace AssignmentA2
{
    using System;
    class TemperatureConverter
    {
        int choice = -1;
        public TemperatureConverter()
        {
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
            Console.WriteLine("   Your choice:");
            string stringChoice = Console.ReadLine();
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
                Console.WriteLine("{0,15} {1,15}", celsius.ToString("0.00") + " C = ", fahrenheit.ToString("0.00") + " F" );
            }
        }
        private void DisplayTableFahrenheitToCelsius()
        {
            const int max = 212;
            for (int fahrenheit = 0; fahrenheit <= max; fahrenheit += 10)
            {
                double celsius = FahrenheitToCelsius(fahrenheit);
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
