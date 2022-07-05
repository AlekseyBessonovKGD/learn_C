
void fill_array(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
}
void print_array(int[] arr_1)
{
    for (int i = 0; i < arr_1.Length; i++)
    {
        Console.Write($"{arr_1[i]} ");
    }
}
void sort_array(int[] arr_2)
{
    for (int i = 0; i < arr_2.Length - 1; i++)
    {
        int maximum_number = i;
        for (int j = i + 1; j < arr_2.Length; j++)
        {
            if (arr_2[j] > arr_2[maximum_number])
            {
                maximum_number = j;
            }
        }
        int hub = arr_2[i];
        arr_2[i] = arr_2[maximum_number];
        arr_2[maximum_number] = hub;
    }
}
int[] array = new int[15];
fill_array(array);
print_array(array);
Console.WriteLine();
sort_array(array);
print_array(array);