/*
Задача 18: Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/

string get_diapason_of_quorter(int quoter)
{
    string result = "пустота";
    if (quoter == 1)
    {
        result = ("X > 0, Y >0");
    }  
    else if (quoter == 2)
    {
        result = ("X < 0, Y > 0");
    }  
    else if (quoter == 3)
    {
        result = ("X < 0, Y < 0");
    }
    else if (quoter == 4)
    {
        result = ("X > 0, Y < 0");
    }
    return result;
}

Console.WriteLine("Введите номер четверти");
int number_of_quorter = Convert.ToInt32(Console.ReadLine());
string diapason = get_diapason_of_quorter(number_of_quorter);
System.Console.WriteLine($"диапазон точек в выбранной {number_of_quorter} четверти лежит в :{diapason}");





