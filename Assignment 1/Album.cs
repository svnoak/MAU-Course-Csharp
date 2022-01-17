namespace AssignmentA1
{
    using System;
    class Album
    {
        private string albumName;
        private string artistName;
        private int numOfTracks;
        public void Start()
        {
            SetAlbumName();
            SetArtistName();
            SetNumOfTracks();
            DisplayAlbumInfo();
        }
        private void DisplayIntroduction()
        {
            Console.WriteLine();
            Console.WriteLine("Starting the Album Program!");
            Console.WriteLine();
        }
        private void SetAlbumName()
        {
            Console.WriteLine("What is the name of your favorite music album?");
            albumName = Console.ReadLine();
        }
        private void SetArtistName()
        {
            Console.WriteLine("What is the Artist or Band for " + albumName + "?");
            artistName = Console.ReadLine();
        }
        private void SetNumOfTracks()
        {
            Console.WriteLine("How many tracks does " + albumName + " have?");
            string stringNumber = Console.ReadLine();
            numOfTracks = int.Parse(stringNumber);
        }
        private void DisplayAlbumInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Album Name: " + albumName);
            Console.WriteLine("Artist/Band: " + artistName);
            Console.WriteLine("Number of Tracks: " + numOfTracks);
            Console.WriteLine("Enjoy listening!");
            Console.WriteLine();
        }
    }
}