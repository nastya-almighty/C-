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

int [,] Order (int [,] arr, int m, int n)
{
    int temp;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
           for (int w = j + 1; w < n; w++)
            {
                if (arr[i, w] > arr[i, j])
                {
                    temp = arr[i, j];
                    arr[i, j] = arr [i, w];
                    arr[i, w] = temp;
                }
            }
        }
    }
    return arr;
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

int [,] orderedArray = Order (newArray, m, n);

Console.WriteLine();
PrintArray(orderedArray);