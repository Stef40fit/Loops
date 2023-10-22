//Write a program that prints a multiplication table:

//· Reads an integer number n from the console

//· Print a multiplication table of size 10 for given integer n in the following format:

//"{n} x {i} = {result}" for each i in the range[1…10]

int n = int.Parse(Console.ReadLine());
int result = 0;
int i = 0;
while (i <10)
{
    i++;
    result = n * i;
   
    Console.WriteLine($"{n} x {i} = {result}");
}
