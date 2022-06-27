Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if(number >= 100 && number <=999)
{
    int result = ((number - (number % 10)) % 100) / 10;
    Console.WriteLine($"вторая цифра числа равна {result}");
}
else if(number <= -100 && number >= -999)
{
    int result = (((number - (number % 10)) % 100) / 10) * -1;
    Console.WriteLine($"вторая цифра числа равна {result}");
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число, попробуйте снова");
}