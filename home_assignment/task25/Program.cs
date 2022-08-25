Console.WriteLine("введите число: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("натуральная степень, в которую нужно возвести ваше число: ");
int B = int.Parse(Console.ReadLine());

int x = 1;

for(int i = 1; i <= B; i++)
{
    x = x * A;
}

Console.Write("ответ: ");
Console.WriteLine(x);