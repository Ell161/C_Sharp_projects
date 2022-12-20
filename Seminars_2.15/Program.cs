// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Ввведите день недели цифрой: ");
int number = Convert.ToInt32(Console.ReadLine());

if (1 <= number & number < 6)
{
    Console.WriteLine("Этот день недели не выходной!");
}
else if (6 <= number & number <= 7)
{
    Console.WriteLine("Это выходной!");
}
else
{
    Console.WriteLine("Вы ввели неверное число");
}
