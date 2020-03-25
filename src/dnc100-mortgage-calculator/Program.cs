using System;

namespace dnc100_mortgage_calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            double principal = 0, interestRate = 0;
            int term = 0, period = 0;
            bool valid = false;

            Console.WriteLine("Hello!  Hope you are having a great day!");
            while (!valid)
            {
                Console.Write("What is the principal amount due on your home loan: ");
                bool isDouble = Double.TryParse(Console.ReadLine(), out principal);
                if (isDouble)
                {
                    Console.WriteLine("If the principal due is $" + principal + ".00.");
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid dollar amount.");
                    valid = false;
                }
            }
            while (valid)
            {
                Console.Write("What is your interest rate: ");

                bool isRate = Double.TryParse(Console.ReadLine(), out interestRate);
                if (isRate)
                {
                    Console.WriteLine("And your interest rate is " + interestRate + "%.");
                    valid = false;
                }
                else
                {
                    Console.WriteLine("Please enter a valid Interest Rate.");
                    valid = true;
                }
            }
            while (!valid)
            {
                Console.Write("What is the term of your loan in years: ");
                bool isTerm = int.TryParse(Console.ReadLine(), out term);
                if (isTerm)
                {
                    Console.WriteLine("And the term of your loan is a " + term + " year loan.");
                    valid = true;
                }
                else
                    Console.WriteLine("Please enter a valid Term");
            }
            while (valid)
            { 
                Console.Write("How many payments will you be making per year: ");
            bool isPeriod = int.TryParse(Console.ReadLine(), out period);
            if (isPeriod)
            {
                Console.WriteLine("And your make " + period + " payment per year.");
                valid = false;
            }
            else
                Console.WriteLine("Please enter a valid number of payments per year.");
            }

            Mortgage mortgage = new Mortgage(principal, interestRate, term, period);
            double monthlyPayment = mortgage.Calculate();

            int months = mortgage.NumberOfPayments(term, period);
            double monthlyRate = mortgage.MonthlyInterestRate(interestRate, period);
            double compoundInterest = mortgage.CompoundedInterestRate(monthlyRate, months);
            double iQ = mortgage.InterestQuotient(monthlyRate, compoundInterest, months);

            Console.WriteLine("Your monthly payment would be $" + String.Format("{0:.##}", monthlyPayment) + ".");
            Console.WriteLine("Press any key to end program.");

            Console.Read();
        }
    }
}
