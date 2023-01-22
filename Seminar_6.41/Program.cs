// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


int CountPositiveNumbers(int LenghtList)
// The method counts the number of numbers greater than zero in the list

{
    int[] numbers = new int[LenghtList];
    int CountPNumbers = 0;
    for (int i = 0; i < LenghtList; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        try {numbers[i] = Convert.ToInt32(Console.ReadLine());}
        catch 
        {
            Console.Write("Некорректный ввод, введите целое число: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }        
        if (numbers[i] > 0) CountPNumbers++;
    }
    var str_array = string.Join(" ", numbers);
    Console.WriteLine($"Создан список чисел: {str_array}");
    return CountPNumbers;
}

Console.Write("Введите длину списка: ");
int LenghtUserList = Convert.ToInt32(Console.ReadLine());
int CountPNumbersUserList = CountPositiveNumbers(LenghtUserList);
Console.WriteLine($"Количество чисел больше нуля равно {CountPNumbersUserList}");