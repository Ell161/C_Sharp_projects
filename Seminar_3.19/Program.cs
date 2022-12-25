// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
bool result = true;
int count_simbols = number.Length;


for (int i = 0; i <= (count_simbols / 2); i++)
{
    if (number[i] != number[count_simbols - i - 1]) 
    {
        result = false;
        Console.WriteLine("Число не является палиндромом");
        break;
    }
}

if (result) Console.WriteLine("Число является палиндромом");