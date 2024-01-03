// See https://aka.ms/new-console-template for more information
using ClassLibraryLoanRepayment;

internal class Program
{
    private static void Main(string[] args)
    {
        LoanRepayment l = new LoanRepayment(150000, 120, 3, 0.08d);
        int nb = l.NumberOfRefundsInt();
        double value = l.LoanAmount();
        //int i = 0;
        Console.WriteLine(l.LoanAmount());
    }
}