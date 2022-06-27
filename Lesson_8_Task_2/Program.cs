Console.WriteLine("введите два числа для проверки кратности");
int first_number = Convert.ToInt32(Console.ReadLine());
int second_number = Convert.ToInt32(Console.ReadLine());
int result = (first_number % second_number);
if(first_number % second_number > 0)
{
    Console.WriteLine($"не кратно, остаток от деления {result}");
}
else 
{
    Console.WriteLine("первое число кратно второму");
}