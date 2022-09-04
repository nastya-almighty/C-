int [,] arr = new int [,]
{
{1, 2, 3},
{4, 5, 6},
{7, 8, 9}
};

int w = 0;
    int rows = arr.GetLength(0) - w;
    int col = arr.GetLength(1) - w;
    int N = ((rows + col) * 2 - 4);
    int count = 0;
    
    while (count < N)
    {
        int i = rows - 1;
        for (int j = 0; j < col; j++)
        {
            Console.Write($"{arr[i, j]} ");
            count++;
        }
        int a = col - 1;
        for (int b = rows - 2; b >= 0; b--)
        {
            Console.Write($"{arr[b, a]} ");
            count++;
        }
        int c = 0;
        for (int d = col - 2; d >= 0; d--)
        {
            Console.Write($"{arr[c, d]} ");
            count++;
        }
        int e = 0;
        for (int f = 1; f < rows; f++)
        {
            Console.Write($"{arr[f, e]} ");
            count++;
        }

    }
    w++;
    N = arr.Length - N;
