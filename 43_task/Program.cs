Console.Write("Enter b1 value: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter k1 value: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter b2 value: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter k2 value: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k2 * ((b2 - b1) / (k1 - k2)) + b2;

if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("The lines are coincide.");
}
else if (k1 == k2)
{
    Console.WriteLine("The lines are parallel.");
}
else
{
    Console.WriteLine($"Point of intersection of the two lines ({x}; {y}).");
}