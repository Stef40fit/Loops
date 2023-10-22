//Write a program to apply a 20% bonus for certain number:

//· Reads an integer number from the console: the "stop number"

//· Keep reading integers until it finds the stop number

//· When the stop number is found, increase the value of the previous number before it with 20% and print it

int stopNnumber = int.Parse(Console.ReadLine());
int nextNumber = stopNnumber;
while (true)
{
    int number = int.Parse(Console.ReadLine());
    if (number == stopNnumber)
    {
        Console.WriteLine(nextNumber * 1.2);
        break;
    }
    nextNumber = number;
}