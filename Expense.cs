using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10084788__POE_PART1
{
    abstract class Expense
    {
        // expense is an abstract class
        public double availAmount; // variable to hold available amount after expense deductions

        public abstract double CalculateExpense(double salary, double expenses, double taxAmount, double accommodation);  // calculates available amount after expense deuctions
        public abstract void BudgetReport(double salary, double taxAmount, string output, double accommodation, double availAmount); // display summary of user's salary, expenses, tax amount, accomodation, and available amount after expense deductions
    }
}
