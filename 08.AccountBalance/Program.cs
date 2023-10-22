//Write a program to calculate an account balance:

//· Read a sequence of incomes / expenses, until "End" is read

//· Add the money to the balance (starting form 0)

//· Print "Increase: {money} " or "Decrease: {money}", where value is formatted to the second decimal digit

//· Finally, print the account balance, formatted to the second decimal digit

//it initializes the balance to 0.
//It enters a loop that repeatedly asks the user for input (income/expense) until the user enters "End."
//Inside the loop, it checks if the input can be parsed into a double. If yes, it updates the balance, prints "Increase" for positive values, "Decrease" for negative values, and "No change" for zero values.
//If the input is not a valid number, it informs the user about the invalid input.
//Finally, it prints the account balance formatted to the second decimal digit.
//int money = int.Parse(Console.ReadLine());
String money = Console.ReadLine();
double balance = 0;

while (money !="End")
{
    double current = double.Parse(money);

    if (current > 0)
    {
        balance += current;
        Console.WriteLine($"Increase: {current:f2}");
    }
    else if (current < 0)
    {
        balance += current;
        Console.WriteLine($"Decrease: {Math.Abs(current):F2}");
    }
    money = Console.ReadLine();
}

Console.WriteLine($"Balance: {balance:f2}");







