/* Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */
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
Console.WriteLine("Введите количество элементов массива");
var number = Convert.ToDouble(Console.ReadLine());

double array_length = number/2;
int final_array_length = Convert.ToInt32(Math.Ceiling(array_length));

int[] array = new int[Convert.ToInt32(number)];
fill_array(array);
print_array(array);
int[]   final_array = new int[final_array_length];
if(number % 2 == 0)
{
    for (int i = 0; i < final_array.Length; i++)
    {
       final_array[i] = array[i] * array[array.Length-i-1];
    }
}
else
{
    for (int i = 0; i < final_array.Length; i++)
    {
       final_array[i] = array[i] * array[array.Length-i-1];
    }
    final_array[final_array.Length-1] = array[final_array_length-1];
}
Console.WriteLine();
print_array(final_array);


/* int array_new(int[] array)
{
    int[] any_new_array = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        any_new_array[i] = array[i] * 10;
    }
    return  any_new_array;
} */