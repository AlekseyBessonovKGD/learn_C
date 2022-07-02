int max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result)
    {
        result = arg2;
    }
    if (arg3 > result)
    {
        result = arg3;
    }
    return result;
}
int a1 = 11;
int b1 = 22;
int c1 = 12;
int a2 = 25;
int b2 = 33;
int c2 = 55;
int a3 = 34;
int b3 = 95;
int c3 = 32;

int total_max = max(max(a1,b1,c1), max(a2,b2,c2), max(a3,b3,c3));

Console.WriteLine(total_max);