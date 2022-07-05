/* Задача 27: Напишите программу, которая принимает на 
вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int summ_of_numbers(int any_number)
{
    int part_of_number = 0;
    int summ = 0;
    for (int i = 0; any_number > 0; i++)
    {
        part_of_number = any_number % 10;
        any_number = any_number / 10;
        summ = summ + part_of_number;
    }
    return summ;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int total_summ = summ_of_numbers(number);
Console.WriteLine($"Сумма цифр в числе {number} равна {total_summ}");