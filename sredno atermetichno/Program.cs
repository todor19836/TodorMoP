using System;
using System.Linq;

class Task2
{
    static void Main()
    {
        Console.WriteLine("Въведи числа разделени с интервал:");
        double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();

        double average = nums.Average();

        double median = nums.OrderBy(x => x)
                            .Skip(nums.Length / 2)
                            .Take(nums.Length % 2 == 0 ? 2 : 1)
                            .Average();

        double mode = nums.GroupBy(x => x)
                          .OrderByDescending(g => g.Count())
                          .First().Key;

        Console.WriteLine($"Средно: {average}");
        Console.WriteLine($"Медиана: {median}");
        Console.WriteLine($"Мода: {mode}");
    }
}
