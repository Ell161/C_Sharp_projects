// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int SumDigits(int number) 
{
    int sum_digits = 0;
    for (int i = 1; i <= number; i++)
    {
        sum_digits += i;
    }
    return sum_digits;
}


Console.Write("Введите число: ");
int cur_number = Convert.ToInt32(Console.ReadLine());

int result = SumDigits(cur_number);
Console.WriteLine($"Результат равен {result}");
