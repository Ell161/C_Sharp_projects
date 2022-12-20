// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите целое число: ");
string number = Console.ReadLine();

List<char> digits = new List<char> (number);
int count_digits = digits.Count;

if (count_digits < 3)
{
    Console.WriteLine("У заданного числа нет третьей цифры");
}
else
{
    Console.WriteLine($"Третья цифра заданного числа {digits[2]}");
}