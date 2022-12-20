int AckFunc(int m, int n)
{
    if (m == 0) return n + 1;

    else if (m > 0 && n == 0) return AckFunc(m - 1, 1);

    else if (m > 0 && n > 0) return AckFunc(m - 1, AckFunc(m, n - 1));

    else return n + 1;
}

void Start()
{
    Console.WriteLine("A(m, n)");
    Console.Write("Enter M value: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter N value: ");
    int n = Convert.ToInt32(Console.ReadLine());

    if (m < 0 || n < 0)
    {
        Console.WriteLine("Numbers M and N must be positive.");
        return;
    } 

    int result = AckFunc(m, n);
    Console.WriteLine(result);
}

Start();