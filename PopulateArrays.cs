using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10084788__POE_PART1
{
    public class PopulateArrays
    {

        // the PopulateArrays class holds the arrays needed for the program

        public ArrayList arrExpenseName = new ArrayList(); //Holds the expense name
        public ArrayList arrExpenseCost = new ArrayList(); // Holds the expense amount


        public string DisplayExpense() // displays all the names of expenses that the user has as well as their costs
        {
            string output = ""; // string variable to hold output
            for (int i = 0; i < arrExpenseName.Count; i++) // goes through all elements in the ArrayList
            {

                output = output + arrExpenseName[i] + ": R" + arrExpenseCost[i] + "\n"; // adds each expense name and cost to a line in the string variable
            }


            return output; // returns the output when method is called
        }

        public double sumArr() // calculate steh sum of all the expenses in the array
        {
            double sum = arrExpenseCost.Cast<double>().Sum();
            // we have to use the cast function since the ArrayList called arrExpenseCost has been specified with a data type
            // the cast function will then let the program now that is a double data type
            return Math.Round(sum, 2); // returns the sum of ArrayList when method is called
        }

    }


}



