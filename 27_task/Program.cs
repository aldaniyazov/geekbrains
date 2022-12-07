void SumDig(int number)
{
    Console.Write("Enter the number: ");
    number = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    int remainder = 0;
    while (number > 0)
    {
        remainder = number % 10;
        number = number / 10;
        sum = sum + remainder;
    }
    Console.WriteLine($"Sum of digits in number = {sum}");
}

int n = 0;

SumDig(n);