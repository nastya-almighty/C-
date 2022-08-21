int [] arr = {7, 3, 2, 5, 4, 1, 6, 1, 1};
void PrintArray(int [] arr)
{
    int count = arr.Length;

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr);

void SelectionSort (int [] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        int minPos = i;

        for(int j = i + 1; j < arr.Length; j++)
        {
            if(arr[j] < arr[minPos]) minPos = j;
        }

        int temp = arr[i];
        arr[i] = arr[minPos];
        arr[minPos] = temp;
    }
}
SelectionSort(arr);
PrintArray(arr);

void SelectionSort2 (int [] arr)
{
   for(int a = 0; a < arr.Length / 2; a++);
{
    int temp2 = arr[a];
    arr[a] = arr[arr.Length + 1 - a];
    arr[arr.Length + 1 - a] = temp2;
} 
}

SelectionSort2(arr);
PrintArray(arr);