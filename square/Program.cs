Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int square = num * num;
//Console.WriteLine("Квадрат введенного числа равен "+square);
Console.WriteLine($"Квадрат введенного числа равен {square}");
if (num>9)
{
	Console.WriteLine("Вы ввели число больше 9");
}
else
{
	Console.WriteLine("Вы ввели число меньше 10");
}
while (num <= 25) // выводит все числа от введенного до 25
{
	Console.Write ($"{num} ");
	num++;
}

Console.WriteLine("Введите первое целое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число:");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2 * num2)
{
    Console.WriteLine("Первое число является квадратом второго числа");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго числа");
}