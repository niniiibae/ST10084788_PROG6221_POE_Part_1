using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ST10084788__POE_PART1
{
    public class Program
    {
        // Create global objects of the classes that we need to access later on in the program
        PopulateArrays populateArrays = new PopulateArrays(); // Object of the PopulateArrays class
        HomeLoan hml = new HomeLoan(); // Object of the HomeLoan class
        Rental rental = new Rental();   // Object of the Rental class

        // Global declaration of the variables that we will get the values for from the user
        public double salary; // Holds user's salary
        public double taxAmount; // Holds tax amount

        static void Main(string[] args)
        {
            WelcomeAnimation(); // calls WelcomeAnimation() which displays a simple animation and welcome message
            ShowSpinner(); // displays a spinner

            Program progObj = new Program(); // Object of the main class
            progObj.DisplayMenu();  // calls DisplayMenu() method

            Console.ReadLine(); // Console.ReadLine() is used at the end of the main program to ensure that the program stays open
        }

        public void DisplayMenu()
        {
            // The DisplayMenu() method displays the menu to the user and accepts the input (a menu item) and then calls the 
            // necessary method

            // Display menu to user

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("========================================================================");
            Console.WriteLine("Main Menu");
            Console.WriteLine("========================================================================");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Please Choose One Of The Following Items: \n" +
                              "1. Run Budget Planner Application. \n" +
                              "2. Exit Application.");

            bool bValidate = true; // boolean variable that controls the while loop 
            string menuItem = Console.ReadLine(); // Variable that reads the user's input
            while (bValidate)
            {
                if (string.IsNullOrEmpty(menuItem) || !(menuItem.Equals("1") || menuItem.Equals("2")))
                {
                    //if statement checks if the user has entered anything and if they did, it checks if the input is valid
                    bValidate = true;

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Invalid Menu Item Selected");

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("Please Choose One Of The Following Items: \n" +
                                      "1. Run Budget Planner Application. \n" +
                                      "2. Exit Application.");

                    menuItem = Console.ReadLine(); // reads in user's input again since their entry was invalid
                }
                else
                {
                    bValidate = false; // breaks loop if the user's input is valid
                }

                if (!bValidate)  // controls what happens if the user enters a valid input
                {
                    switch (menuItem) // calls necessary methods based on user's input
                    {
                        case "1": BudgetPlanner(); break; // calls BugetPlanner() method
                        case "2": ExitApplication(); break; // calls ExitApplication() method
                    }
                }
            }
        }

        public void BudgetPlanner()
        {
            // The BudgetPlanner method asks the user to enter the estimated amount for each of the basic expenses
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("========================================================================");
            Console.WriteLine("Budget Planner");
            Console.WriteLine("========================================================================");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Let Us Commence With The Budget Planner Application! \n" +
                              "Please Note: Enter All Decimal Values With A Comma (,) --> Example: '15,2' \n" +
                              "Please Enter Your Gross Salary Before Deductions >>");

            // get salary amount from user
            salary = 0;
            while (!double.TryParse(Console.ReadLine(), out salary)) //The while loops ensures that user has not entered an invalid data type
                                                                     // or if they have provided a blank response
            {
                ValidateData("Salary"); // calls ValidateData() nethod
            }
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Salary Saved Successfully!");   //stores the salary amount
            Console.BackgroundColor = ConsoleColor.Black;
            hml.SalaryAmount = salary;  // also saves the salary amount to the HomeLoan class
            Console.WriteLine(); // leaves an empty line

            // get tax amount from user
            Console.WriteLine("Enter Your Estimated Monthly Tax Amount >> ");
            taxAmount = 0;
            while (!double.TryParse(Console.ReadLine(), out taxAmount)) // The while loops ensures that user has not entered an invalid data type
                                                                        // or if they have provided a blank response
            {
                ValidateData("Tax Amount"); // calls ValidateData() nethod
            }
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Tax Amount Saved Successfully!");  //stores the tax amount
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();   // leaves an empty line

            //get groceries amount from user
            Console.WriteLine("Enter Your Estimated Expenditure On Groceries >> ");
            double groceriesAmount = 0;
            while (!double.TryParse(Console.ReadLine(), out groceriesAmount)) // The while loops ensures that user has not entered an invalid data type
                                                                              // or if they have provided a blank response
            {
                ValidateData("Groceries"); // calls ValidateData() nethod  
            }
            populateArrays.arrExpenseName.Add("Groceries"); // adds groceries as an expense
            populateArrays.arrExpenseCost.Add(groceriesAmount); // adds groceries amount to array
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Expendure Amount On Groceries Saved Successfully!");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(); // leaves an empty line

            //get water and lights amount from user
            Console.WriteLine("Enter Your Estimated Expenditure On Water And Lights >> ");
            double WaterAndLights = 0;
            while (!double.TryParse(Console.ReadLine(), out WaterAndLights))  // The while loops ensures that user has not entered an invalid data type
                                                                              // or if they have provided a blank response
            {
                ValidateData("Water And Lights"); // calls ValidateData() nethod
            }
            populateArrays.arrExpenseName.Add("Water And Lights"); // adds water and lights as an expense
            populateArrays.arrExpenseCost.Add(WaterAndLights); // adds lights and water amount to array
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Expendure Amount On Water And Lights Saved Successfully!");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(); // leaves an empty line

            // get travel costs amount from user
            Console.WriteLine("Enter Your Estimated Expenditure On Travel Costs (Including Fuel) >> ");
            double travelCosts = 0;
            while (!double.TryParse(Console.ReadLine(), out travelCosts)) // The while loops ensures that user has not entered an invalid data type
                                                                          // or if they have provided a blank response
            {
                ValidateData("Travel Costs"); // calls ValidateData() nethod

            }
            populateArrays.arrExpenseName.Add("Travel Costs");  // adds travel costs as an expense
            populateArrays.arrExpenseCost.Add(travelCosts); // adds travel costs amount to array
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Travel Costs Saved Successfully!");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(); // leaves an empty line 

            // get phone billing amount from user
            Console.WriteLine("Enter Your Estimated Expenditure On Cellphone And Telephone Billing >>");
            double phoneBills = 0;
            while (!double.TryParse(Console.ReadLine(), out phoneBills))  // The while loops ensures that user has not entered an invalid data type
                                                                          // or if they have provided a blank response
            {
                ValidateData("Cellphone And Telephone Billing"); // calls ValidateData() nethod
            }
            populateArrays.arrExpenseName.Add("Phone Bills"); // adds phone bills as an expense
            populateArrays.arrExpenseCost.Add(phoneBills); // adds phone bills amount to array
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Phone Billing Costs Saved Successfully!");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(); // leaves an empty line

            MoreExpensesOrAccomodation(); // calls MoreExpensesOrAccomodation() once the suer has entered values for all the basic expenses
        }

        public void ValidateData(string expenseName)
        {
            // The ValidateData method is used to notify users they have not entered a valid value for an expense 
            // and asks them to re-enter the value

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Please Enter A Valid Numerical Value For " + expenseName);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter The Amount For" + expenseName + " Again >>");
        }

        public void MoreExpensesOrAccomodation()
        {
            // The MoreExpensesOrAccomodation() asks users whether they want to add additional expenses that they may have
            // or if they want to proceed with the rest of the application 
            Console.WriteLine();
            Console.WriteLine("Do You Have Any Other Expenses? \n" +
                              "Press 1 To Add An Expense \n" +
                              "Or 2 To Continue With The Application.");

            bool bValidate = true; // boolean variable that controls the while loop
            string menuItem = Console.ReadLine(); // Variable that reads the user's input
            while (bValidate)
            {
                if (string.IsNullOrEmpty(menuItem) || !(menuItem.Equals("1") || menuItem.Equals("2")))
                {
                    //if statement checks if the user has entered anything and if they did, it checks if the input is valid
                    bValidate = true;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Invalid Menu Item Selected.");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Do You Have Any Other Expenses? \n" +
                                      "Press 1 To Add An Expense \n" +
                                      "Or 2 To Continue With The Application.");
                    menuItem = Console.ReadLine(); // reads in user's input again since their entry was invalid
                }
                else
                {
                    bValidate = false; // breaks loop if the user's input is valid
                }

                if (!bValidate) // calls neccessary methods based on user's input
                {
                    switch (menuItem)
                    {
                        case "1": ExtraExpenses(); break; // calls ExtraExpenses() method
                        case "2": Accommodation(); break; // calls Accomodation() method
                    }
                }
            }
        }

        public void ExtraExpenses()
        {
            //The ExtraExpense() method asks the user to list all their additional expenses and their costs
            Console.WriteLine("What Is The Name Of Your Additional Expense?");
            string addExpense = Console.ReadLine(); // reads input from user
            bool bValidate = true; // boolean variable that controls the while loop 
            while (bValidate)
            {
                if (string.IsNullOrEmpty(addExpense)) // checks if the user has not entered a value
                {
                    bValidate = true;
                    Console.WriteLine("Please Enter An Additional Expense >> ");
                    addExpense = Console.ReadLine(); // asks user to enter expense again if they have not entered anything
                }
                else
                {
                    bValidate = false; // breaks loop if the user's input is valid
                }
            }

            if (!bValidate) // asks user to enter cost of expense 
            {
                populateArrays.arrExpenseName.Add(addExpense); //adds expense name to array
                Console.WriteLine("Enter Your Estimated Expenditure On " + addExpense + " >> ");
                double addExpenseAmount = 0;

                while (!double.TryParse(Console.ReadLine(), out addExpenseAmount)) // The while loops ensures that user has not entered an invalid data type
                                                                                   // or if they have provided a blank response
                {
                    ValidateData(addExpense);
                }
                populateArrays.arrExpenseCost.Add(addExpenseAmount); // adds expense cost to array if they entered a valid value
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Expendure Amount On " + addExpense + " Saved Successfully!");
                Console.BackgroundColor = ConsoleColor.Black;

            }

            MoreExpensesOrAccomodation(); // Calls  MoreExpensesOrAccomodation() method to ask user if they want to add any more expense
                                          // or continue with rest of the application
        }

        public void Accommodation()
        {
            //The Accomodation() asks users if they would like to buy a property or rent an accomodation
            // Based on the user's input, it will then call the neccessary method

            Console.BackgroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("========================================================================");

            Console.WriteLine("Accomodation");
            Console.WriteLine("========================================================================");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Please Select Your Accommodation Type. Enter The Appropriate Number. \n" +
                              "1. Rent An Accommodation. \n" +
                              "2. Buy A Property. ");

            bool bValidate = true;  // boolean variable that controls the while loop 
            string menuItem = Console.ReadLine(); // reads input from user
            while (bValidate)
            {
                // checks if the user has not entered a value, or if they have entered an invalid value
                if (string.IsNullOrEmpty(menuItem) || !(menuItem.Equals("1") || menuItem.Equals("2")))
                {
                    bValidate = true;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Invalid Menu Item Selected.");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Please Select Your Accommodation Type. Enter The Appropriate Number. \n" +
                        "1. Rent An Accommodation. \n" +
                        "2. Buy A Property. ");

                    menuItem = Console.ReadLine();  // reads in user's input again since their entry was invalid
                }
                else
                {
                    bValidate = false; // breaks loop if the user's input is valid
                }

                if (!bValidate) // calls appropriate method if the user's input is valid
                {
                    switch (menuItem)
                    {
                        case "1": RentAccommodation(); break; //calls RentAccommodation() method
                        case "2": BuyProperty(); break; //calls BuyProperty() method
                    }
                }
            }
        }

        public void BuyProperty()
        {
            //The BuyProperty() method, asks users to enter the necessary information
            //The program will the calculate the monthly loan repayment amount
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("========================================================================");

            Console.WriteLine("Home Loan Calculator - Buying A Property");
            Console.WriteLine("========================================================================");

            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Please Enter The Purchase Price Of The Property >>"); // asks user to enter purchase price property
            double PurchasePrice = 0;
            while (!double.TryParse(Console.ReadLine(), out PurchasePrice)) // checks if the input is a numeric value
            {
                ValidateData("Purchase Price Of Property");
            }
            hml.PurchasePrice = PurchasePrice; // saves purchase price if they entered a valid numeric value
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Purchase Price Saved Successfully!");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Please Enter Total Depost >>"); // asks user to enter total deposit
            double TotalDeposit = 0;
            while (!double.TryParse(Console.ReadLine(), out TotalDeposit))  // checks if the input is a numeric value
            {
                ValidateData("Total Deposit");
            }
            hml.TotalDeposit = TotalDeposit; // saves total deposit if they entered a valid numeric value
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Total Deposit Saved Successfully!");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Please Enter Interest Rate (Percentage) >>");  // asks user to enter interest rate
            double InterestRate = 0;
            while (!double.TryParse(Console.ReadLine(), out InterestRate)) // checks if the input is a numeric value
            {
                ValidateData("Interest Rate (Percentage)");
            }
            hml.InterestRate = InterestRate; // saves interest rate if they entered a valid numeric value
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Interest Rate Saved Successfully!");
            Console.BackgroundColor = ConsoleColor.Black;


            Console.WriteLine("Number Of Months To Repay Home Loan (Either 240 Or 360)");   // asks user to enter number of months to repay home load
            int RepayMonths = 0;
            while (!int.TryParse(Console.ReadLine(), out RepayMonths))
            {
                ValidateData("Months To Repay Home Loan (Either 240 OR 360)");
            }
            string monthsNeeded = RepayMonths.ToString(); // converts the number of months to a string data type
            bool bValidate = true; // boolean variable to control while loop
            while (bValidate)
            {
                if (!(monthsNeeded.Equals("240") || monthsNeeded.Equals("360")))
                {
                    // if statement checks if the user has not entered a valid input for the amount of months needed
                    // the user can only choose between 204 or 360
                    bValidate = true;
                    ValidateData("Of Months To Repay Home Loan (either 240 OR 360)");
                    RepayMonths = int.Parse(Console.ReadLine()); // asks user to re-enter number of months
                    monthsNeeded = RepayMonths.ToString(); // converts value to string so that it can be tested
                }

                else { bValidate = false; } // breaks loop if the user has entered 240 or 360 months


                if (!bValidate) // what happens if they enter a valid input
                {
                    hml.RepayMonths = RepayMonths; // saves number of months to HomeLoan class
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Number Of Months To Repay The Loan Saved Successfully!");
                    Console.BackgroundColor = ConsoleColor.Black;

                    LoadingSummary();
                    hml.CalMonthly(); // calls the CalMonthly() to calculate the monthly home loan repayment
                    hml.CalculateExpense(salary, populateArrays.sumArr(), taxAmount, hml.MonthlyAmount); // works out available amount after expense deductions
                    hml.BudgetReport(salary, taxAmount, populateArrays.DisplayExpense(), hml.MonthlyAmount, hml.availAmount); // displays budget report
                    EndOfProgram();
                }
            }
        }

        public void RentAccommodation()
        {
            // RentAccommodation() method asks users to enter their rental amount
            // and then saves the valid rental amount to the rental class
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("========================================================================");

            Console.WriteLine("Rental Accomodation");
            Console.WriteLine("========================================================================");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Please Enter The Rent Amount >>"); // asks user to enter rental amount
            double rentalAmount = 0;
            while (!double.TryParse(Console.ReadLine(), out rentalAmount)) // checks if they have entered a numeric value
            {
                ValidateData("Rent");
            }
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Rental Amount Saved Successfully!"); // saves rental amount if it is valid
            Console.BackgroundColor = ConsoleColor.Black;

            LoadingSummary();
            rental.CalculateExpense(salary, populateArrays.sumArr(), taxAmount, rentalAmount); // calculates available amount after expense deductions
            rental.BudgetReport(salary, taxAmount, populateArrays.DisplayExpense(), rentalAmount, rental.availAmount); // displays budget report
            EndOfProgram();
        }

        public void ExitApplication()
        {

            // asks users if they would like to exit the application

            Console.WriteLine("Are You Sure That You Want To Exit The Application? \n" +
                              "Press 1 To Exit Application \n" +
                              "Or 2 To Return To Main Menu.");
            bool bString = true; // boolean variable controls the while loop
            string menuItem = Console.ReadLine(); // reads user's input
            while (bString)
            {
                if (string.IsNullOrEmpty(menuItem) || !(menuItem.Equals("1") || menuItem.Equals("2")))
                {
                    // //if statement checks if the user has entered anything and if they did, it checks if the input is valid
                    bString = true;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Invalid Menu Item Selected.");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Are You Sure That You Want To Exit The Application? \n" +
                                      "Press 1 To Exit Application. \n " +
                                      "Or 2 To Return To Main Menu.");
                    menuItem = Console.ReadLine(); // asks user to re-enter rental amount if it is invalid
                }
                else
                { bString = false; } // terminates loop if input is found to be valif

                if (!bString) // what happens if the user enters a valid input
                {
                    switch (menuItem)
                    {
                        case "1": System.Environment.Exit(0); break; // terminates program
                        case "2": DisplayMenu(); break;  // displays main menu to user again
                    }
                }
            }

        }

        public void LoadingSummary()
        {
            // notifies user that their information has been saved and displays a timer to load the Budget Report
            Console.WriteLine("All Your Information Has Been Successfully Saved! \n" +
                              "Please Wait Patiently While We Generate Your Budget Report!");
            Console.WriteLine("Loading...");
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Time Left: " + i);
                Thread.Sleep(500);

            }
            Console.ForegroundColor = ConsoleColor.White;



        }


        static void ShowSpinner()
        {
            var counter = 0;
            Console.WriteLine("Initializing Program...");
            for (int i = 0; i < 20; i++) // controls the spinner cycle
            {
                switch (counter % 4)
                {
                    // spinner animations
                    case 0: Console.Write("/"); break;
                    case 1: Console.Write("-"); break;
                    case 2: Console.Write("\\"); break;
                    case 3: Console.Write("|"); break;
                }
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                counter++;
                Thread.Sleep(100); // speed of spinner
            }

            Console.Clear(); // clears spinner one loop is terminated
        }


        static void WelcomeAnimation()
        {

            //display simple animation and welcome message
            for (int i = 0; i < 6; i++) //outer loop
            {
                for (int j = 0; j < 2; j++) // inner loop
                {
                    Console.Clear(); // clears animation as they load

                    Console.Write("       . . . . o o o o o o", Console.ForegroundColor = ConsoleColor.Blue);
                    for (int s = 0; s < j / 2; s++) // loop to move animation
                    {
                        Console.Write(" o", ConsoleColor.Blue);
                    }
                    Console.WriteLine();

                    var margin = "".PadLeft(j);
                    Console.WriteLine(margin + "Welcome To The Budget Planner Application", ConsoleColor.Blue);


                    Thread.Sleep(100);
                }
            }

            Console.ForegroundColor = ConsoleColor.White;

        }

        public void EndOfProgram()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("========================================================================");

            Console.WriteLine("You've Reached The End Of The Budget Planner Application!");
            Console.WriteLine("========================================================================");

            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Please Select One Of The Folowwing Items: \n" +
                              "1. Return To Main Menu. \n" +
                              "2. Exit Application");

            bool bValidate = true; // boolean variable that controls the while loop
            string menuItem = Console.ReadLine(); // Variable that reads the user's input
            while (bValidate)
            {
                if (string.IsNullOrEmpty(menuItem) || !(menuItem.Equals("1") || menuItem.Equals("2")))
                {
                    //if statement checks if the user has entered anything and if they did, it checks if the input is valid
                    bValidate = true;

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Invalid Menu Item Selected");

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("Please Choose One Of The Following Items: \n" +
                                      "1. Return To Main Menu. \n" +
                                      "2. Exit Application.");

                    menuItem = Console.ReadLine(); // reads in user's input again since their entry was invalid
                }
                else
                {
                    bValidate = false; // breaks loop if the user's input is valid
                }

                if (!bValidate)  // controls what happens if the user enters a valid input
                {
                    switch (menuItem) // calls necessary methods based on user's input
                    {
                        case "1": populateArrays.arrExpenseName.Clear(); populateArrays.arrExpenseCost.Clear(); DisplayMenu(); break; // calls DisplayMenu() method
                        case "2": ExitApplication(); break; // calls ExitApplication() method
                    }
                }
            }


        }

    }
}




