// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] SortDownArray(int[,] array)
// The method sorts the values in rows in descending order

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        List<int> TempList = new List<int>(array.GetLength(1));
        for (int j = 0; j < array.GetLength(1); j++)
        {
            TempList.Add(array[i, j]);
        }
        TempList.Sort();
        TempList.Reverse();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = TempList[j];
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
    return array;
}

int[,] CurrentArray = FillArray();
Console.WriteLine($"\nОтсортированный массив:");
int[,] SortCurrentArray = SortDownArray(CurrentArray);