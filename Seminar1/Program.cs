Console.Write("Введите первое число: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number_2 = Convert.ToInt32(Console.ReadLine());
if (number_1 > number_2)
    Console.WriteLine("Наибольшее из чисел первое " + number_1);
else if (number_1 < number_2)
    Console.WriteLine("Наибольшее из чисел второе " + number_2);
else
    Console.WriteLine("Числа равны");

