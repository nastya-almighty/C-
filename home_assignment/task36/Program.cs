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

int sum = 0;

for (int i = 1; i < N; i += 2)
{
    sum += array[i];
}
Console.Write("cумма чисел с нечетным индексом - ");
Console.WriteLine(sum);