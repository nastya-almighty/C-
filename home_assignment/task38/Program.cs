Console.WriteLine("задайте минимум массива: ");
int MinValue = int.Parse(Console.ReadLine());
Console.WriteLine("задайте максимум массива: ");
int MaxValue = int.Parse(Console.ReadLine());
Console.WriteLine("сколько элементов будет в массиве? ");
int N = int.Parse(Console.ReadLine());

int [] NewArray(int N, int MinValue, int MaxValue)
{
    int [] res = new int [N];
    for(int i = 0; i < N; i++)
    {
        res[i] = new Random().Next(MinValue, MaxValue);
    }
    return res;
}

int [] array = NewArray(N, MinValue, MaxValue);
Console.WriteLine(String.Join(" ", array));

int x = 0;
int i = 0;

int MinMax(int [] array)
{
    int min = array[i];
    int max = array[i];
    for (int i = 0; i < N; i++)
    {
       if (array[i] > max) 
       {
        max = array[i];
       }
       if (array[i] < min) 
       {
        min = array[i];
       }
    }
    int x = max - min;
    return x;
}

Console.Write("разница между максимальным и минимальным числами массива: ");
Console.WriteLine(MinMax(array));