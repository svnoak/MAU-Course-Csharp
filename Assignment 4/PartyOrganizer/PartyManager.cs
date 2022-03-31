using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyOrganizer
{
    internal class PartyManager
    {
        private double costPerPerson;
        private double feePerPerson;
        private string[] guestList;

        //Constructor - expect maxNumGuests fomr the caller to set the size of array
        public PartyManager (int maxNumOfGuests)
        {
            //Create the array here in the constructor
            guestList = new string[maxNumOfGuests];
        }

         public double FeePerPerson
        {
            get { return feePerPerson; }
            set
            {
                if (value >= 0.0)
                {
                    feePerPerson = value;
                }
            }
        }

        public double CostPerPerson 
        { 
            get { return costPerPerson; } 
            set
            {
                if (value >= 0.0)
                {
                    costPerPerson = value;
                }
            }
        }

        private int NumOfGuests()
        {
            int numGuests = 0;

            for (int i = 0; i < guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    numGuests++;
                }
            }
            return numGuests;
        }

        private int FindVacantPos()
        {
            int vacantPos = -1;
            for (int i = 0; i < guestList.Length; i++)
            {
                if( string.IsNullOrEmpty(guestList[i]))
                {
                    vacantPos = i;
                    break;
                }
            }
            return vacantPos;
        }

        public bool AddNewGuest(string firstName, string lastName)
        {
            bool ok = true;
            int vacantPos = FindVacantPos();

            if (vacantPos != -1)
            {
                guestList[vacantPos] = FullName(firstName, lastName);
            }
            else
                ok = false;

            return ok;
        }

        private string FullName(string firstName, string lastName)
        {
            return lastName.ToUpper() + ", " + firstName; 
        }

        public bool DeleteAt(int index)
        {
            bool ok = false;
            if (CheckIndex(index))
            {
                guestList[index] = string.Empty;
                MoveElementsOneStepToLeft(index);
                ok = true;
            }
            return ok;
        }

        private bool CheckIndex(int index)
        {
            if( index < 0)
            {
                return false;
            }
            return true;
        }

        private void MoveElementsOneStepToLeft(int index)
        {
            for (int i = index + 1; i < guestList.Length; ++i)
            {
                guestList[i - 1] = guestList[i];
                guestList[i] = string.Empty;
            }
        }

        public string[] GetGuestList()
        {
            int size = NumOfGuests();

            if (size <= 0)
                return null;

            string[] guests = new string[size];

            for (int i = 0, j = 0; i < size; ++i)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    guests[j++] = guestList[i];
                }
            }
            return guests;
        }
        
        public double CalcTotalCost()
        {
            return CostPerPerson * GetGuestList().Length;
        }

        public double CalcTotalFees()
        {
            return FeePerPerson * GetGuestList().Length;
        }

        public double CalcProfit()
        {
            return ((FeePerPerson * GetGuestList().Length) - (CostPerPerson * GetGuestList().Length));
        }
    }
}
