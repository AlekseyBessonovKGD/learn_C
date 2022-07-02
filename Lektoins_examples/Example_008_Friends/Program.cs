int count = 0;
double distance = 100000;
int speed_friend_1 = 2;
int speed_friend_2 = 7;
int speed_dog = 10;
int friend = 1;
double time = 0;

while (distance > 10)
{
    if (friend % 2 == 0)
    {
        time = distance / (speed_friend_1 + speed_dog);
    }
    if (friend % 2 > 0)
    {
        time = distance / (speed_friend_2 + speed_dog);
    }
    distance = distance - (speed_friend_1 + speed_friend_2) * time;
    friend = friend +1;
    count = count + 1;
}
Console.Write("количество раз, которое пробежала собака равно ");
Console.WriteLine(count);