Console.WriteLine("Введите целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"max = {num1}");
}
else if (num1 < num2)
{
    Console.WriteLine($"max = {num2}");
}
else
{
    Console.WriteLine("Numbers are equal");
}