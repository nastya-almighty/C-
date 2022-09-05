Console.WriteLine("введите параметры искомого элемента (m): ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("введите параметры искомого элемента (n): ");
int n = int.Parse(Console.ReadLine());

int [,] array = new int [,]
{
{1, 4, 7, 2},
{5, 9, 2, 3},
{8, 4, 2, 4}
};

int rows = array.GetLength(0);
int col = array.GetLength(1);

int Check (int [,] arr, int a, int b)
{
    if (a < rows & b < col) 
    {
        Console.Write("значение элемента с указанным индексом: ");
        Console.WriteLine(arr[m, n]);
    }
    else Console.WriteLine ("элемента с таким индексом в массиве нет"); return 0;
    
    return arr[m, n];
}

Check(array, m, n);