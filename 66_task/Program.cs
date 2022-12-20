void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void FillArray(int[] array, int firstNum)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = firstNum + i;
    }
}

void SumElements(int[] array)
{   
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + array[i];
    }
    Console.WriteLine($"The sum of the elements is {sum}");
}

void Start()
{
    Console.Write("Enter M value: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter N value: ");
    int n = Convert.ToInt32(Console.ReadLine());

    if (n < m)
    {
        Console.WriteLine("The value of N must be greater than M.");
        return;
    }

    int[] numbers = new int[n - m + 1];

    FillArray(numbers, m);
    PrintArray(numbers);
    Console.WriteLine();
    SumElements(numbers);
}

Start();