/* Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7 */

void FillVortexArray(int[,] array)
{
    int length = array.GetLength(0);
    int summ = 0;
    for (int i = 0; i < length; i++)
    {
        for (int j = i + 0; j < length - i - 1; j++)
        {
            summ = summ + 1;
            array[i, j] = summ;
        }
        for (int k = i + 0; k < length - i - 1; k++)
        {
            summ = summ + 1;
            array[k, length - i - 1] = summ;
        }
        for (int t = length - i; t > i; t--)
        {
            summ = summ + 1;
            array[length - 1 - i, t - 1] = summ;
        }
        for (int l = length - 1 - i; l > 1 + i; l--)
        {
            summ = summ + 1;
            array[l - 1, i] = summ;
        }
    }
}
void printArray(int[,] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayForPrint[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите величину стороны квадратного массива");
int side = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[side, side];
FillVortexArray(array);
printArray(array);