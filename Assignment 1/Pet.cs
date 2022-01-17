namespace AssignmentA1
{
    using System;
    class Pet
    {
        private string name;
        private int age;
        private bool isFemale;
        public void Start()
        {
            SetPetName();
            SetPetAge();
            SetPageGender();
            DisplayPet();
        }
        private void DisplayIntroduction()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome from MyPet class!");
            Console.WriteLine();
        }
        private void SetPetName()
        {
            Console.WriteLine("What is the name of your pet?");
            name = Console.ReadLine();
        }
        private void SetPetAge()
        {
            Console.WriteLine("What is " + name + "'s age?");
            string stringAge = Console.ReadLine();
            age = int.Parse(stringAge);
        }
        private void SetPageGender()
        {
            Console.WriteLine("Is your pet female (y/n)?");
            string input = Console.ReadLine();
            if( input.ToLower() == "y" )
            {
                isFemale = true;
            }
            else
            {
                isFemale = false;
            }
        }
        private void DisplayPet()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++");
            Console.WriteLine("Name: " + name + " Age: " + age);
            if( isFemale )
            {
                Console.WriteLine(name + " is a good girl!");
            }
            else
            {
                Console.WriteLine(name + " is a good boy!");
            }
            Console.WriteLine("++++++++++++++++++++");
            Console.WriteLine();
        }
    }
}