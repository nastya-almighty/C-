Console.WriteLine("введите начало диапазона: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите конец диапазона: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("сколько элементов будет в массиве? ");
int N = int.Parse(Console.ReadLine());

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(a, b);
        index++;
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(array[position]);
        position++;
    }
}

int[] array = new int [N];

FillArray(array);
Console.WriteLine("ваш массив: ");
PrintArray(array);