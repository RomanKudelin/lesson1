
// // ЗАДАЧА № 1
// int a = 322;
// {
//     if (a % 7 == 0 && a % 23 == 0)

//     {
//         Console.WriteLine("да");
//     }
//     else
//     {
//         Console.WriteLine("нет");
//     }
// }

// // ЗАДАЧА № 2

// int x = 4 , y = -2;
// {
//     if (x > 0 && y > 0)
//     Console.WriteLine("1");
//     if (x < 0 && y > 0)
//     Console.WriteLine("2");
//     if (x < 0 && y < 0)
//     Console.WriteLine("3");
//     if (x > 0 && y < 0)
//     Console.WriteLine("4");
// }

// ЗАДАЧА № 3

// {
// Console.Write("Введите число из отрезка [10, 99]: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int firstDigit = number / 10;
// int secondDigit = number % 10;
// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;Console.WriteLine(maxDigit);
// }


using System;
class Program
{
static void Main()
{
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 10)
{
Console.WriteLine(N);
}
else
{
while (N > 0)
{
int currentDigit = N % 10;
N /= 10;
if (N > 0)
{
Console.Write(currentDigit + ",");
}
else
{
Console.WriteLine(currentDigit);
}
}
}
}
}