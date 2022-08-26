Console.WriteLine("сколько элементов будет в массиве? ");
int N = int.Parse(Console.ReadLine());

int NewArray(int Array)
{
    int [] array = new int [N];
    int index = 0;
    while (index < N)
    {
        array[index] = new Random().Next(0, 2);
        Console.WriteLine(array[index]);
        index++;
    }
    return Array;
}
NewArray(N);