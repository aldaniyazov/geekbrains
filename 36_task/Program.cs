Console.WriteLine("Введи число элементов в массиве:");
int sum = 0;
void SumNumbers()
{
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-1000, 1000);
    foreach (int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();

    for (int i = 0; i < array.Length; i++)
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    Console.WriteLine($"Сумма элементов массива, стоящих в нечётных позициях ={sum}");
}
SumNumbers();