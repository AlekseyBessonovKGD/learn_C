/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Console.WriteLine("Введите последовательно несколько чисел через запятую");
string text_number = Console.ReadLine();

string converted_text(string text, char old_char, string Empty) 
{
    string remoove_simbols_from_text = string.Empty;
    for (int i = 0; i < text.Length; i++)
    {
        if(text[i] == old_char) 
        {
            remoove_simbols_from_text = remoove_simbols_from_text + $"{Empty}";
        }
        else
          remoove_simbols_from_text = remoove_simbols_from_text + $"{text[i]}";
    }
    return remoove_simbols_from_text;
}

int count_of_positive_numbers(int[] digital_array)
{
    int count = 0;
    for (int i = 0; i < digital_array.Length; i++)
    {
        if (digital_array[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}

string text_without_spaces = converted_text(text_number, ' ', string.Empty);
int[] digital_array = text_without_spaces.Split(',').Select(int.Parse).ToArray();
int count_of_plus_numbers = count_of_positive_numbers(digital_array);

if (count_of_plus_numbers == 1)
{
    Console.WriteLine($"вы ввели {count_of_plus_numbers} число больше 0");
}
else if (count_of_plus_numbers > 1 && count_of_plus_numbers < 5)
{
    Console.WriteLine($"вы ввели {count_of_plus_numbers} числа больше 0");
}
else if (count_of_plus_numbers == 0 || count_of_plus_numbers > 4)
{
    Console.WriteLine($"вы ввели {count_of_plus_numbers} чисел больше 0");
}