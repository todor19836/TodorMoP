using System;
using System.Linq;

class Task6
{
    static void Main()
    {
        var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var b = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Console.WriteLine("Сечение: " + string.Join(" ", a.Intersect(b)));
        Console.WriteLine("Обединение: " + string.Join(" ", a.Union(b)));
        Console.WriteLine("Разлика A-B: " + string.Join(" ", a.Except(b)));
    }
}
