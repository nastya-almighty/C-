Console.WriteLine("введите ваше число ");
int N = int.Parse(Console.ReadLine());

int fact()
{
    int a = 1;
    for(int i = 1; i <= N; i++)
    {
        a = a * i;
    }
    return a;
}
Console.WriteLine(fact());