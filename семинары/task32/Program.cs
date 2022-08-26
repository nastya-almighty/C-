Console.WriteLine("задайте минимум массива: ");
int MinValue = int.Parse(Console.ReadLine());
Console.WriteLine("задайте максимум массива: ");
int MaxValue = int.Parse(Console.ReadLine());


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

int [] array = NewArray(size, MinValue, MaxValue);
Console.WriteLine(String.Join(" ", array));

int [] Rev (int [] mas)
    {
        for (int i = 0; i < size; i++)
        {
            array[i] *= -1;
        }
        return mas;
    }
Console.WriteLine(String.Join(" ", Rev(array)));