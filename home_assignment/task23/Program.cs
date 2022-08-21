Console.WriteLine("введите число N: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("кубы чисел от 1 до N:");

if(N > 0)
{
    for (int i = 1; i <= Math.Abs(N); i++)
    {
      double x = Math.Pow(i, 3);
      Console.WriteLine(x);  
    }
}
else
{
    for (int i = 1; Math.Abs(i) <= Math.Abs(N) | N == 0; i--)
    {
        double x = Math.Pow(i, 3);
        Console.WriteLine(x);
        if(Math.Abs(i) == Math.Abs(N))
        {
            break;
        }
    }
}