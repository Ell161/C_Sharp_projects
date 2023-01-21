// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


int[] FillArray()
// The method creates an array of random numbers

{
    Console.WriteLine("Введите длину массива:");
    int LenghtArray = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    int[] array = new int [LenghtArray];

    for (int i = 0; i < LenghtArray; i++) {array[i] = new Random().Next(1, 1000);}

    var str_array = string.Join(" ", array);
    Console.WriteLine($"Создан массив:\n{str_array}");
    return array;
}

int SumOddNumbers(int[] array)
// The method finds the sum of elements standing in odd positions

{
    int SumNumbers = 0;

    for (int i = 0; i < array.Length; i++) {if (i % 2 == 1) SumNumbers += array[i];}
    return SumNumbers;
}

int[] UserArray = FillArray();
int SumNumbersUA = SumOddNumbers(UserArray);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {SumNumbersUA}");


