using System;

class Task4
{
    static void Main()
    {
        Console.Write("a b c: ");
        var p = Console.ReadLine().Split();

        double a = double.Parse(p[0]);
        double b = double.Parse(p[1]);
        double c = double.Parse(p[2]);

        double d = b * b - 4 * a * c;

        if (d < 0)
            Console.WriteLine("Няма реални корени");
        else
        {
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine($"Корени: {x1}, {x2}");
        }
    }
}
