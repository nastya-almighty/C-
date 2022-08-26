Console.WriteLine("задайте минимум массива: ");
int MinValue = int.Parse(Console.ReadLine());
Console.WriteLine("задайте максимум массива: ");
int MaxValue = int.Parse(Console.ReadLine());


Console.WriteLine("сколько элементов будет в массиве? ");
int size = int.Parse(Console.ReadLine());

int [] GetArray(int size, int MinValue, int MaxValue)
{
    int [] res = new int [size];

    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(MinValue, MaxValue);
    }
    return res;
}

int [] array = GetArray(size, MinValue, MaxValue);
Console.WriteLine(String.Join(" ", array));

int Nums(int [] array)
{
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            count++;
        }
    }
    return count;
}

Console.Write("количество чисел из промежутка от 10 до 99: ");

Console.WriteLine(Nums(array));