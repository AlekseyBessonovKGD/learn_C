System.Console.WriteLine("Введите цифру соответствующую дню недели");
int day_of_week = Convert.ToInt32(Console.ReadLine());
if (day_of_week < 1 || day_of_week > 7)
{
    System.Console.WriteLine("Введенное число не соответствует ни одному дню недели попробуйте снова");
}
else if (day_of_week >= 1 && day_of_week <= 5)
{
    System.Console.WriteLine("нет, это будний день");
}
else
{
    System.Console.WriteLine("да, это выходной день");
}