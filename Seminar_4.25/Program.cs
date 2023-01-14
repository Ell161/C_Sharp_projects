// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (без использования Math.Pow)

int MathPow(int number, int level) 
{
    int pow_number = number;
    for (int i = 2; i <= level; i++)
    {
        pow_number *=number;
    }
    return pow_number;
}


Console.Write("Введите число: ");
int cur_number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int cur_level = Convert.ToInt32(Console.ReadLine());

int result = MathPow(cur_number, cur_level);
Console.WriteLine($"Результат равен {result}");
