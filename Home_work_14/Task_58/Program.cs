/* Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49 */
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
int[,] multiplicationMatrix(int[,] matrixFirst, int[,] matrixSecond)
{
    int[,] matrix = new int[matrixFirst.GetLength(0), matrixSecond.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrixSecond.GetLength(0); k++)
            {
                matrix[i, j] += matrixFirst[i, k] * matrixSecond[k, j];
            }

        }
    }

    return matrix;
}

int[,] matrixA = fillRandomArray(3, 3);
int[,] matrixB = fillRandomArray(3, 3);
printArray(matrixA);
Console.WriteLine();
printArray(matrixB);
Console.WriteLine();
if (matrixA.GetLength(1) != matrixB.GetLength(0))
{
    Console.WriteLine("Умножение данных матриц не возможно");
}
else
{
    int[,] multiplicationResult = multiplicationMatrix(matrixA, matrixB);
    printArray(multiplicationResult);
}