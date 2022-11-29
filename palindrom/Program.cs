try
{
    void PalindromeSearch(int number)
    {
        Console.Write("Введите пятизначное число: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number.ToString()[0] == number.ToString()[4] && number.ToString()[1] == number.ToString()[3])
        {
            Console.WriteLine("Число является палиндромом");
        }
        else
        {
            Console.WriteLine("Число не является палиндромом");
        }
    }

    int n = 0;

    PalindromeSearch(n);
}
catch
{
    Console.WriteLine("Надо было вводить именно число");
}