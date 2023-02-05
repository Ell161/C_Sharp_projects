// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


int AckermannFunction (int number1, int number2)
// The method calculates the Ackerman function

{
    if (number1 == 0) return number2 + 1;
    if ((number1 != 0) && (number2 == 0)) return AckermannFunction(number1 - 1, 1);
    else return AckermannFunction(number1 - 1, AckermannFunction(number1, number2 - 1));
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

Console.WriteLine($"Функция Аккермана A({Number1},{Number2}) = {AckermannFunction(Number1, Number2)}");