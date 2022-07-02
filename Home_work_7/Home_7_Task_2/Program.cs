Console.WriteLine("Введите два числа ");
int number_a = Convert.ToInt32(Console.ReadLine());
int number_b = Convert.ToInt32(Console.ReadLine());

if(number_a > number_b)
    {
        Console.WriteLine($"большее число равно {number_a} , меньшее равно {number_b}");
    }
else{
        Console.WriteLine($"большее число равно {number_b} , меньшее равно {number_a}");
}
