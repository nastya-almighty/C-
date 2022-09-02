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

int CountPos (int [] array)
{
    int count = 0;
    for (int i = 0; i < N; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

Console.Write("количество положительных чисел в массиве - ");
Console.WriteLine(CountPos(array));