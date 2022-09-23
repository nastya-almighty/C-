Console.WriteLine("задайте минимальное значение: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("задайте максимальное значение: ");
int N = int.Parse(Console.ReadLine());

int Sum (int MinValue, int MaxValue)
{
    int s = 0;
    for (int i = MinValue; i <= MaxValue; i++)
    {
        s += i;
    }
    return s;
}

Console.Write("сумма натуральных элементов в промежутке от M до N - ");
Console.WriteLine(Sum (M, N));