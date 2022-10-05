// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да

Console.WriteLine("ВВедите число 1:");
int value1 = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("ВВедите число 2:");
int value2 = int.Parse(Console.ReadLine()?? "0");
if (value1 == value2*value2)
{
    Console.WriteLine($"Число (value1) является квадратом (value2)");
}
else if (value2 == value1*value1)
{
   Console.WriteLine($"Число (value2) является квадратом (value1)"); 
}
else 
{
    Console.WriteLine($"Числа не являются квадратами");
}