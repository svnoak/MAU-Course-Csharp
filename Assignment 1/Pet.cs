namespace AssignmentA1
{
    using System;
    class Pet
    {

        // Declaring variables.
        private string name;
        private int age;
        private bool isFemale;
        public void Start()
        {
            // Calling all methods in order
            DisplayIntroduction();
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
            // Assigning name variable
            Console.WriteLine("What is the name of your pet?");
            name = Console.ReadLine();
        }
        private void SetPetAge()
        {

            // Assigning age variable
            // Could add int.TryParse for checking input type
            Console.WriteLine("What is " + name + "'s age?");
            string stringAge = Console.ReadLine();
            age = int.Parse(stringAge);
        }
        private void SetPageGender()
        {

            // Assigning gender variable
            Console.WriteLine("Is your pet female (y/n)?");
            string input = Console.ReadLine();
            if (input.ToLower() == "y")
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
            // Displaying information depending on gender variable.
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++");
            Console.WriteLine("Name: " + name + " Age: " + age);
            if (isFemale)
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