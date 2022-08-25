Console.WriteLine("введите высоту вашей елочки ");
int h = int.Parse(Console.ReadLine());

Console.Clear();


for (int i = h; i >= 0; i--)
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
Console.WriteLine();
Console.SetCursorPosition(h - 1, h + 1);
Console.WriteLine("| |");