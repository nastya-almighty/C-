Console.WriteLine("введите b1 ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите b2 ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите k1 ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите k2 ");
double k2 = Convert.ToDouble(Console.ReadLine());

void MiddlePoint (double b1, double b2, double b3, double b4)
{
    // y = k1 * x + b1;
    // y = k2 * x + b2;
    
    // k1 * x + b1 = k2 * x + b2
    // (k1 * x) - (k2 * x) = b2 - b1
    // x * (k1 - k2) = b2 - b1
    
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * ((b2 - b1) / (k1 - k2)) + b2;

    Console.Write("точка пересечения прямых: ");
    Console.WriteLine($"({x}, {y})");
}

MiddlePoint(b1, b2, k1, k2);