# ST10084788_PROG6221_POE_Part_1
PROG6221 POE PART 1- Console Budget App


Introduction
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
In part 1 of the PROG6221 POE, we have been tasked to develop a budget planner application. The budget planner application will require the users salary, tax amount, and expenses - 
the application will then calculate the user's monthly available amount after all expense deductions. The budget planner application starts off by asking users to input their gross salary
and estimated tax amount. It then proceeds to ask the user to enter the estimated amounts that they would spend on the basic expenses such as groceries, lights annd water, travel costs, 
and phone billing costs. The user also has an option to select if they would like to rent an accomodation or buy a property. If the user selects the rent option, they would then be asked to 
input the rental amount. If the user selects the option to buy a property, they would be directed to a home loan calculator, which would then ask the user to input the necessary details, 
and then calculate the monthly home loan repayment amount- the program would also notify the user if the home loan is unlikely to be approved. 

Data required for program
The user would have to input the following data:
-Gross salary before deductions
-Estimated tax amount 
-Estimated expenditure on basic expenses (groceries, lights and water, travel costs, phone billing)
-If the user chooses to rent a property, they will be required to provide the rental amount 
-If the user chooses to buy a property, they will be required to provide the purchase price of the property, the total deposit paid, the interest rate, and months to repay home loan.

The program will then output the following data:
- Gross salary
- Salary after tax deduction
- Expenditure on basic expenses (groceries, lights and water, travel costs, phone billing)
- Other expenses that the user may have
- Rental fee
- Monthly home loan repayment fee
- The available balance after all deductions have been made

Software Specifications
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
- Visual Studio 2022 Version 17.1.0
(No additional plug-ins were used) 

- The program is built on a console app (.NET Framework 4.7.2.)


Frequently Asked Question (FAQ)
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
1. Why won't they program allow me to enter an expenditure value with a full stop (Example: 10.3)?

Answer: Throughout the program, you are only allowed to enter a decimal value with a comma (Example: 10,3). The use of full stops in a decimal value does not work for the program. 

2. For my tax amount, should I enter it as the tax percentage or the actual tax amount that is deducted from my salary?
Answer: With regards to the tax amount, please enter the estimated the tax amount that is deducted from your salary, do not enter the tax percentage- the program works with the actaul
tax  amount. 

3. How many many additional expenses can I add?
Answer: You may add as many additional expenses as you would like to. 

4. For the monthly home loan repayment calculator, is there only two possible options for the months?
Answer: Yes, you will either have to select 240 months or 360 months. 

5. What does the monthly available amount mean? 
Answer: The monthly available amount is your remaining balance of your salary after all your expenses deductions (tax amount, basic expenses, additional expenses, rent/monthly home loan
repayment).

6. Does the program only calculate one budget report every time it is executeed?
Answer: No, after you have completed a budget report, you will be presented with the option to return to the main menu or exit the application, you can then select the main menu option
and work on a different budget plan


Code Attribution
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
1. dotnet-bot (n.d.). Double.TryParse Method (System). [online] docs.microsoft.com. Available at: https://docs.microsoft.com/en-us/dotnet/api/system.double.tryparse?view=net-6.0 [Accessed 13 May 2022].
2. dotnet-bot (n.d.). Timer Class (System.Timers). [online] docs.microsoft.com. Available at: https://docs.microsoft.com/en-us/dotnet/api/system.timers.timer?redirectedfrom=MSDN&view=net-6.0 [Accessed 13 May 2022].
3. www.c-sharpcorner.com. (n.d.). ArrayList in C#. [online] Available at: https://www.c-sharpcorner.com/UploadFile/3d39b4/arraylist-in-C-Sharp/ [Accessed 13 May 2022].
4. www.informit.com. (n.d.). Basic Error Handling with Exceptions | C# Methods and Parameters | InformIT. [online] Available at: https://www.informit.com/articles/article.aspx?p=2923212&seqNum=9.

Developer Information
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
My name is Shivani Naidu, I am in my second year of study at Varsity College- studying the Bachelor of Computer and Information Science in Application Development.
I enjoy solving problems and thinking out of the box. If I'm not in front of my computer, I'm either sleeping or bingeing Netflix. 


Student Contact Information
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Student email: ST10084788@vcconnect.edu.za



