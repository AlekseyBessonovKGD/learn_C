/* Задача 52. Задайте двумерный массив из целых чисел.
 Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3 */


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
double[] columnAverage(int[,] anyArray)
{
    double[] array = new double[anyArray.GetLength(1)];
    int k = 0;
    double average = 0;
    for (int i = 0; i < anyArray.GetLength(1); i++)
        {
             if(k < anyArray.GetLength(1))
             {
                for (int j = 0; j < anyArray.GetLength(0); j++)
                 {
                 average = anyArray[j,i] + average;
                 }
                array[k] = average / anyArray.GetLength(0);
                k+=1;
                average = 0;
             } 
        }
    return array;
}
void printAverage(double[] array_2)
{
    for (int i = 0; i < array_2.Length ; i++)
    {
        Console.Write($"{array_2[i]}");
        if(i < array_2.Length - 1)
        {
            Console.Write($" ; ");
        }
    }
}

Console.WriteLine($"введите количество строк в массиве");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"введите количество столбцов в массиве");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = fillRandomArray(rows,columns);
printArray(array);
double[] averageArray = columnAverage(array);
Console.Write("Среднее арифметическое каждого столбца: ");
printAverage(averageArray);