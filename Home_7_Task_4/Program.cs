Console.WriteLine("Введите три числа ");
int number_a = Convert.ToInt32(Console.ReadLine());
int number_b = Convert.ToInt32(Console.ReadLine());
int number_c = Convert.ToInt32(Console.ReadLine());

int max = number_a;

if (max < number_b) max = number_b;
if (max < number_c) max = number_c;

Console.WriteLine($"максимальное число из трех равно {max}");