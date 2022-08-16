Console.WriteLine("введите число x: ");
int x = int.Parse(Console.ReadLine());
if(x < 100 && x > -100)
Console.WriteLine("третьей цифры нет");
else
{
    x = (x / 100) % 10;
    Console.WriteLine("третья цифра числа - ");
    Console.WriteLine(Math.Abs(x));
}
