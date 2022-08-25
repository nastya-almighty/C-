Console.WriteLine("сколько элементов будет в массиве? ");
int N = int.Parse(Console.ReadLine());

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(1, 100);
        Console.WriteLine(array[index]);
        index++;
    }
}


int[] array = new int [N];

FillArray(array);

int sum = 0;

for(int i = 1; i < array.Length; i += 2)
{
    sum = sum + array[i];
}
Console.Write("cумма чисел с нечетным индексом - ");
Console.WriteLine(sum);