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
            result[i, j] = new Random().Next(MinValue, MaxValue + 1);
        }
    }
    return result;
}

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

int [,] newArray = GetArray (m, n, MinValue, MaxValue);
PrintArray(newArray);

int [] Sum (int [,] array)
{
    int [] res = new int [m];
    
    for (int i = 0; i < m; i++)
    {
        int sum = 0;
        for (int j = 0; j < n; j++)
        {
            sum += array [i, j];
        }
        res [i] = sum;    
    }
    return res;
}
int i = 0;
int Minimum (int [] a)
{
    int min = a[i];
    int MinM = 0;
    for (int i = 0; i < a.Length; i++)
    {
       if (a[i] < min) 
       {
        min = a[i];
        MinM = i;
       }
    }
    return MinM + 1;
}

Console.WriteLine();
Console.Write("строка с наименьшей суммой элементов - ");
int [] SumArray = Sum(newArray);
Console.WriteLine(Minimum(SumArray));