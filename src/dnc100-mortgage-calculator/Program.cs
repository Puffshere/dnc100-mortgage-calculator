using System;

namespace dnc100_mortgage_calculator
{
    public class Program
    {
        public static double Mortgage(double principal, double interestRate, int term, int period)
        {
            int months = term * 12;
            double r = interestRate / 1200;
            double top = r * Math.Pow((1 + r), months);
            double bottom = Math.Pow((1 + r), months) - 1;
            double payment = (principal * (top / bottom));
            string str = payment.ToString("0.00");
            double mortgage = Convert.ToDouble(str);
            return mortgage;
        }
        static void Main(string[] args)
        {
            Mortgage mortgage;
            double principal, interestRate, monthlyPayment;
            int term, period;
            monthlyPayment = 0;
            


            // Use .WriteLine to greet the user
            Console.WriteLine("Hello!  Hope you are having a great day!");
            Console.Write("What is the principal amount due on your home loan: ");
            principal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("If the principal due is $" + principal + ".00.");
            Console.Write("What is your interest rate: ");
            interestRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("And your interest rate is " + interestRate + "%.");
            Console.Write("What is the term of your loan in years: ");
            term = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("And the term of your loan is a " + term + " year loan.");
            Console.Write("How many payments will you be making per year: ");
            period = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("And your make " + period + " payment per year.");
            Console.WriteLine("Your monthly payment would be " + monthlyPayment + ".");
            // Use a mix of WriteLine and ReadLine to obtain the mortgage attributes (Making sure to typecast)

            // Create a new Mortgage with the given attributes;

            // Use the Mortgage functions to calculate the monthly payment

            // Use WriteLine to output the monthly payment
            Console.Read();
        }
    }
}
