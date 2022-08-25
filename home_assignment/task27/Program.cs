Console.WriteLine("введите число N: ");
int N = int.Parse(Console.ReadLine());

int Sum()
{
    N = Math.Abs(N);
    int sum = 0;
    while(N / 10 > 0)
    {
        sum = sum + (N % 10);
        N = N / 10;
    }
    sum = sum + N;
    return sum;
}

int sum = Sum();

Console.WriteLine("сумма цифр в числе: ");
Console.WriteLine(sum);