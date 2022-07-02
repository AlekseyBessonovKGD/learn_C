Console.WriteLine("Введите число для проверки");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
int number_minus_one_digit = number;
int number_length = number;
int numbers_of_matches = 0;

int digits_in_number(int argument)
{
    for (int i = 0; number_length >= 1; i++)
    {
        count = count + 1;
        number_length = number_length / 10;
    }
    return count;
}

void fill_array(int[] argument_array)
{
    for (int i = 0; i < count; i++)
    {
        argument_array[i] = number_minus_one_digit % 10;
        number_minus_one_digit = number / Convert.ToInt32(Math.Pow(10, (i + 1)));
    }
}

digits_in_number(number);
int[] array_of_number = new int[number];
fill_array(array_of_number);

for (int i = 0; i < digits_in_number(number) / 2; i++)
{
    int j = count - 1 - i;
    if (array_of_number[i] != array_of_number[j])
    {
        Console.WriteLine("нет");
        break;
    }
    numbers_of_matches = i + 1;
}

if (numbers_of_matches == digits_in_number(number) / 2)
{
    Console.WriteLine("да");
}

/*
Console.WriteLine("Введите число для проверки");
int number = Convert.ToInt32(Console.ReadLine());
int left_half_of_number = number;
int right_half_of_number = number;
int number_length = number;

 if (count % 2 == 0)
{
    int rised_number = 1;
    for (int i = 0; i < count / 2; i++)
    {
        rised_number = rised_number * 10;
    }
    left_half_of_number = left_half_of_number / rised_number;
    right_half_of_number = right_half_of_number % rised_number;
}
else
{
    int rised_number_odd = 1;
    for (int i = 0; i <= (count / 2); i++)
    {
        rised_number_odd = rised_number_odd * 10;
    }
    left_half_of_number = left_half_of_number / (rised_number_odd / 10);
    right_half_of_number = right_half_of_number % rised_number_odd;
} */
