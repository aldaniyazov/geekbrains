Console.WriteLine("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 6 || day == 7)
{
    Console.WriteLine("Выходной день -> да");
}
else if (day < 1 || day > 7)
{
    Console.WriteLine("Это вообще не день недели");
}
else
{
    Console.WriteLine("Будний день -> да");
}