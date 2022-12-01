void EnterNum(int[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = i + 1;
    }
}

void Cube(int[] number)
{   
    for (int i = 0; i < number.Length; i++)
    {
        Console.Write($"{Math.Pow(number[i], 3)} ");
    }
}

Console.Write("Enter the number: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];

EnterNum(array);
Cube(array);