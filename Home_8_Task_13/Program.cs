Console.WriteLine("Введите число");
int any_number = Convert.ToInt32(Console.ReadLine());
any_number = Math.Abs(any_number);
if (any_number < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    int convert_to_three_digit_number = any_number;
    int third_digit_of_number = 0;
    for (int i = 1; convert_to_three_digit_number > 999; i = i + 1)
    {
        convert_to_three_digit_number = convert_to_three_digit_number / 10;
    }
    third_digit_of_number = convert_to_three_digit_number % 10;
    Console.WriteLine($"третья цифра числа равна {third_digit_of_number}");
}