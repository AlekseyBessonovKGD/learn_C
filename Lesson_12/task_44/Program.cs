/* Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
 */

int number_a = -1;
int number_b = 1;
int number_c = 0;
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"Если N = {N} -> ");
for (int i = 0; i < N; i++)
{
    number_c = number_b + number_a;
    number_a = number_b;
    number_b = number_c;
    Console.Write(number_c);
    Console.Write(" ");
}
