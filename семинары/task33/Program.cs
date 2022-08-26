Console.WriteLine("сколько элементов будет в массиве? ");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("минимум в массиве: ");
int MinValue = int.Parse(Console.ReadLine());
Console.WriteLine("максимум в массиве ");
int MaxValue = int.Parse(Console.ReadLine());
Console.WriteLine("число для поиска ");
int number = int.Parse(Console.ReadLine());


bool FindArray (int [] array, int number)
{
   for (int i = 0; i < size; i++)
   {
    if(array[i] == number)
    {
        return true;
        break;
    }
   }
   return false;
}

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

Console.WriteLine("присутствует ли число в массиве?");
if (FindArray(array, number))
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}