//Write a program to find statistics about division to 2, 3 and 4:

//· Read an integer number N and N integers from the console

//· Find in percentages how many of these integers can divide without a remainder to numbers 2, 3 and 4

//· Print the percentages, formatted to the second decimal digit:

//o On the first line print percent of the numbers that are divisible by 2

//o On the first line print percent of the numbers that are divisible by 3

//o On the first line print percent of the numbers that are divisible by 4

int countNumber = int.Parse(Console.ReadLine());
int number2 = 0;
int number3 = 0;
int number4 = 0;

for (int number = 0; number < countNumber; number++)
{
    int value = int.Parse(Console.ReadLine());
    if(value % 2 == 0)
    {
        number2++;
    }
    if (value % 3 == 0)
    {
        number3++;
    }
    if (value % 4 == 0)
    {
        number4++;
    }


}
double procent2 = number2 * 1.0/ countNumber * 100;
double procent3 = number3 * 1.0 / countNumber * 100;
double procent4 = number4 * 1.0 / countNumber * 100;
Console.WriteLine($"{procent2:f2}%");
Console.WriteLine($"{procent3:f2}%");
Console.WriteLine($"{procent4:f2}%");