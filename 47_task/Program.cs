Console.WriteLine("Введите количество строк m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m,n];
void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        array[i,j] = Convert.ToDouble(new Random().Next(-100,100))/10;
}
void PrintArray(double[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write($"{array[i,j]}\t");
    Console.WriteLine();
    }
}
FillArray(array);
PrintArray(array);