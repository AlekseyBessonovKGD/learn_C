/* Задача 40: Напишите программу, которая принимает на вход три
 числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
 */

Console.WriteLine("Введите 3 числа соответствующие длинам сторон треугольника");
int side_a = Convert.ToInt32(Console.ReadLine());
int side_b = Convert.ToInt32(Console.ReadLine());
int side_c = Convert.ToInt32(Console.ReadLine());

if( side_c < side_a + side_b && side_b < side_a + side_c && side_a < side_b + side_c) 
{
    Console.WriteLine($"Треугольник с длинами сторон равными {side_a} , {side_b} , {side_c} существует");
}
else
{
    Console.WriteLine($"Треугольник с длинами сторон равными {side_a} , {side_b} , {side_c} не существует");
}