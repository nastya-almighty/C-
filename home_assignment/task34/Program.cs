Console.WriteLine("создаём массив из положительных трехзначных чисел");
Console.WriteLine("сколько элементов будет в массиве? ");
int size = int.Parse(Console.ReadLine());

int [] NewArray(int size, int MinValue, int MaxValue)
{
    int [] res = new int [size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(MinValue, MaxValue);
    }
    return res;
}

int [] array = NewArray(size, 100, 1000);
Console.WriteLine(String.Join(" ", array));

int CountEvenNums(int [] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("количество чётных чисел в массиве - ");

Console.WriteLine(CountEvenNums(array));