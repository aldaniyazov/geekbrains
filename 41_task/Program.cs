void AmountMoreZero(int[] array)
{   
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count = count + 1;
        } 
    }
    Console.WriteLine($"User entered {count} numbers greater than zero");
}

int[] numbers;

Console.Write("Enter numbers separated by spaces: ");
numbers = Console.ReadLine().Split(' ')
.Select(e => Convert.ToInt32(e)).ToArray();

AmountMoreZero(numbers);