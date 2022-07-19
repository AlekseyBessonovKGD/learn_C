/* Задайте прямоугольный двумерный массив.
Напишите программу которая будет находить строку
с наименьшей суммой элементов
Например:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдает 
номер строки с наименьшей суммой элементов: 1 строка */

int[,] fillRandomSquaerArray(int rowsCount)
{
    int[,] result_array = new int[rowsCount, rowsCount];
    for (int i = 0; i < rowsCount; i++)
    {
        for (int j = 0; j < rowsCount; j++)
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
int[] rowsSummArray(int[,] array)
{
    int[] resultArray = new int[array.GetLength(0)];
    int summ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            summ = array[i, j] + summ;
        }
        resultArray[i] = summ;
        summ = 0;
    }
    return resultArray;
}
int minIndex(int[] array)
{
    int result = array[0];
    int minIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < result)
        {
            result = array[i];
            minIndex = i;
        }
    }
    return minIndex + 1;
}
int[,] array = fillRandomSquaerArray(4);
printArray(array);
Console.WriteLine();
int[] summOfRowsArray = rowsSummArray(array);
int indexMinSumm = minIndex(summOfRowsArray);
Console.WriteLine($"номер строки с наименьшей суммой элементов: {indexMinSumm}");