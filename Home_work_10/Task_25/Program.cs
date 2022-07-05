/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.
 */

Console.WriteLine("Введите число:");
int number_a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа:");
int number_b = Convert.ToInt32(Console.ReadLine());
int number_in_power = number_a;

for (int i = 1; i < number_b; i++)
{
    number_in_power = number_in_power * number_a;
}
Console.WriteLine($"число {number_a} в степени {number_b} равно {number_in_power}");