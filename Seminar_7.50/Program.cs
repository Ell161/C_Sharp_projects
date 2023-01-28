// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


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
            Console.Write($"{String.Format("{0:.00}", array[i, j])}  ");
        }
        Console.WriteLine(); 
    }
    return array;
}

int? GetPositionArray(int[,] array)
// the method outputs the array position at the specified index

{
    int RowIndex;
    int ColumnIndex;

    Console.WriteLine("Введите номер индекса в ряду:");
    try {RowIndex = Convert.ToInt32(Console.ReadLine());}
    catch 
    {
        Console.WriteLine("Некорректный ввод. Введите номер индекса в ряду:");
        RowIndex = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Введите номер индекса в столбце:");
    try {ColumnIndex = Convert.ToInt32(Console.ReadLine());}
    catch 
    {
        Console.WriteLine("Некорректный ввод. Введите номер индекса в столбце:");
        ColumnIndex = Convert.ToInt32(Console.ReadLine());
    }

    int element;
    try {element = array[RowIndex, ColumnIndex];}  
    catch {return null;} 
    return element;
}

int[,] CurrentArray = FillArray();
int? CurrentElement = GetPositionArray(CurrentArray);
if (CurrentElement != null) Console.WriteLine($"Значение элемента массива {CurrentElement}");
else Console.WriteLine("Такого числа в массиве нет");