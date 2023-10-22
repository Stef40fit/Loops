//Write a program to find the biggest among given n numbers:

//· Read an integer number n (the amount of input numbers) and n integer numbers from the console

//· Find and print the biggest number



int countNumber = int.Parse(Console.ReadLine());
int maxNumber = int.MinValue; 
for(int number = 1; number <= countNumber; number++)
{
    int value = int.Parse(Console.ReadLine());
    if(value > maxNumber)
    {
        maxNumber = value;
    }

}
Console.WriteLine(maxNumber);


