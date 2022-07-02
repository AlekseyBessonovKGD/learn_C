/* Задача 21: Напишите программу, которая принимает на 
вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
 */
Console.WriteLine("Введите координаты X и Y первой точки:");
double point_a_x = Convert.ToDouble(Console.ReadLine());
double point_a_y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты X и Y второй точки:");
double point_b_x = Convert.ToDouble(Console.ReadLine());
double point_b_y = Convert.ToDouble(Console.ReadLine());

double length = Math.Sqrt(Math.Pow(point_b_x - point_a_x,2) + Math.Pow(point_b_y - point_a_y,2));
System.Console.WriteLine($"длинна отрезка равна {Math.Round(length,2)}");

