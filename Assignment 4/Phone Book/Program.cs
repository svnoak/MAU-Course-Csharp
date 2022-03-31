using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentA4
{
    public class Program
    {
        static void Main()
        {
            Console.Clear();

            PhoneBook phoneBook = new PhoneBook();

            phoneBook.DisplayList();


            phoneBook.SortByName();
            Console.WriteLine("\n\nSorted List:\n");

            phoneBook.DisplayList();

            phoneBook.FillTable();



            Console.WriteLine("\n\nUsing a 2d arraz instead of two 1d arrays:\n");
            phoneBook.DisplayTable();
            
        }
    }
}
