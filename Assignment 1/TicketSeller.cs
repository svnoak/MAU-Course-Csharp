namespace AssignmentA1
{
    using System;
    class TicketSeller
    {
        private string name;
        private double price = 100;
        private int numOfAdults;
        private int numOfChildren;
        private double amountToPay;
        public void Start()
        {
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
            Console.WriteLine("Your name please:");
            name = Console.ReadLine();
        }
        private void SetNumOfAdults()
        {
            Console.WriteLine("Number of adults:");
            string stringNumber = Console.ReadLine();
            numOfAdults = int.Parse(stringNumber);
        }
        private void SetNumOfChildren()
        {
            Console.WriteLine("Number of children:");
            string stringNumber = Console.ReadLine();
            numOfChildren = int.Parse(stringNumber);
        }
        private void CalculatePrice()
        {
            double priceChildren = numOfChildren * ( price * 0.75 );
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