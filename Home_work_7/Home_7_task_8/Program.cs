Console.WriteLine("введите число, будут показаны все четные числа в интервале от 1 до этого числа");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= number; i = i + 2)
{
    Console.Write($"{i},"); 
}