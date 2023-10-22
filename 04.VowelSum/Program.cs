//Write a program to sum N vowels, according to the table below:

//· Read an integer number N: the count of characters

//· Read N characters and for each vowel character adds its value from the table to the result

int countCharacters = int.Parse(Console.ReadLine());
int sumValue = 0;
for(int i = 1; i <= countCharacters; i++)
{
    char symbol = char.Parse(Console.ReadLine());
    switch (symbol)
    {
        case 'a':
            sumValue +=1;
            break;
        case 'e':
            sumValue += 2;
            break;
        case 'i':
            sumValue += 3;
            break;
        case 'o':
            sumValue += 4;
            break;
        case 'u':
            sumValue += 5;
            break;
    }
}
Console.WriteLine(sumValue);