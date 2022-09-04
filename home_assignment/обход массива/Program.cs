int [,] array = new int [,]
{
{1, 2, 3},
{4, 5, 6},
{7, 8, 9}
};

int rows = array.GetLength(0);
int col = array.GetLength(1);
int N = ((rows + col) * 2 - 4);
int w = 0;
int N1 = 0;

void Detour (int [,] arr, int rows, int col)
{
    for (int x = 0; x < (rows + 1) / 2; x++)
    {
        int count = 0;
        rows = rows - w;
        col = col - w;
    
        while (count < N)
        {
            int i = rows - 1;
            for (int j = w; j < col; j++)
            {
                Console.Write($"{arr[i, j]} ");
                count++;
            }
            int a = col - 1;
            for (int b = rows - 2; b >= w; b--)
            {
                Console.Write($"{arr[b, a]} ");
                count++;
            }
            int c = w;
            for (int d = col - 2; d >= w; d--)
            {
                Console.Write($"{arr[c, d]} ");
                count++;
            }
            int e = w;
            for (int f = 1 + w; f < rows - 1; f++)
            {
                Console.Write($"{arr[f, e]} ");
                count++;
            }

        }
        w++;
        N1 = array.Length - N - N1;
        N = N1;
    }
}

Detour(array, rows, col);
