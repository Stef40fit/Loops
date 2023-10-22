//String money = Console.ReadLine();
//double balance = 0;
//double current = 0;
//while (money != "End")
//{
//    current = double.Parse(money);
//    balance += current;
//    money = Console.ReadLine();

//}
//Console.WriteLine((current > 0) ? ($"Increase: {current:f2}") : ($"Decrease: {Math.Abs(current):F2}"));

//Console.WriteLine($"Balance: {balance:f2}");

String money = Console.ReadLine();
double balance = 0;

while (money != "End")
{
    double current = double.Parse(money);
    balance += current;
    Console.WriteLine((current > 0) ? ($"Increase: {current:f2}") : ($"Decrease: {Math.Abs(current):F2}"));
    money = Console.ReadLine();
}
Console.WriteLine($"Balance: {balance:f2}");
