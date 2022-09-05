Console.WriteLine("введите параметры вашего массива (m): ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("введите параметры вашего массива (n): ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("введите минимальное значение в массиве: ");
int MinValue = int.Parse(Console.ReadLine());
Console.WriteLine("введите максимальное значение в массиве: ");
int MaxValue = int.Parse(Console.ReadLine());

Random x = new Random();
double [,] GetArray(int m, int n, int MinValue, int MaxValue)
{
    double [,] result = new double [m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Convert.ToDouble(x.Next(MinValue * 10, MaxValue * 10) / 10.0);
        }
    }
    return result;
}

void PrintArray (double [,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    
    }
}

double [,] newArray = GetArray (m, n, MinValue, MaxValue);
PrintArray(newArray);