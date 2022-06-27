int number = new Random().Next(100, 999);
Console.WriteLine(number);
int first_number = (number / 100) * 10;
int third_number = number % 10;
int final_number = first_number + third_number;
Console.WriteLine(final_number);