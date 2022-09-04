double Fact(int x)
{
    if (x == 1 | x == 0) return 1;
    else return x * Fact(x - 1);
}


Console.WriteLine(Fact(40));