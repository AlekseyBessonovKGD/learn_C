/* Задача 35: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */

void fill_array(int[] new_array)
{
    for (int i = 0; i < new_array.Length; i++)
    {
        new_array[i] = new Random().Next(-1000,1000);
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
int[] array = new int[123];
fill_array(array);
print_array(array);
Console.WriteLine();
int summ = 0;

for (int i = 0; i < array.Length; i++)
{
    if( array[i] > 9 && array[i] < 100)
    {
        summ += 1;
    }
}
Console.WriteLine($"Количество элементов массива в диапазоне [10,99] равно {summ}");