Console.WriteLine("введите число для проверки его кратности одновременно 7 и 23");
int first_number = Convert.ToInt32(Console.ReadLine());
//int second_number = first_number;

if(first_number % 7 == 0)
{
    if(first_number % 23 == 0)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else 
{
    Console.WriteLine("нет");
}