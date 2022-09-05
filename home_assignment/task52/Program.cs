Console.WriteLine("введите параметры вашего массива (m): ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("введите параметры вашего массива (n): ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("введите минимальное значение в массиве: ");
int MinValue = int.Parse(Console.ReadLine());
Console.WriteLine("введите максимальное значение в массиве: ");
int MaxValue = int.Parse(Console.ReadLine());

int [,] GetArray(int m, int n, int MinValue, int MaxValue)
{
    int [,] result = new int [m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(MinValue, MaxValue);
        }
    }
    return result;
}
int [,] newArray = GetArray (m, n, MinValue, MaxValue);

void PrintArray (int [,] array)
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

void Median (int [,] newArray)
{
    for (int j = 0; j < n; j++)
    {
        double sum = 0;
        for (int i = 0; i < m; i++)
        {
            sum = sum + newArray[i, j];
        }
        Console.Write($"среднее арифметическое в столбце {j + 1}: ");
        Console.WriteLine(Math.Round((sum / m), 2));
    }
}

PrintArray(newArray);

Console.WriteLine();

Median(newArray);

