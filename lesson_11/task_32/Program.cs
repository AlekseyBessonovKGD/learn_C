/* Задача 33: Задайте массив. Напишите программу, которая определяет, 
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
int[] array = new int[10];
fill_array(array);
print_array(array);
Console.WriteLine();
Console.WriteLine("Введите число для проверки его наличия в массиве");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
bool find_number = false;

for (int i = 0; i < array.Length; i++)
{
    int summ = 0;
    if(array[i] == number)
    {
        Console.WriteLine($" число {number} находится в заданном массиве под индексом {i}");
        find_number = true;
        break;
    }
}
if(!find_number)
{
    Console.WriteLine("нет");
}