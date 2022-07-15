/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int[,] fillRandomArray(int rowsCount, int columnCount)
{
    int[,] result_array = new int[rowsCount,columnCount];
    for (int i = 0; i < rowsCount; i++)
    {
        for (int j = 0; j < columnCount; j++)
        {
            result_array[i,j] = new Random().Next(1,10);
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
            Console.Write($"{arrayForPrint[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[] findNumberArray(int[,] anyArray)
{
    int[] array = new int[anyArray.GetLength(0)*anyArray.GetLength(1)];
    int i = 0;
        for (int j = 0 ;j < anyArray.GetLength(0); j++)
        {
            for (int k = 0; k < anyArray.GetLength(1); k++)
            {
                array[i] = anyArray[j,k];
                i +=1;
            }
        }
    return array;
 }

Console.WriteLine("Введите положение элемента в двумерном массиве начиная с нулевого");
int position = Convert.ToInt32(Console.ReadLine());
int[,] array = fillRandomArray(3,4);
printArray(array);
Console.WriteLine();
int[] numberingArray = findNumberArray(array);
if(position < numberingArray.Length && position >=0)
{
    Console.WriteLine($"Число на позиции {position} равно: {numberingArray[position]}");
}
else
{
    Console.WriteLine($"{position} -> такого числа в массиве нет");
}