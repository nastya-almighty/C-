Console.WriteLine("введите размер вашего трехмерного массива (N): ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("введите минимальное значение в массиве: ");
int MinValue = int.Parse(Console.ReadLine());
Console.WriteLine("введите максимальное значение в массиве: ");
int MaxValue = int.Parse(Console.ReadLine());

bool Check (int z, int Min, int Max)
{
    if (N * N * N >= Max - Min - 1) return true;
    else return false;
}

int [] SourceArray(int MinValue, int MaxValue, int N)
{
    int size = MaxValue - MinValue;
    int [] res = new int [size];
    res = Enumerable.Range(MinValue, MaxValue - MinValue + 1).ToArray();
      
    return res;
}

int [] s = SourceArray(MinValue, MaxValue, N);
int [] sourse = Shuffle(s);

int [] Shuffle (int [] a)
{
    Random rand = new Random();
 
    for (int i = a.Length - 1; i >= 1; i--)
    {
        int j = rand.Next(i + 1);
 
        int temp = a[j];
        a[j] = a[i];
        a[i] = temp;
    }
    return a;
}



int [,,] GetArray(int N, int [] sourse, int Min, int Max)
{
    int [,,] result = new int [N, N, N];
    int count = 0;

    while (count < N * N * N)
    {
        {
            for (int x = 0; x < N; x++)
            {
                for (int y = 0; y < N; y++)
                {   
                    for (int z = 0; z < N; z++)
                    {
                        result[x, y, z] = sourse[count];
                        count++;                  
                    }
                }    
            }
        }
    }
    return result;
}


void ShowArray (int [,,] arr, int N)
{
    Console.WriteLine("ваш массив: ");
    for (int x = 0; x < N; x++)
    {
        for (int y = 0; y < N; y++)
        {
            for (int z = 0; z < N; z++)
            {
                Console.WriteLine($"{arr[x, y, z]}: ({x}, {y}, {z})");
            }

        }
    }
}

int [,,] threeDArray = GetArray(N, sourse, MinValue, MaxValue);

if (N * N * N >= MaxValue - MinValue) 
{
    ShowArray(threeDArray, N);
}
else Console.WriteLine("введите другой диапазон");