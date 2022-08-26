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

int [] BubbleSort(int [] array)
{
    int temp;
    for (int i = 0; i < N; i++)
    {
        for (int j = i + 1; j < N; j++)
        {
            if(array[j] > array[i])
            {
                temp = array[i];
                array[i] = array [j];
                array[j] = temp;
            }
        }
    }
   return array;
}

Console.WriteLine();
Console.Write("отсортированный массив: ");
Console.WriteLine(String.Join(" ", BubbleSort(array)));