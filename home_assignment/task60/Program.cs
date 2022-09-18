Console.WriteLine("задайте сторону вашего трехмерного кубического массива: ");
int N = int.Parse(Console.ReadLine());


int [] SourceArray(int MinValue, int MaxValue)
{
    int size = MaxValue - MinValue;
    int [] res = new int [size];
    res = Enumerable.Range(MinValue, MaxValue - MinValue + 1).ToArray();
      
    return res;
}

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


void ShowArray (int [,,] arr)
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

int [] s = SourceArray(10, 99);

int [] sourse = Shuffle(s);

if (N < 5)
{
    int [,,] threeDArray = GetArray(N, sourse, 10, 99);
    ShowArray(threeDArray);
}
else Console.WriteLine("чтобы числа не повторялись, сторона трехмерного массива должна быть меньше 5");
