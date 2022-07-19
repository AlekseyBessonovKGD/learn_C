/* Задача 55: Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. В случае, если это невозможно, 
программа должна вывести сообщение для пользователя.
 */

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

int[,] swapRowsColumns(int[,] array)
{
    int[,] resultArray = new int[array.GetLength(0),array.GetLength(1)];
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                resultArray[j,i] = array[i,j];
            }
        }
    }
    return resultArray; 
}


int[,] array = fillRandomArray(4,4);
if(array.GetLength(0) == array.GetLength(1))
{
    printArray(array);
    Console.WriteLine();
    int[,] reverseArray = swapRowsColumns(array);
    printArray(reverseArray);
}
else
{
    Console.WriteLine("Данное действие выполнить не возможно");
}