int [] GetArray(int size, int MinValue, int MaxValue)
{
    int [] res = new int [size];

    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(MinValue, MaxValue + 1);
    }
    return res;
}

int [] ReverseArray(int [] array)
{
    int [] result = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[array.Length - i - 1];
    }
    return result;
}

int [] MyArray = GetArray(5, 0, 10);
Console.WriteLine(String.Join(" ", MyArray));
Console.WriteLine(String.Join(" ", (ReverseArray(MyArray))));