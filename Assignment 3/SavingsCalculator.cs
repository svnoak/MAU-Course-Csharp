using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class SavingsCalculator
    {
        private double monthlyDeposit;
        private double interestRate;
        private int period;

        // Getter and Setter for Monthly deposit
        // Checks if value is above 0, other validation happens in Main
        public double MonthlyDeposit
        {
            get { return monthlyDeposit; }
            set 
            {   
                if (value >= 0)
                    monthlyDeposit = value; 
            }
        }

        // Getter and Setter for Interest rate
        // Checks if value is above 0, other validation happens in Main
        public double InterestRate
        {
            get { return interestRate; }
            set
            {
                MessageBox.Show(value.ToString());
                if (value >= 0)
                    interestRate = value;
            }
        }

        // Getter and Setter for period of saving
        // Checks if value is above 0, other validation happens in Main
        public int Period
        {
            get { return period; }
            set 
            {
                if (value >= 0)
                    period = value; 
            }
        }

        // Calculates savings with set interest rate from main.
        public double caluclateSavings()
        {
            int numOfMonths = period * 12;
            double balance = 0;

            for (int i = 0; i < numOfMonths; i++)
            {
                double interestEarned = interestRate * balance;
                balance += interestEarned + monthlyDeposit;
            }

            return balance;
        }

        public double amountPaid()
        {
            int numOfMonths = period * 12;
            double amount = numOfMonths * monthlyDeposit;
            return amount;
        }
    }
}
