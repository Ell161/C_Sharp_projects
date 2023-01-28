// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


void FillArray()
// The method creates an array of random numbers

{    
    int ArrayRow;
    int ArrayColumn;
    Console.WriteLine("Введите количество строк в массиве:");
    try {ArrayRow = Math.Abs(Convert.ToInt32(Console.ReadLine()));}
    catch
    {
        Console.WriteLine("Некорреткный ввод. Введите количество строк в массиве:");
        ArrayRow = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    }
    Console.WriteLine("Введите количество столбцов в массиве:");
    try {ArrayColumn = Math.Abs(Convert.ToInt32(Console.ReadLine()));}
    catch
    {
        Console.WriteLine("Некорреткный ввод. Введите количество столбцов в массиве:");
        ArrayColumn = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    }

    double[,] array = new double [ArrayRow, ArrayColumn];
    for (int i = 0; i < ArrayRow; i++)
    {
        for (int j = 0; j < ArrayColumn; j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(1, 100), 2);
            Console.Write($"{String.Format("{0:.00}", array[i, j])}  ");
        }
        Console.WriteLine();
        
    }
}

FillArray();
