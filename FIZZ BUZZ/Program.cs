int num = new Random().Next(10,1000);
Console.WriteLine($"Ваше число: {num}");

if ((num % 3 == 0) && (num % 5 == 0))
{
	Console.WriteLine("FizzBuzz");
}
else if (num % 3 == 0)
{
    Console.WriteLine("Fizz");
}
else if (num % 5 == 0)
{
    Console.WriteLine("Buzz");
}
else
{
	Console.WriteLine("нет");
}