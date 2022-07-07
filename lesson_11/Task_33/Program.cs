/* Задача 32: Напишите программу замена элементов массива: положительные элементы 
замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
Задача 33: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да */

void fill_array(int[] new_array)
{
    for (int i = 0; i < new_array.Length; i++)
    {
        new_array[i] = new Random().Next(-100,100);
    }
}
void print_array(int[] new_array_for_print)
{
    Console.Write("[");
    for (int i = 0; i < new_array_for_print.Length; i++)
    {
        Console.Write($"{new_array_for_print[i]} ");
    }
    Console.Write("]");
}

void change_array(int[] array_for_change)
{
    for (int i = 0; i < array_for_change.Length; i++)
    {
        array_for_change[i] = array_for_change[i] * -1;
    }
}

int[] array = new int[6];
fill_array(array);
print_array(array);
Console.WriteLine();
change_array(array);
print_array(array);