int [,] Detour (int rows, int col)
{
    int N = ((rows + col) * 2 - 4);
    
    int sum = 0;
    int w = 0;
    int N1 = 0;
    
    int [,] arr = new int [rows, col];

    for (int z = 0; z < (rows + 1) / 2; z++)
    {
        int count = 1;
        rows = rows - w;
        col = col - w;
    
        while (count < N + 1)
        {                
            int x = w;
            for (int y = 0; y < col; y++)
            {
                arr [x, y] = count + sum;
                count++;
            }
            int a = col - 1;
            for (int b = w + 1; b < rows; b++)
            {
                arr [b, a] = count + sum;
                count++;
            }
            int c = rows - 1;
            for (int d = col - 2; d >= w; d--)
            {
                arr[c, d] = count + sum;
                count++;
            }
            int e = w;
            for (int f = col - 2; f > w; f--)
            {
                arr[f, e] = count + sum;
                count++;
            }
            
        }
        
        sum += count - 2;
        Console.WriteLine(sum);
        w++;
        N1 = (rows * col) - N - N1;
        N = N1;
    }
    return arr;
}

int [,] spiral = Detour(4, 4);
PrintArray(spiral, 4, 4);


void PrintArray (int [,] array, int rows, int col)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    
    }
}


