int [] NewArray(int size, int MinValue, int MaxValue)
{
    int [] res = new int [size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(MinValue, MaxValue + 1);
    }
    return res;
}
int [] array = NewArray(12, -9, 9);
Console.WriteLine(String.Join(" ", array));

int possum = 0;
int netsum = 0;

foreach(int el in array)
{
    possum += el > 0 ? el : 0;
    netsum += el < 0 ? el : 0;
}

    /*
    if (el > 0)
    {
        possum += el;
    }
    else
    {
        //possum += 0;
    }
    */

Console.WriteLine($"PositiveSum = {possum}, NegativeSum = {netsum}");
