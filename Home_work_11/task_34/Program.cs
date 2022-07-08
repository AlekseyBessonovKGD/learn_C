/* Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

void fill_array(int[] new_array)
{
    for (int i = 0; i < new_array.Length; i++)
    {
        new_array[i] = new Random().Next(100,1000);
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
int even_elements(int[] any_array)
{
    int summ = 0;
    for (int i = 0; i < any_array.Length; i++)
    {
        if(any_array[i] % 2 == 0)
        {
            summ += 1;
        }
    }
    return summ;
}
Console.WriteLine("Введите количество элементов массива");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
fill_array(array);
print_array(array);
Console.WriteLine();
int summ_of_even = even_elements(array);
Console.WriteLine($"Количество четных чисел в массиве равно {summ_of_even}");