/* Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки двумерного массива
например задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге полусается массив:
1 2 4 7
2 3 5 9
2 4 4 8 */

int[,] fillRandomArray(int rowsCount, int columnCount)
{
    int[,] result_array = new int[rowsCount, columnCount];
    for (int i = 0; i < rowsCount; i++)
    {
        for (int j = 0; j < columnCount; j++)
        {
            result_array[i, j] = new Random().Next(1, 10);
        }
    }
    return result_array;
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
void arrangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int minIndex = j;
            for (int k = 1 + j; k < array.GetLength(1); k++)
            {
                if (array[i, k] < array[i, minIndex])
                {
                    minIndex = k;
                }
            }
            int hub = array[i, j];
            array[i, j] = array[i, minIndex];
            array[i, minIndex] = hub;
        }
    }
}

int[,] array = fillRandomArray(4, 5);
printArray(array);
Console.WriteLine();
arrangeArray(array);
printArray(array);