internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите 8 целых чисел через пробел:");
        static void Arr()
        {
            string s = Console.ReadLine();
            string[] line = s.Split(' ');
            int[] array = new int[line.Length];
            Console.Write("[");
            for (int i = 0; i < line.Length - 1; i++)
            {
                array[i] = int.Parse(line[i]);
                Console.Write($"{array[i]}, ");
            }
            for (int i = line.Length - 1; i < line.Length; i++)
            {
                array[i] = int.Parse(line[i]);
                Console.Write($"{array[i]}]");
            }
        }
        Arr();
    }
}