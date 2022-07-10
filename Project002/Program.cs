Console.Write("Введите первое число ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_1 == number_2 * number_2)
{
    Console.WriteLine("Число " + number_2 + " является квадратом числа " + number_1);
}
else
{
    Console.WriteLine("Число " + number_2 + " не является квадратом числа " + number_1);
}