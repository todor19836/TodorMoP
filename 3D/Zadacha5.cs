using System;
using System.Linq;

class Task5
{
    static void Main()
    {
        Console.Write("Брой вектори: ");
        int n = int.Parse(Console.ReadLine());

        double minLen = double.MaxValue;
        double[] minVector = null;

        for (int i = 0; i < n; i++)
        {
            var v = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double len = Math.Sqrt(v[0] * v[0] + v[1] * v[1] + v[2] * v[2]);

            if (len < minLen)
            {
                minLen = len;
                minVector = v;
            }
        }

        Console.WriteLine($"Най-къс вектор: ({string.Join(", ", minVector)})");
        Console.WriteLine($"Дължина: {minLen}");
    }
}
