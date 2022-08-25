Console.WriteLine("введите высоту вашей елочки ");
int h = int.Parse(Console.ReadLine());

Console.Clear();


for (int i = h - 1; i >= 0; i--)
{
    Console.SetCursorPosition(h, i);
    Console.WriteLine("*");

    for (int j = i; j > 0; j--)
    {
        Console.SetCursorPosition(h + j, i);
        Console.Write("*");
        Console.SetCursorPosition(h - j, i);
        Console.Write("*");
    }
}
Console.SetCursorPosition(h - 1, h);
Console.WriteLine("| |");