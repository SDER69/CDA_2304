using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLoanRepayment
{
    public class LoanRepayment
    {
        private int borrowedCapital;
        private int numberOfRefunds;
        private int repaymentFrequency;
        private double interestRate;

        public int BorrowedCapital { get => borrowedCapital; set => borrowedCapital = value; }
        public int NumberOfRefunds { get => numberOfRefunds; set => numberOfRefunds = value; }
        public int RepaymentFrequency { get => repaymentFrequency; set => repaymentFrequency = value; }
        public double InterestRate { get => interestRate; set => interestRate = value; }

        public LoanRepayment(int _borrowedCapital, int _numberOfRefunds, int _repaymentFrequency, double _interestRate)
        {
            this.borrowedCapital = _borrowedCapital;
            this.numberOfRefunds = _numberOfRefunds;
            this.repaymentFrequency = _repaymentFrequency;
            this.interestRate = _interestRate;
        }

        /// <summary>
        /// tutuut
        /// </summary>
        /// <returns></returns>
        public int NumberOfRefundsInt()
        { 
            return numberOfRefunds/repaymentFrequency; 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double LoanAmount()
        {
            double correctedRate = this.interestRate * ((double)this.repaymentFrequency) / 12;
            double loanAmount = this.borrowedCapital * correctedRate /
                            (1 - Math.Pow((1 + correctedRate), NumberOfRefundsInt() * -1));
            return Math.Round(loanAmount,2);
        }
    }
}
