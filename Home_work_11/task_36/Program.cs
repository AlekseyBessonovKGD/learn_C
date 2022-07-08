/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

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
int summ_odd_elements(int[] any_array)
{
    int summ = 0;
    for (int i = 0; i < any_array.Length; i++)
    {
        if(i % 2 > 0)
        {
            summ = summ + any_array[i];
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
int summ = summ_odd_elements(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях массива равна {summ}");