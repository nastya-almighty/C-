// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:


int [,] GetArray(int N, int MinValue, int MaxValue)
{
    int [,] result = new int [N, N];
    int w = 0;

    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            result[i, j] = 1 + j + w;
        }
        w += 4;
    }
    return result;
}
int [,] myArray = GetArray(4, 0, 16);

int SpiralArray (int [,] arr)
{
    
}



// int [,] SpiralArray = Detour(myArray, Z, N);
// PrintArray(SpiralArray, N);


void PrintArray (int [,] array, int N)
{
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    
    }
}

// PrintArray(myArray, 4);
Console.WriteLine();
