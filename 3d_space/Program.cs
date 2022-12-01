void EnterCoord(int[] coordinate1, int[] coordinate2)
{
    for (int i = 0; i < coordinate1.Length; i++)
    {
        Console.Write("Введите координаты x1, y1, z1 через enter первой точки: ");
        coordinate1[i] = Convert.ToInt32(Console.ReadLine());
    }

    for (int i = 0; i < coordinate2.Length; i++)
    {
        Console.Write("Введите координаты x2, y2, z2 через enter второй точки: ");
        coordinate2[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void DistanceSearch(int[] a, int[] b)
{
    int SqDiff1 = (b[0] - a[0])*(b[0] - a[0]);
    int SqDiff2 = (b[1] - a[1])*(b[1] - a[1]);
    int SqDiff3 = (b[2] - a[2])*(b[2] - a[2]);

    int sum = SqDiff1 + SqDiff2 + SqDiff3;

    double dist = Math.Sqrt(sum);

    Console.WriteLine($"Дистанция между двумя точками: {Math.Round(dist, 2)}");
    //Math.Round(число, кол-во знаков после ",") округление числа
}

int[] a = new int[3];
int[] b = new int[3];

EnterCoord(a, b);
DistanceSearch(a, b);