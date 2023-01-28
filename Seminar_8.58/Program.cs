// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


int[,] FillArray(int size)
// The method creates an array of random numbers

{    
    int[,] array = new int [size, size];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++) {array[i, j] = new Random().Next(1, 10);}
    }
    return array;
}

void PrintArray(int[,] array)
// The method print an array

{    
    for (int i = 0; i < array.GetLength(0); ++i)
    {
        for (int j = 0; j < array.GetLength(1); ++j) {Console.Write($"{array[i, j]}  ");}
        Console.WriteLine(); 
    }
}

int[,] DivArrays(int[,] array1, int[,] array2)
{
    var FinalArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); ++i)
                for (int j = 0; j < array2.GetLength(0); ++j)
                    for (int k = 0; k < array2.GetLength(0); ++k)
                        FinalArray[i, k] += array1[i, j] * array2[j, k];
    return FinalArray;
}

int ArraySize = new Random().Next(2, 10);
int[,] CurrentArray1 = FillArray(ArraySize);
Console.WriteLine("1-я матрица:");
PrintArray(CurrentArray1);
int[,] CurrentArray2 = FillArray(ArraySize);
Console.WriteLine("2-я матрица:");
PrintArray(CurrentArray1);
int[,] FinalArray = DivArrays(CurrentArray1, CurrentArray2);
Console.WriteLine("Итоговая матрица:");
PrintArray(FinalArray);