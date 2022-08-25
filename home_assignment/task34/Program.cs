Console.WriteLine("создаём массив из положительных трехзначных чисел");
Console.WriteLine("сколько элементов будет в массиве? ");
int N = int.Parse(Console.ReadLine());

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(100, 1000);
        Console.WriteLine(array[index]);
        index++;
    }
}


int[] array = new int [N];

FillArray(array);


int x = 0;

for(int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        x = x + 1;
    }
}

Console.Write("количество четных чисел в массиве - ");
Console.WriteLine(x);