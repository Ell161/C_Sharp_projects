// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int[,] FillArray()
// The method creates an array of random numbers

{    
    int ArrayRow = 0;
    int ArrayColumn = 0;
    while (ArrayRow == ArrayColumn)
    {
        ArrayRow = new Random().Next(2, 15);
        ArrayColumn = new Random().Next(2, 15);
    }

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

(int, int) MinSumRowArray(int[,] array)
// The method finds the minimum sum of row values and returns the index of this row

{
    List<int> MinSumRowList = new List<int>();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int SumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++) SumRow += array[i, j];
        MinSumRowList.Add(SumRow);
    }
    int MinSumRow = MinSumRowList.Min();
    int indexMinSum = MinSumRowList.IndexOf(MinSumRow);
    return (MinSumRow, indexMinSum);
}

int[,] CurrentArray = FillArray();
(int, int) MinSumRowCurrentArray = MinSumRowArray(CurrentArray);
Console.WriteLine($"Минимальная сумма значений строки равна {MinSumRowCurrentArray.Item1} находится в {MinSumRowCurrentArray.Item2 + 1} строке");
