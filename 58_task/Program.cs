void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MatrixProduct(int[,] matr1, int[,] matr2, int[,] resultMatr)
{
    for (int i = 0; i < resultMatr.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatr.GetLength(1); j++)
        {
            resultMatr[i, j] = matr1[i, j] * matr2[i, j];
        }
    }
}

void StartMethod()
{
    Console.WriteLine("Enter the size of the array MxN.");

    Console.Write("Enter m: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter n: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[,] matrix1 = new int[m, n];
    int[,] matrix2 = new int[m, n];
    int[,] resultMatrix = new int[m, n];

    Console.WriteLine();
    FillArray(matrix1);
    PrintArray(matrix1);
    Console.WriteLine();

    FillArray(matrix2);
    PrintArray(matrix2);
    Console.WriteLine();

    MatrixProduct(matrix1, matrix2, resultMatrix);
    PrintArray(resultMatrix);
}

StartMethod();