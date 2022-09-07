Console.WriteLine("задайте ширину вашей первой матрицы (m): ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("задайте длину вашей первой матрицы (n): ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("задайте ширину второй матрицы (v): ");
int v = int.Parse(Console.ReadLine());
Console.WriteLine("задайте длину второй матрицы (w): ");
int w = int.Parse(Console.ReadLine());

Console.WriteLine("введите минимальное значение в матрицах: ");
int MinValue = int.Parse(Console.ReadLine());
Console.WriteLine("введите максимальное значение в матрицах: ");
int MaxValue = int.Parse(Console.ReadLine());

int [,] GetMatrix (int m, int n, int MinValue, int MaxValue)
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

void PrintMatrix (int [,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write($"{mat[i, j]} ");
        }
        Console.WriteLine();
    
    }
}

int [,] Matrix1 = GetMatrix (m, n, MinValue, MaxValue);
int [,] Matrix2 = GetMatrix (v, w, MinValue, MaxValue);
int size1x = Matrix1.GetLength(0);
int size2y = Matrix2.GetLength(1);

PrintMatrix(Matrix1);
Console.WriteLine();
PrintMatrix(Matrix2);

int [,] Multiply (int [,] matr1, int [,] matr2)
{
    int [,] res = new int [size1x, size2y];

    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for (int x = 0; x < matr2.GetLength(0); x++)
                {
                    res [i, j] += matr1[i, x] * matr2[x, j];
                }
        }
    }
    return res;
}

int [,] resultMatrix = Multiply(Matrix1, Matrix2);

Console.WriteLine();
PrintMatrix(resultMatrix);