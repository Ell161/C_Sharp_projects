// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void NumbersOutput (int number)
// the method outputs all natural numbers in the range from N to 1

{
    if (number < 0) Console.Write("Вывод заданного диапазона чисел невозможен");
    else if (number == 0) return;
    else
    {
        Console.Write(number + " ");
        NumbersOutput (number - 1);
    } 
}

Console.WriteLine("Введите натуральное число больше 1:");
int CurrentNumber;
try {CurrentNumber = Convert.ToInt32(Console.ReadLine());}
catch 
{
    Console.Write($"Ошибка ввода.Введите натуральное число");
    CurrentNumber = Convert.ToInt32(Console.ReadLine());
}
NumbersOutput(CurrentNumber);
