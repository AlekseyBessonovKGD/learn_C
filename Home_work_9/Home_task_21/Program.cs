Console.WriteLine("введите координаты первой точки в трехмерном пространстве (X,Y,Z)");
double point_a_x = Convert.ToInt32(Console.ReadLine());
double point_a_y = Convert.ToInt32(Console.ReadLine());
double point_a_z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координаты второй точки в трехмерном пространстве (X,Y,Z)");
double point_b_x = Convert.ToInt32(Console.ReadLine());
double point_b_y = Convert.ToInt32(Console.ReadLine());
double point_b_z = Convert.ToInt32(Console.ReadLine());

double segment_length = 0;

segment_length =
Math.Sqrt(Math.Pow(point_b_x - point_a_x, 2)
+ Math.Pow(point_b_y - point_a_y, 2)
+ Math.Pow(point_b_z - point_a_z, 2));

System.Console.WriteLine($"длинна отрезка равна {Math.Round(segment_length, 2)}");