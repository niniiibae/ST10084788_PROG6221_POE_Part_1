using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10084788__POE_PART1
{

    class HomeLoan : Expense
    {
        // declaration of variables needed in the HomeLoan class
        private double purchasePrice; // purchase price of property
        private double totalDeposit; // total deposit user has paid
        private double interestRate; // interest rate of monthly home loan repayment (percentage)
        private int repayMonths; // number of months to repay home loan
        private double monthlyAmount; // calculates the monthly home loan repayment amount
        private double salaryAmount; // stores user's salary


        // get and sets for private variables decalred in HomeLoan class
        public double PurchasePrice { get => purchasePrice; set => purchasePrice = value; }
        public double TotalDeposit { get => totalDeposit; set => totalDeposit = value; }
        public double InterestRate { get => interestRate; set => interestRate = value; }
        public int RepayMonths { get => repayMonths; set => repayMonths = value; }
        public double SalaryAmount { get => salaryAmount; set => salaryAmount = value; }
        public double MonthlyAmount { get => monthlyAmount; set => monthlyAmount = value; }

        public void CalMonthly()
        {
            //Formula to calculate monthly home loan repayment amount --> A = P (1 * (in))

            //varibale used to in formula
            double principleAmount;
            double total;
            double years;
            double interest;

            principleAmount = PurchasePrice - TotalDeposit; // calculates purchase price after deposit
            years = RepayMonths / 12; // calculates months
            interest = InterestRate / 100; // sorts out interest rate

            total = principleAmount * (1 + (interest * years)); // the total amount that the user needs to pay
            MonthlyAmount = Math.Round((total / repayMonths), 2); // calculates monthly home loan repayment
            Console.WriteLine("Your Monthly Home Loan Repayment Is: R" + MonthlyAmount); // displays amount to user
            if (MonthlyAmount > (salaryAmount / 3))
            {
                // displays warning if the monthly home loan repayment amount if greater than a third of teh user's salary

                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Approval Of The Home Loan Is Unlikely. \n" +
                                  "The Monthly Home Loan Repayment Is More Than A Third Of Your Monthly Salary.");
                Console.BackgroundColor = ConsoleColor.Black;
            }

            else
            {
                // also notifies user if their home is likely to be approved
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Your Home Loan Is Likely To Be Approved. ");
                Console.BackgroundColor = ConsoleColor.Black;

            }



        }

        public override double CalculateExpense(double salary, double expenses, double taxAmount, double accommodation)
        {
            // calculates mmonthly available amount after expense deductions
            availAmount = Math.Round((salary - (taxAmount + expenses + accommodation)), 2);
            return availAmount;
        }

        public override void BudgetReport(double salary, double taxAmount, string output, double accommodation, double availAmount)
        {
            // displays a summary of the the user's expenses, salary, tax amount, rental amount
            Console.WriteLine("========================================================================");
            Console.WriteLine("Budget Report Summary");
            Console.WriteLine("========================================================================");

            Console.WriteLine("Salary: R" + salary);
            Console.WriteLine("Tax Amount: R" + taxAmount);
            Console.WriteLine("Salary After Tax Deductions: " + (salary - taxAmount));
            Console.WriteLine();

            Console.WriteLine("Your Monthly Expenses Are As Follows: ");
            Console.WriteLine(output);
            Console.WriteLine();
            Console.WriteLine("Your Monthly Home Loan Repayment: R" + accommodation);
            Console.WriteLine("Your Monthly Available Amopunt After All Expense Deductions: R" + availAmount);



        }




    }
}



