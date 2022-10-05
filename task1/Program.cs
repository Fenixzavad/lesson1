// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//     3 -> Среда 
// 5 -> Пятница

Console.WriteLine("Введите день недели:");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 1)
{
    Console.WriteLine($"1 -> понедельник");
}
if (day == 2)
{
    Console.WriteLine($"2 -> вторник");
}
if (day == 3)
{
    Console.WriteLine($"3 -> среда");
}
if (day == 4)
{
    Console.WriteLine($"4 -> четверг");
}
if (day == 5)
{
    Console.WriteLine($"5 -> пятница");
}
if (day == 6)
{
    Console.WriteLine($"6 -> суббота");
}
if (day == 7)
{
    Console.WriteLine($"7 -> воскресенье");
}
