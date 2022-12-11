void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void SearchEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) 
        {
            count = count + 1;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"The number of even numbers is {count}");
}

int[] a = new int[6];

FillArray(a);
PrintArray(a);
SearchEven(a);