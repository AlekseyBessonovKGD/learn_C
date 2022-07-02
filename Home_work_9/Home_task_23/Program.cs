Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int cube_number = 0;

for (int i = 1; i <= number; i++)
{
    cube_number = Convert.ToInt32(Math.Pow(i, 3));
    if (i < number)
    {
        Console.Write($"{cube_number}, ");
    }
    else
    {
        Console.Write($"{cube_number}.");
    }
}