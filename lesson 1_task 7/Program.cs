Console.Clear();
Console.WriteLine("Задача 7 HARD по желанию - идет за 2 необязательных");

Console.Write("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());
string numText = Convert.ToString(num);
if (numText.Length > 2)
{
  Console.WriteLine("третья цифра -> " + numText[2]);
}
else
{
  Console.WriteLine("-> третьей цифры нет");
}