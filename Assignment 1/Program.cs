namespace AssignmentA1
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            // Creating new objects from class and calling Start() method.

            Pet petObj = new Pet();
            petObj.Start();

            ContinueToNext();

            TicketSeller ticketObj = new TicketSeller();
            ticketObj.Start();

            ContinueToNext();

            Album albumObj = new Album();
            albumObj.Start();

            Console.ReadLine();
        }
        private static void ContinueToNext()
        {

            // Repetetive lines that are reused in Main
            // Forcing user input to continue method.
            Console.WriteLine();
            Console.WriteLine("Press Enter to start next part.");
            Console.ReadLine();
        }
    }
}