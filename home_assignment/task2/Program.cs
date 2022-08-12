Console.WriteLine("введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите число b: ");
int b = int.Parse(Console.ReadLine());
int max = a;
if(b > max) max = b;

Console.Write("max = ");
Console.WriteLine(max);
