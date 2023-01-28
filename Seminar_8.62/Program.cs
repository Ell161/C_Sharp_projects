// Напишите программу, которая заполнит спирально массив 4 на 4.


int[,] FillSpireArray(int size)
// The method fills the array in a spiral

{    
    int[,] array = new int [size, size];
    int start = 1;

    for (int y = 0; y < size; y++) 
    {
        array[0, y] = start;
        start++;
    }
    for (int x = 1; x < size; x++) 
    {
        array[x, size - 1] = start;
        start++;
    }
    for (int y = size - 2; y >= 0; y--) 
    {
        array[size - 1, y] = start;
        start++;
    }
    for (int x = size - 2; x > 0; x--) 
    {
        array[x, 0] = start;
        start++;
    }
    int c = 1;
    int d = 1;
    while (start < size * size) 
    {
        while (array[c, d + 1] == 0) 
        {
            array[c, d] = start;
            start++;
            d++;
        }
        while (array[c + 1, d] == 0) 
        {
            array[c, d] = start;
            start++;
            c++;
        }
        while (array[c, d - 1] == 0) 
        {
            array[c, d] = start;
            start++;
            d--;
        }
         while (array[c - 1, d] == 0) 
         {
            array[c, d] = start;
            start++;
            c--;
        }
    }
    for (int x = 0; x < size; x++) 
    {
        for (int y = 0; y < size; y++) 
        {
            if (array[x, y] == 0) {array[x, y] = start;}
        }
    }
    return array;
}

void PrintArray(int[,] array)
// The method print an array

{    
    for (int i = 0; i < array.GetLength(0); ++i)
    {
        for (int j = 0; j < array.GetLength(1); ++j) {Console.Write(" {0:d2}", array[i, j]);}
        Console.WriteLine(); 
    }
}

int ArraySize = new Random().Next(3, 10);
int[,] CurrentArray = FillSpireArray(ArraySize);
PrintArray(CurrentArray);
