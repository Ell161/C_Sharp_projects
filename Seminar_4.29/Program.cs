// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int[] SetArray()
{
    int[] array = new int [8];

    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

int[] array1 = SetArray();
var str_array1 = string.Join(" ", array1);
Console.WriteLine(str_array1);