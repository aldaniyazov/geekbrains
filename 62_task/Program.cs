void SpiralFillMatrix(int[,] matr, int startNum, int dimen)
{
    int N = dimen, M = dimen;
    startNum -= 1;

    int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = M;

    for (int i = startNum; i < matr.Length + startNum; i++)
    {
        matr[row, col] = i + 1;
        if (--gran == 0)
        {
            gran = M * (dirChanges % 2) + N * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
        col += dx;
        row += dy;
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

void Start()
{
    Console.Write("Enter the dimension of the matrix: ");
    int dimension = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the number from which the filling starts: ");
    int firstNum = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = new int[dimension,dimension];

    SpiralFillMatrix(matrix, firstNum, dimension);
    PrintArray(matrix);
}

Start();