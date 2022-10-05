// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("ВВедите число");
int value = Convert.ToInt32(Console.ReadLine());
int count = -value;

while (count <= value)
{
    Console.WriteLine(count);
    count = count+1;
}
