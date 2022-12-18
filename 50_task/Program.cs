Console.WriteLine("Введите количество строк m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 100);
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}
void FindNumber(int[,] array)
{
    int number = Convert.ToInt32(Console.ReadLine());
    int skip = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (number == array[i, j])
            {
                Console.WriteLine($"[{i}, {j}]");
            }
            else if (number != array[i, j])
            {
                skip++;
            }
    if (skip == array.Length)
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
}
Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();
FindNumber(array);