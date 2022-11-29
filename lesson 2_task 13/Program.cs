int num = new Random().Next(10,1000);
Console.WriteLine($"Ваше число: {num}");
if (num > 99)
{
    while (num > 999)
    {
        num = num / 10;
    }
    Console.WriteLine($"Третья цифра {num % 10}");
}
else Console.WriteLine("Третьей цифры нет");