Console.WriteLine("Введите число для проверки его четности");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 > 0){
    Console.WriteLine("введенное число нечетное");
}
else{
    Console.WriteLine("введенное число четное");
}