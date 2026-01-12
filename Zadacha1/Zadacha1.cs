using System;

class Task1
{
    static void Main()
    {
        Console.Write("Число: ");
        string number = Console.ReadLine();

        Console.Write("От бройна система: ");
        int fromBase = int.Parse(Console.ReadLine());

        Console.Write("Към бройна система: ");
        int toBase = int.Parse(Console.ReadLine());

        int decimalValue = Convert.ToInt32(number, fromBase);
        string result = Convert.ToString(decimalValue, toBase);

        Console.WriteLine("Резултат: " + result);
    }
}
