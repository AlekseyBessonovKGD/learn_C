Console.WriteLine("Введите два числа ");
int number_a = Convert.ToInt32(Console.ReadLine());
int number_b = Convert.ToInt32(Console.ReadLine());
if ( number_a * number_a == number_b)
{
    Console.WriteLine("да");
}
else if ( number_b * number_b == number_a)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}