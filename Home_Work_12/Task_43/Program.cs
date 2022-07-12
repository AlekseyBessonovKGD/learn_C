/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.WriteLine("задайте значение переменной к1 в уравнении у = k1*x + b1");
double number_k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("задайте значение переменной b1 в уравнении у = k1*x + b1");
double number_b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("задайте значение переменной k2 в уравнении у = k2*x + b2");
double number_k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("задайте значение переменной b2 в уравнении у = k2*x + b2");
double number_b2 = Convert.ToDouble(Console.ReadLine());

double cross_point_x = (number_b2 - number_b1) / (number_k1 - number_k2);
double cross_point_y = (number_b1*number_k2 - number_b2*number_k1) / (number_k2 - number_k1);

Console.WriteLine($"Прямые пересекутся в точке с координатами ({Math.Round(cross_point_x, 1)}; {Math.Round(cross_point_y, 1)})");