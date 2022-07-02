Console.Clear();
int xa = 1, ya = 1,
    xb = 1, yb = 30,
    xc = 90, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.Write("*");

Console.SetCursorPosition(xb, yb);
Console.Write("*");

Console.SetCursorPosition(xc, yc);
Console.Write("*");

int i = 0;

int x = xa;
int y = ya;

while(i<100000)
{
    int number = new Random().Next(0, 3);

    if(number == 0)
    {
        x = (x + xa)/2;
        y = (ya + y)/2;
    }
    if(number == 1)
    {
        x = (x + xb)/2;
        y = (y + yb)/2;
    }
    if(number == 2)
    {
        x = (x + xc)/2;
        y = (y + yc)/2;
    }
    Console.SetCursorPosition(x, y);
    Console.Write("*");
    i = i + 1;
}