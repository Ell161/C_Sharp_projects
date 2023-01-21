// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] FillArray()
// The method creates an array of random numbers

{
    Console.WriteLine("Введите длину массива:");
    int LenghtArray = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    double[] array = new double [LenghtArray];
    for (int i = 0; i < LenghtArray; i++) array[i] = Math.Round(new Random().NextDouble() + new Random().Next(1, 10), 2);
    var str_array = string.Join(" ", array);
    Console.WriteLine($"Создан массив:\n{str_array}");
    return array;
}

double DifferenceMinMaxArray(double[] array)
// The method finds the difference between the maximum and minimum element of the array

{
    double MinArray = array[0];
    double MaxArray = array[0];

    for (int i = 1; i < array.Length; i++) 
    {
        if (array[i] > MaxArray) {MaxArray = array[i];}
        if (array[i] < MinArray) {MinArray = array[i];}
    }

    double DifferenceMinMax = Math.Abs(MaxArray - MinArray);
    return DifferenceMinMax;
}

double[] UserArray = FillArray();
double DifferenceMinMaxUserArray = DifferenceMinMaxArray(UserArray);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна {DifferenceMinMaxUserArray}");


