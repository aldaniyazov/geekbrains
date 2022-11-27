int num = new Random().Next(100,1000);
Console.WriteLine($"Ваше число: {num}");
int d = num % 10;
int n = num / 100;
Console.WriteLine($"{n}{d}");