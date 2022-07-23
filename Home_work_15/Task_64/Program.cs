/* Задача 64: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8"" */
Console.WriteLine("Задайте значения M и N, будут выведены все натуральные числа в промежутке от M до N");
int numberM = Convert.ToInt32(Console.ReadLine());
int numberN = Convert.ToInt32(Console.ReadLine());

void naturalNumbers(int numberM, int numberN)
{
    if (numberM == numberN)
    {
        Console.Write(numberN);
    }
    else
    {
        Console.Write($"{numberM}, ");
        naturalNumbers(numberM + 1, numberN);
    }
}
Console.Write($"M = {numberM}; N = {numberN}. -> '");
naturalNumbers(numberM, numberN);
