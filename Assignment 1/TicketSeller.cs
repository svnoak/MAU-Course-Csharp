namespace AssignmentA1
{
    using System;
    class TicketSeller
    {

        // Declaring all necessary variables.
        private string name;
        private double price = 100;
        private int numOfAdults;
        private int numOfChildren;
        private double amountToPay;
        public void Start()
        {
            // Calling all methods in order
            DisplayIntroduction();
            SetName();
            SetNumOfAdults();
            SetNumOfChildren();
            CalculatePrice();
            DisplayReceipt();
        }
        private void DisplayIntroduction()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to KIDS' FAIR!");
            Console.WriteLine("Children always get a 75% discount!");
            Console.WriteLine();
        }
        private void SetName()
        {
            // Assigning name variable for use in receipt
            Console.WriteLine("Your name please:");
            name = Console.ReadLine();
        }
        private void SetNumOfAdults()
        {
            // Assigning number of adults for calculation of price
            // Could add input check if int.TryParse.
            Console.WriteLine("Number of adults:");
            string stringNumber = Console.ReadLine();
            numOfAdults = int.Parse(stringNumber);
        }
        private void SetNumOfChildren()
        {
            // Assigning number of children for calculation of price
            // Could add input check if int.TryParse.
            Console.WriteLine("Number of children:");
            string stringNumber = Console.ReadLine();
            numOfChildren = int.Parse(stringNumber);
        }
        private void CalculatePrice()
        {
            // Price calculation for receipt.
            double priceChildren = numOfChildren * (price * 0.75);
            double priceAdults = numOfAdults * price;
            amountToPay = priceChildren + priceAdults;
        }
        private void DisplayReceipt()
        {
            Console.WriteLine();
            Console.WriteLine("+++ Your receipt +++");
            Console.WriteLine("+++ Amount to pay = " + amountToPay.ToString("0.00"));
            Console.WriteLine("+++ Thank you " + name + " and please come back! +++");

        }
    }
}