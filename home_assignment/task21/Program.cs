Console.WriteLine("введите координату x точки A: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите координату y точки A: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите координату z точки A: ");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("введите координату x точки B: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("введите координату y точки B: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("введите координату z точки B: ");
int z2 = int.Parse(Console.ReadLine());

double x = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow (z2 - z1, 2));
double distance = Math.Round(x, 2);
Console.WriteLine("расстояние между точками в 3D пространстве:");
Console.WriteLine(distance);