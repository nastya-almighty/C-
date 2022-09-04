Console.WriteLine("сколько элементов будет в массиве? ");
int M = int.Parse(Console.ReadLine());


int [] array = NewArray(M);
Console.WriteLine(String.Join(" ", array));

int [] NewArray(int M)
{
    int [] res = new int [M];
    int count = 0;
    for(int i = 0; i < M; i++)
    {
        Console.WriteLine("Введите свое число");
        res [i] = Convert.ToInt32(Console.ReadLine());
        if (res[i] > 0)
        {
            count++;
        }
    }
    Console.Write("количество положительных элементов в вашем массиве - ");
    Console.WriteLine(count);
    return res;
}