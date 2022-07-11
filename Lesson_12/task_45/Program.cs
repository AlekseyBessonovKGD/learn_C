/* Задача 45: Напишите программу, которая будет 
создавать копию заданного массива с помощью поэлементного копирования.
 */

void fill_array(int[] new_array)
{
    for (int i = 0; i < new_array.Length; i++)
    {
        new_array[i] =new Random().Next(0,100);
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
int[] copy_array(int[] array_for_copy)
{
    int[] new_array = new int[array_for_copy.Length];
    int help_number = 0;
    for (int i = 0; i < array_for_copy.Length; i++)
    {
        help_number = array_for_copy[i];
        new_array[i] = array_for_copy[i];
    }
    return new_array;
}

int[] array = {1,2,3,4};
print_array(array);
int[] new_array = copy_array(array);
print_array(new_array);
array[0] = 2;
print_array(array);
