// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве


int[] FillArray()
// The method creates an array of random three-digit numbers

{
    Console.WriteLine("Введите длину массива:");
    int LenghtArray = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    int[] array = new int [LenghtArray];

    for (int i = 0; i < LenghtArray; i++) {array[i] = new Random().Next(100, 1000);}

    var str_array = string.Join(" ", array);
    Console.WriteLine($"Создан массив:\n{str_array}");
    return array;
}

int CountEvenNumbers(int[] array)
// The method get count of even numbers

{
    int count = 0;

    foreach (int value in array) {if (value % 2 == 0) count++;}
    return count;
}

int[] UserArray = FillArray();
int CountEvenNumbersUA = CountEvenNumbers(UserArray);
Console.WriteLine($"Количество четных чисел в массиве {CountEvenNumbersUA}");
