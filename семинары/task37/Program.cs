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

int [] NewArray ()
{
    int length = size / 2;
    if (size % 2 == 1) length++;

    int [] res2 = new int [length];

    for(int i = 0; i < length; i++)
    {
        res2[i] = array[i] * array[size - 1 - i];
    }
    if (size % 2 == 1) res2[length - 1] = array[size / 2];
    return res2;
}

int [] arr = NewArray();

Console.Write("ваш новый массив: ");
Console.WriteLine(String.Join(" ", arr));