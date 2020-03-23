using System;

namespace dnc100_mortgage_calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            double principal, interestRate;
            int term, period;
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
            principal = 0;
            if (valid)
            {
                Console.Write("What is your interest rate: ");
            }
            interestRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("And your interest rate is " + interestRate + "%.");
            Console.Write("What is the term of your loan in years: ");
            term = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("And the term of your loan is a " + term + " year loan.");
            Console.Write("How many payments will you be making per year: ");
            period = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("And your make " + period + " payment per year.");
            Mortgage mortgage = new Mortgage(principal, interestRate, term, period);
            double monthlyPayment = mortgage.Calculate();
            int months = mortgage.NumberOfPayments(term, period);
            double monthlyRate = mortgage.MonthlyInterestRate(interestRate, period);
            double compoundInterest = mortgage.CompoundedInterestRate(monthlyRate, months);
            double iQ = mortgage.InterestQuotient(monthlyRate, compoundInterest, months);
            Console.WriteLine("Your monthly payment would be " + monthlyPayment + ".");

            Console.Read();
        }
    }
}
