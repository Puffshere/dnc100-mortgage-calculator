using System;
using System.Collections.Generic;
using System.Text;

namespace dnc100_mortgage_calculator
{
    public class Mortgage
    {
        public Mortgage(double principle, double interest, int term, int period)
        {

        }

        public double Calculate()
        {
            return 0;
        }

        public double MonthlyInterestRate(double interest, int period)
        {
            double percent = interest / 100;
            double monthlyRate = percent / period;
            return monthlyRate;
        }

        public int NumberOfPayments(int term, int period)
        {
            return period * term;
        }

        public double CompoundedInterestRate(double monthlyInterestRate, int numberOfPayments)
        {
            return 0;
        }

        public double InterestQuotient(double monthlyInterestRate, double compoundedInterestRate, int numberOfPayments)
        {
            return 0;
        }
    }
}
