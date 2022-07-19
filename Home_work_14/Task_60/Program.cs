/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1) */

int[,,] array3d(int rows, int columns, int depth)
{
    int startBorder = 10;
    int endBorder = 13;
    int[,,] array = new int[rows,columns,depth];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = new Random().Next(startBorder,endBorder);
                startBorder +=3;
                endBorder +=3;
            }
        }
    }
    return array;
}

void printArray(int[,,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($" {array[i,j,k]}");
                Console.Write($"({i},{j},{k})");
            }
            Console.WriteLine();
        }
    }   
}

int[,,] array = array3d(3,3,3);
printArray(array);