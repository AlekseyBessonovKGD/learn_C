/* Задача 38: Задайте массив вещественных чисел.
 Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

void fill_array(double[] new_array)
{
    for (int i = 0; i < new_array.Length; i++)
    {
        new_array[i] = Math.Round(new Random().NextDouble(), 2);
    }
}
void print_array(double[] new_array_for_print)
{
    Console.Write("[");
    for (int i = 0; i < new_array_for_print.Length; i++)
    {
        Console.Write($"{new_array_for_print[i]} ");
    }
    Console.Write("]");
}
double find_differ(double[] array_for_differ)
{
    double min = 1;
    double max = 0;
    double diff = 0;
for (int i = 0; i < array_for_differ.Length; i++)
{
    if(array_for_differ[i] > max)
        {
            max = array_for_differ[i];
        }
    if(array_for_differ[i] < min)
        {
            min = array_for_differ[i];
        }
}
    diff = Math.Round(max - min, 2);
    return diff;
}
Console.WriteLine("Введите количество элементов массива");
int number = Convert.ToInt32(Console.ReadLine());
double[] array = new double[number];
fill_array(array);
print_array(array);
Console.WriteLine();
double diff = find_differ(array);
Console.WriteLine($"Разность между максимальным и минимальным элементами массива равна {diff}");

