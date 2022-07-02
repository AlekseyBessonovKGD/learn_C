// метод (функция) 
/* int max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result)
    {
        result = arg2;
    }
    if (arg3 > result)
    {
        result = arg3;
    }
    return result;
}
 */
//int[] array = {12,212,3,4,53,6,47,8,91};
//обращение к элементу массиву array[0] = 11
// количество элементов int n = array.Length
// перебор элементов массива
// while(index <n){
    //действие;
    //index = index + 1;
//}
// break - прерывает программу
void FillArray(int[] numbers)
{
    int length = numbers.Length;
    int index = 0;
    while(index < length)
    {
        numbers[index] = new Random().Next(1,10);
        index++;
    }
}
void PrintArray(int[] num)
{
    int count = num.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(num[position]);
        position++;
    }
}

int indexOf(int[] numbers, int find)
{
    int count = numbers.Length;
    int index = 0;
    int position = 0;

    while(index< count)
    {
        if (numbers[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10]; //новый массив с 10 элементами - 0ми

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = indexOf(array, 4);
Console.WriteLine(pos);
