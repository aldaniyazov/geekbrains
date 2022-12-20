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

void BebbleSortRows(int[,] matr)
{
    int temp = 0;
    for (int row = 0; row < matr.GetLength(0); row++)
    {
        for (int bubble = 0; bubble < matr.GetLength(1); bubble++)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1) - 1; j++)
                {
                    if (i == 0 + row)
                    {
                        if (matr[i, j] > matr[i, j + 1])
                        {
                            temp = matr[i, j];
                            matr[i, j] = matr[i, j + 1];
                            matr[i, j + 1] = temp;
                        }
                    }
                }
            }
        }
    }
}

void StartMethod()
{
    int[,] matrix = new int[7, 10];

    FillArray(matrix);
    PrintArray(matrix);
    Console.WriteLine();
    BebbleSortRows(matrix);
    PrintArray(matrix);
}

StartMethod();