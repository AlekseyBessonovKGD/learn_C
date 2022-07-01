int[] array = new int[20];
/* for(int index = 1; index < array.Length; index++)
{
    array[index] = new Random().Next(1,10);
    System.Console.Write($"{array[index]},");
} */

void fillArray(int[] array)
{
    for(int index = 1; index < array.Length; index++)
    {
        array[index] = new Random().Next(1,10);
    }
}
void print_array(int[] array_1)
{
    for(int ind = 1; ind < array.Length; ind++)
    {
        System.Console.Write($"{array[ind]},");
    }
}
fillArray(array);
print_array(array);