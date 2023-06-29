const int X = 10;
const int Y = 12;
int sum = 0;

if (X <= Y)
{
    for (int i = X; i <= Y; i++)
    {
        sum += i;
    }
}
else
{
    for (int i = Y; i <= X; i++)
    {
        sum += i;
    }
}
Console.WriteLine("Sum: " + sum);