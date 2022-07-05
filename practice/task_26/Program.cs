/* Решение в группах задач:
Задача 26: Напишите программу, которая принимает на 
вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
 */
 Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;

for (int i = 0; number > 1; i++)
{
    count = count + 1;
    number = number / 10;
}
Console.WriteLine($"количество цифр в числе равно {count}");