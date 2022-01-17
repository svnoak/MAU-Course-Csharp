namespace AssignmentA1
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine();
            Console.WriteLine("Press Enter to start next part.");
            Console.ReadLine();
        }
    }
}