namespace AssignmentA4
{
    class PhoneBook
    {
        private string[] names = { "Tobbe", "Sebbe", "Olivia", "Malcolm", "Gregor", "Elizabeth", "Thomas" };
        private string[] phones = { "040-1234", "041-1234", "040-5485", "040-5967", "040-9836", "040-9454", "040-6554" };
        private string[,] phoneList;

        public void DisplayList()
        {
            for (int i = 0; i < names.Length; i++)
            {
                string strOut = string.Format("{0,-15} {1,-15}", names[i], phones[i]);
                Console.WriteLine(strOut);
            }

        }

        public void DisplayTable()
        {
            int rows = phoneList.GetLength(0);
            int cols = phoneList.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                Console.Write(string.Format("{0,-8}", "Row " + row.ToString()));

                for (int col = 0; col < cols; col++)
                {
                    Console.Write(string.Format("{0, -15}", phoneList[row, col]));
                }
                Console.WriteLine();
            }
            
        }

        public void FillTable()
        {

            int count = names.Length;
            phoneList = new string[count, 2];
            for (int row = 0; row < phones.Length; row++)
            {
                phoneList[row, 0] = names[row];
                phoneList[row, 1] = phones[row];
            }
            
        }

        public void SortByName()
        {
            int pos, i;
            int lenght = names.Length;

        for( pos = 0; pos < lenght; pos++)
        {
            // Last i elelemnts are already in place
            for (i = 0; i < lenght - pos - 1; i++)
            {
                int result = names[i].CompareTo(names[i + 1]);

                if (result == 1)
                {
                    SwapValues(i);
                }
            }
        }

            
        }

        public void SwapValues(int pos)
        {
            string temp = names[pos];
            names[pos] = names[pos + 1];
            names[pos + 1] = temp;

            //Swap also the corresponding phones
            temp = phones[pos];
            phones[pos] = phones[pos + 1];
            phones[pos + 1] = temp;
        }
    }
}
