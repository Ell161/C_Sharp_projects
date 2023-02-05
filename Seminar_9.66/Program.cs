// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int RecurseSum(int number1, int number2, int sum)
// The method calculates the sum of the natural numbers of the interval

{
    if (number1 == number2) return sum += number1;
    else if (number1 > number2) sum = number1 + RecurseSum (number1 - 1, number2, sum);
    else sum = number2 + RecurseSum (number1, number2 - 1, sum);
    return sum;
}

Console.WriteLine($"Введите 1-е натуральное число:");
int Number1;
try {Number1 = Convert.ToInt32(Console.ReadLine());}
catch 
{
    Console.Write($"Ошибка ввода.Введите натуральное число");
    Number1 = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Введите 2-е натуральное число:");
int Number2;
try {Number2 = Convert.ToInt32(Console.ReadLine());}
catch 
{
    Console.Write($"Ошибка ввода.Введите натуральное число");
    Number2 = Convert.ToInt32(Console.ReadLine());
}

int CurrentSum = 0;
int UserSum = RecurseSum(Number1, Number2, CurrentSum);
Console.Write($"сумма чисел заданного диапазона равноа {UserSum}");
