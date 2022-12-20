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

void SearchRowSmallestSumElements(int[,] matr)
{
    int row = 1;
    int minSum = 0;
    int sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == 0)
            {
                minSum = minSum + matr[i, j];
            }

            if (i > 0)
            {
                sum = sum + matr[i, j];

                if (j == matr.GetLength(1) - 1)
                {
                    if (sum < minSum)
                    {
                        minSum = sum;
                        sum = 0;
                        row = i + 1;
                    }
                    else
                    {
                        sum = 0;
                    }

                }
            }
        }
    }

    Console.WriteLine($"The smallest sum is {minSum}, it is in {row} row.");
}

void StartMethod()
{
    int[,] matrix = new int[3, 4];

    FillArray(matrix);
    PrintArray(matrix);
    Console.WriteLine();
    SearchRowSmallestSumElements(matrix);
}

StartMethod();