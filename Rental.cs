using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10084788__POE_PART1
{
    class Rental : Expense
    {
        // Rental class extends Expense class

        public override double CalculateExpense(double salary, double expenses, double taxAmount, double accommodation)
        {   // calculates available amount after expense deductions
            availAmount = Math.Round((salary - (taxAmount + expenses + accommodation)), 2);
            return availAmount;
        }


        public override void BudgetReport(double salary, double taxAmount, string output, double accommodation, double availAmount)
        {
            // displays a summary of the the user's expenses, salary, tax amount, rental amount

            Console.BackgroundColor = ConsoleColor.Blue;

            Console.WriteLine("========================================================================");

            Console.WriteLine("Budget Report Summary");
            Console.WriteLine("========================================================================");

            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Salary: R" + Math.Round(salary, 2));
            Console.WriteLine("Tax Amount: R" + Math.Round(taxAmount, 2));
            Console.WriteLine("Salary After Tax Deductions: R" + Math.Round((salary - taxAmount), 2));
            Console.WriteLine("Your Monthly Expenses Are As Follows: ");
            Console.WriteLine(output);
            Console.WriteLine("Your Monthly Rental Amount: R" + Math.Round(accommodation, 2));
            Console.WriteLine("Your Monthly Available Amopunt After All Expense Deductions: R" + availAmount);



        }
    }
}





