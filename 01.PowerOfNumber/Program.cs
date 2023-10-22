//Write a program to calculate number raising to a certain power:

//· Reads an integer number n from the console

//· Reads an integer number p which represents power from the console

//· Print the result of n to the power of p

//Note: Don't use Math.Pow(), use loops

int n = int.Parse(Console.ReadLine());
int p = int.Parse(Console.ReadLine());
int count = 0;
int np = 1;

while (count < p)
{
    np = np * n;
    count++;
}
Console.WriteLine(np);