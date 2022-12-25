// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N


Console.Write("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    Console.WriteLine($"Куб числа {i} = {Math.Pow(i, 3)}");
}
