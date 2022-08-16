Console.WriteLine("введите трёхзначное число x: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("вторая цифра числа - ");
Console.WriteLine((x % 100) / 10);