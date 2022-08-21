Console.WriteLine("введите пятизначное число a: ");
int a = int.Parse(Console.ReadLine());

if(a / 10000 < 1 | a / 10000 > 9)
{
    Console.WriteLine("а это не пятизначное число, труляля");
}
else
{
    if((a % 10) == (a / 10000))
    {
        if(((a % 100) / 10) == ((a / 1000) % 10))
        {
            Console.WriteLine("ваше число является палиндромом");
        }
        else Console.WriteLine("ваше число не является палиндромом");
    }
else Console.WriteLine("ваше число не является палиндромом");
}
