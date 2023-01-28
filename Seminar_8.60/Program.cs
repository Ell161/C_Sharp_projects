// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


int[,,] FillArray()
// The method fills a three-dimensional array with non-repeating values

{
    int ArraySize = 2;
    List<int> ExcludedValues = new List<int>() {0};  

    int[,,] array = new int [ArraySize, ArraySize, ArraySize];
    for (int i = 0; i < ArraySize; i++)
    {
        for (int j = 0; j < ArraySize; j++)
        {
            for (int k = 0; k < ArraySize; k++)
            {
                while (ExcludedValues.Contains(array[i, j, k])) {array[i, j, k] = new Random().Next(10, 100);}
                Console.Write($"{array[i, j, k]}({i},{j},{k})  ");
            }
            Console.WriteLine();         
        }
        Console.WriteLine();
    }
    return array;   
}

int[,,] CurrentArray = FillArray();
