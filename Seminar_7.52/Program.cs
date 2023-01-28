// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


int[,] FillArray()
// The method creates an array of random numbers

{    
    int ArrayRow = new Random().Next(2, 15);
    int ArrayColumn = new Random().Next(2, 15);

    int[,] array = new int [ArrayRow, ArrayColumn];
    for (int i = 0; i < ArrayRow; i++)
    {
        for (int j = 0; j < ArrayColumn; j++)
        {
            array[i, j] = new Random().Next(1, 100);
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine(); 
    }
    return array;
}

Dictionary<int, double> GetAVGColumnsArray(int[,] array)
// the method determines the average values of each column in a two-dimensional array

{
    Dictionary<int, double> AVGValues = new Dictionary<int, double>();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0) AVGValues.Add(j, array[i, j]);
            else AVGValues[j] = AVGValues[j] + array[i, j];
        }      
    }
    foreach (var (key, value) in AVGValues) {AVGValues[key] /= array.GetLength(0);}   
    return AVGValues;   
}

int[,] CurrentArray = FillArray();
Dictionary<int, double> AVGColumnsCurrentArray = GetAVGColumnsArray(CurrentArray);
Console.WriteLine("Получены следующие значения:");
foreach (var (key, value) in AVGColumnsCurrentArray) {Console.WriteLine($"Среднее значение элементов в {key + 1}м столбце - {Math.Round(value, 2)}");}