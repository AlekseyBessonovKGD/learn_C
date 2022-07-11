/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
 */

Console.WriteLine("Введите число для преобразования в двоичную систему");
int number = Convert.ToInt32(Console.ReadLine());

int remains = 0;
string final_number = string.Empty;

for (int i = 0; number > 0; i++)
{
    remains = number % 2;
    number = number / 2;
    final_number = remains + final_number;
}
Console.WriteLine(final_number);
