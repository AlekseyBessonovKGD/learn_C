/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Задайте значения M и N, будет выведена сумма натуральных элементов в промежутке от M до N");
int numberM = Convert.ToInt32(Console.ReadLine());
int numberN = Convert.ToInt32(Console.ReadLine());

void naturalNumbers(int numberM, int numberN, int summ = 0)
{
    if (numberM > numberN)
    {
        Console.Write(summ);
    }
    else
    {
        naturalNumbers(numberM+1, numberN, summ +=numberM);
    }
}
Console.Write($"M = {numberM}; N = {numberN}. -> ");
naturalNumbers(numberM, numberN);
