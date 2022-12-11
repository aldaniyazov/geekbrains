void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i = i + 2)
    {
        array[i] = new Random().Next(21, 101);
    }

    for (int i = 1; i < array.Length; i = i + 2)
    {
        array[i] = new Random().Next(1, 21);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void DiffMinMax(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
    }

    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
    }

    int diff = max - min;
    Console.WriteLine();
    Console.WriteLine($"The difference between the maximum and minimum element is {diff}");
}

int[] a = new int[6];

FillArray(a);
PrintArray(a);
DiffMinMax(a);