// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Ввведите трехзначное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit_2 = number / 10 % 10;
Console.WriteLine($"Вторая цифра заданного числа - {digit_2}");
