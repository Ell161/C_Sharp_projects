List<int> numbers = new List<int>(3);
for (int i = 1; i < 4; i++)
{
    Console.Write($"Введите {i} число: ");
    numbers.Add(Convert.ToInt32(Console.ReadLine()));
}
int max = numbers[0];
for (int i = 1; i < 3; i++)
{
    if (numbers[i] > max) max = numbers[i];
}
Console.WriteLine("Максимальное число " + max);

